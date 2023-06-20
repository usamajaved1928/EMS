//using MySql.Data.MySqlClient
using System.Data.SqlClient;
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
        SqlConnection conn;
        DateTime minDate;
        DateTime maxDate;

        // Printer settings
        private Font FontTitle = new Font("Times New Roman", 22, FontStyle.Regular);
        private Font FontTableHeading = new Font("Times New Roman", 14, FontStyle.Bold);
        private Font FontRowHeading = new Font("Times New Roman", 12, FontStyle.Bold);
        private Font FontBody = new Font("Times New Roman", 12, FontStyle.Regular);
        private int tableRowsSpacing = 30;
        private int printableRows = 30; // Number of rows printed per page, if it is 29 it stand for 30
        int pageNum;
        private int itemNum;
        private int numberOfItemsPrintedSoFar;

        public string tableName { get; set; }
        public string tableTag { get;  set; }
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.title.Text = $"{tableName} Report";
            
            // Connection start
            string connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            this.conn = new SqlConnection(connectionString);
            this.conn.Open();
            MinMax_Date();
            try
            {
                this.conn = new SqlConnection(connectionString);
                this.conn.Open();
                MinMax_Date();
            }
            catch (Exception exp)
            {
                this.cmbReportsFormat.Enabled = false;
                this.dateReportsEndDate.Enabled = false;
                this.dateReportsStartDate.Enabled = false;
                this.btnReportsFindData.Enabled = false;
                this.btnReportsPrint.Enabled = false;
                string message = "There is an error while connecting to the database.";
                string title = "Database connection error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MinMax_Date()
        {
            string query = $"SELECT MIN(_Timestamp) AS min_timestamp, MAX(_Timestamp) AS max_timestamp FROM EMS2023.dbo.Table_140 WHERE _Name = '{this.tableTag}';";
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, this.conn);

            // Execute minmax date finder query
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    this.minDate = (DateTime) reader.GetDateTime(0);
                    this.maxDate = (DateTime) reader.GetDateTime(1);
                }
            }

            this.dateReportsStartDate.MinDate = this.minDate;
            this.dateReportsStartDate.MaxDate = this.maxDate;
            this.dateReportsEndDate.MinDate = this.minDate;
            this.dateReportsEndDate.MaxDate = this.maxDate;
            this.cmbReportsFormat.SelectedIndex = 0;
        }

        private void StartDateChange(object sender, EventArgs e)
        {
            this.dateReportsEndDate.MinDate = this.dateReportsStartDate.Value;
        }
        private void EndDateChange(object sender, EventArgs e)
        {
            this.dateReportsStartDate.MaxDate = this.dateReportsEndDate.Value;
        }

        private void GetData(object sender, EventArgs e)
        {
            string query = String.Format(@"SELECT
                                        DATEADD(HOUR, FLOOR(DATEPART(HOUR, _Timestamp) / {3}) * {3}, CAST(CAST(_Timestamp AS DATE) AS DATETIME)) AS Timestamp,
                                        MAX(_Value) AS Value
                                    FROM 
                                        EMS2023.dbo.Table_140
                                    WHERE 
                                        _Name = '{0}'
                                        AND _Timestamp BETWEEN '{1} 00:00:00' AND '{2} 23:59:59'
                                    GROUP BY 
                                        _Name,
                                        DATEADD(HOUR, FLOOR(DATEPART(HOUR, _Timestamp) / {3}) * {3}, CAST(CAST(_Timestamp AS DATE) AS DATETIME))
                                    ORDER BY
                                        Timestamp;",
                              this.tableTag,
                              this.dateReportsStartDate.Value.ToString("yyyy-MM-dd"),
                              this.dateReportsEndDate.Value.ToString("yyyy-MM-dd"),
                              Regex.Match(this.cmbReportsFormat.SelectedItem.ToString(), @"\d+").Value);

            SqlCommand cmd = new SqlCommand(query, this.conn);
            Console.WriteLine(cmd.CommandText);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                this.dataReportTable.Rows.Clear();
                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    this.dataReportTable.Rows.Add(row);
                    //Console.WriteLine(reader.GetString("id"));
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

        // Print controls here
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.dataReportTable.RowCount <= 0)
            {
                string message = "Load some data from server.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resetPrintLoop();
                printPreviewReport.ShowDialog();
            }
        }

        private void PrintData(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int pageWidth = PrintDocumentReport.DefaultPageSettings.PaperSize.Width;
            int pageHeight = PrintDocumentReport.DefaultPageSettings.PaperSize.Height;
            Console.WriteLine("Print Loop");

            // Header
            String CompanyName = "The Times Press (Private) Limited";
            SizeF size = g.MeasureString(CompanyName.ToString(), FontTitle);
            e.Graphics.DrawString(CompanyName, FontTitle, Brushes.Black, (pageWidth - size.Width) / 2, 25);
            e.Graphics.DrawString("Machine: " + this.tableName, FontTableHeading, brush: Brushes.Black, new Point(30, 65));
            e.Graphics.DrawString("Print date: " + DateTime.Now.ToString("G"), FontBody, brush: Brushes.Black, new Point(600, 72));
            
            // Table heading
            e.Graphics.DrawString("Sr #", FontTableHeading, brush: Brushes.Black, new Point(30, 100));
            e.Graphics.DrawString("Timestamp", FontTableHeading, brush: Brushes.Black, new Point(150, 100));
            e.Graphics.DrawString("Values (kwh)", FontTableHeading, brush: Brushes.Black, new Point(470, 100));
            e.Graphics.DrawLine(pen: new Pen(color: Color.Black, 1), new Point(30, 130), new Point(810, 130));

            int rowNum = 1;
            for (int i = numberOfItemsPrintedSoFar; i < this.dataReportTable.RowCount; i++)
            {
                if (itemNum <= printableRows)
                {
                    if (numberOfItemsPrintedSoFar < this.dataReportTable.RowCount)
                    {
                        e.Graphics.DrawString((i + 1).ToString(), FontRowHeading, brush: Brushes.Black, new Point(30, 115 + (rowNum * tableRowsSpacing)));
                        e.Graphics.DrawString(this.dataReportTable.Rows[i].Cells["timestamp"].Value.ToString(), FontBody, brush: Brushes.Black, new Point(150, 115 + (rowNum * tableRowsSpacing)));
                        e.Graphics.DrawString(this.dataReportTable.Rows[i].Cells["value"].Value.ToString(), FontBody, brush: Brushes.Black, new Point(470, 115 + (rowNum * tableRowsSpacing)));
                        rowNum++;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }else
                {
                    rowNum = 1;
                    itemNum = 0;
                    e.HasMorePages = true;
                    break;
                }

                numberOfItemsPrintedSoFar++;
                itemNum++;
            }

            // Print Page Number
            String pageNumber = "Page: " + ((pageNum).ToString());
            SizeF pageNumberSize = g.MeasureString(pageNumber.ToString(), FontBody);
            e.Graphics.DrawString(pageNumber, FontRowHeading, brush: Brushes.Black, pageWidth - pageNumberSize.Width - 10, pageHeight - pageNumberSize.Height - 10);
            pageNum++;
            Console.WriteLine("Current page number: " + pageNum);

            // Reset loop at the end of printing
            if (numberOfItemsPrintedSoFar >= this.dataReportTable.RowCount)
            {
                resetPrintLoop();
            }
        }

        private void resetPrintLoop()
        {
            Console.WriteLine("Reset Loop");
            pageNum = 1;
            itemNum = 0;
            numberOfItemsPrintedSoFar = 0;
        }
    }
}
