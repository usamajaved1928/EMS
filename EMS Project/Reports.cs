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
    public partial class Reports : Form
    {
        Thread th;
        public string tableName { get; set; }
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.title.Text = $"{tableName} Report";
        }

        private void getData(object sender, EventArgs e)
        {
            
        }

        private void btnReportsClose_Click(object sender, EventArgs e)
        {
            th = new Thread(() => { Application.Run(new mainScreen()); });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
    }
}
