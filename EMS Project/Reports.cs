using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace EMS_Project
{
    public partial class Reports : Form
    {
        Thread th;
        MySqlConnection conn;
        DateTime minDate;
        DateTime maxDate;

        public string tableName { get; set; }
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.title.Text = $"{tableName} Report";
            //OpenConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;

            this.conn = new MySqlConnection(connectionString);
            this.conn.Open();
            MinMax_Date();
        }

        private void MinMax_Date()
        {
            string query = $"SELECT MIN(timestamp) AS min_timestamp, MAX(timestamp) AS max_timestamp FROM `{this.tableName}`";
            MySqlCommand cmd = new MySqlCommand(query, this.conn);

            // Execute minmax date finder query
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    minDate = reader.GetDateTime("min_timestamp");
                    maxDate = reader.GetDateTime("max_timestamp");
                }
            }

            this.dateReportsStartDate.MinDate = this.minDate;
            this.dateReportsStartDate.MaxDate = this.maxDate;
            this.dateReportsEndDate.MinDate = this.minDate;
            this.dateReportsEndDate.MaxDate = this.maxDate;
            this.cmbReportsFormat.SelectedIndex = 0;
        }

        private void GetData(object sender, EventArgs e)
        {
            string query = String.Format(@"SELECT * FROM `{0}` WHERE timestamp BETWEEN '{1} 00:00:00' AND '{2} 23:59:59'
                              AND HOUR(timestamp) % {3} = 0
                              AND MINUTE(timestamp) = 0
                              AND SECOND(timestamp) = 0
                              GROUP BY DATE(timestamp), HOUR(timestamp), MINUTE(timestamp)",
                              this.tableName,
                              this.dateReportsStartDate.Value.ToString("yyyy-MM-dd"),
                              this.dateReportsEndDate.Value.ToString("yyyy-MM-dd"),
                              Regex.Match(this.cmbReportsFormat.SelectedItem.ToString(), @"\d+").Value);

            MySqlCommand cmd = new MySqlCommand(query, this.conn);
            Console.WriteLine(cmd.CommandText);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                this.dataReportTable.Rows.Clear();
                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    this.dataReportTable.Rows.Add(row);
                    Console.WriteLine(reader.GetString("id"));
                }
            }
        }

        private void btnReportsClose_Click(object sender, EventArgs e)
        {
            th = new Thread(() => { Application.Run(new mainScreen()); });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.conn.Close();
            this.Close();
        }

        private void PrintData(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = $"{this.tableName} Report";
            printer.SubTitle = String.Format("This is a demo report", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.PrintPreviewDataGridView(this.dataReportTable);
        }
    }
}
