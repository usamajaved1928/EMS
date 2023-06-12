
namespace EMS_Project
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReportsClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateReportsStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbReportsFormat = new System.Windows.Forms.ComboBox();
            this.btnReportsFindData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportsClose
            // 
            this.btnReportsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportsClose.Font = new System.Drawing.Font("Arial", 12F);
            this.btnReportsClose.Location = new System.Drawing.Point(686, 410);
            this.btnReportsClose.Name = "btnReportsClose";
            this.btnReportsClose.Size = new System.Drawing.Size(99, 28);
            this.btnReportsClose.TabIndex = 0;
            this.btnReportsClose.Text = "Close";
            this.btnReportsClose.UseVisualStyleBackColor = true;
            this.btnReportsClose.Click += new System.EventHandler(this.btnReportsClose_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Arial", 12F);
            this.button2.Location = new System.Drawing.Point(581, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.RoyalBlue;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Arial", 16F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(797, 44);
            this.title.TabIndex = 2;
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataReport
            // 
            this.dataReport.AllowUserToAddRows = false;
            this.dataReport.AllowUserToDeleteRows = false;
            this.dataReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataReport.Location = new System.Drawing.Point(0, 44);
            this.dataReport.Name = "dataReport";
            this.dataReport.ReadOnly = true;
            this.dataReport.Size = new System.Drawing.Size(543, 406);
            this.dataReport.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(117, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReportsFindData);
            this.panel1.Controls.Add(this.cmbReportsFormat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dateReportsStartDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(542, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 406);
            this.panel1.TabIndex = 5;
            // 
            // dateReportsStartDate
            // 
            this.dateReportsStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateReportsStartDate.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.dateReportsStartDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dateReportsStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReportsStartDate.Location = new System.Drawing.Point(144, 39);
            this.dateReportsStartDate.Name = "dateReportsStartDate";
            this.dateReportsStartDate.Size = new System.Drawing.Size(104, 26);
            this.dateReportsStartDate.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Format";
            // 
            // cmbReportsFormat
            // 
            this.cmbReportsFormat.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbReportsFormat.FormattingEnabled = true;
            this.cmbReportsFormat.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hours",
            "3 Hours",
            "6 Hours",
            "12 Hours",
            "24 Hours"});
            this.cmbReportsFormat.Location = new System.Drawing.Point(7, 107);
            this.cmbReportsFormat.Name = "cmbReportsFormat";
            this.cmbReportsFormat.Size = new System.Drawing.Size(241, 26);
            this.cmbReportsFormat.TabIndex = 9;
            // 
            // btnReportsFindData
            // 
            this.btnReportsFindData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportsFindData.Font = new System.Drawing.Font("Arial", 12F);
            this.btnReportsFindData.Location = new System.Drawing.Point(7, 152);
            this.btnReportsFindData.Name = "btnReportsFindData";
            this.btnReportsFindData.Size = new System.Drawing.Size(241, 28);
            this.btnReportsFindData.TabIndex = 6;
            this.btnReportsFindData.Text = "Find Data";
            this.btnReportsFindData.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.btnReportsClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataReport);
            this.Controls.Add(this.title);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportsClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateReportsStartDate;
        private System.Windows.Forms.ComboBox cmbReportsFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReportsFindData;
    }
}