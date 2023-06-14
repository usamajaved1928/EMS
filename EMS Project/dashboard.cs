using System;
using System.Threading;
using System.Windows.Forms;

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
            th = new Thread(() => { openReports(tableName); });
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
