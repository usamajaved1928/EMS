using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SQLite;
using System.Configuration;

namespace EMS_Project
{
    public partial class Reports : Form
    {
        Thread th;
        SQLiteConnection conn;
        public string tableName { get; set; }
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.title.Text = $"{tableName} Report";
            OpenConnection();
        }

        private void MinMax_Date()
        {
            string query = "";
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db")){

            }
        }

        private void getData(object sender, EventArgs e)
        {
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(query, this.conn);
        }

        private void btnReportsClose_Click(object sender, EventArgs e)
        {
            th = new Thread(() => { Application.Run(new mainScreen()); });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.conn.Close();
            this.Close();
        }

        // Database functions starts from here
        private void OpenConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;
            this.conn = new SQLiteConnection(connectionString);
            this.conn.Open();
        }
    }
}
