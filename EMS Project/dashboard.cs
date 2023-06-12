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

namespace EMS_Project
{
    public partial class mainScreen : Form
    {
        Thread th;
        public mainScreen()
        {
            InitializeComponent();
        }


        private void report_window(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string tableName = (string)button.Tag;
            th = new Thread(()=> { openReports(tableName); });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void openReports(string tableName)
        {
            Reports reportForm = new Reports();
            reportForm.tableName = tableName;
            Application.Run(reportForm);
        }
    }
}
