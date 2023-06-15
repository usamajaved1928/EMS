
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.btnReportsClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportsFindData = new System.Windows.Forms.Button();
            this.cmbReportsFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateReportsStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateReportsEndDate = new System.Windows.Forms.DateTimePicker();
            this.dataReportTable = new System.Windows.Forms.DataGridView();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintDocumentReport = new System.Drawing.Printing.PrintDocument();
            this.printPreviewReport = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportTable)).BeginInit();
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
            this.button2.Click += new System.EventHandler(this.btnPrint_Click);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel1.Controls.Add(this.dateReportsStartDate);
            this.panel1.Controls.Add(this.dateReportsEndDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(542, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 406);
            this.panel1.TabIndex = 5;
            // 
            // btnReportsFindData
            // 
            this.btnReportsFindData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportsFindData.Font = new System.Drawing.Font("Arial", 12F);
            this.btnReportsFindData.Location = new System.Drawing.Point(7, 152);
            this.btnReportsFindData.Name = "btnReportsFindData";
            this.btnReportsFindData.Size = new System.Drawing.Size(241, 28);
            this.btnReportsFindData.TabIndex = 3;
            this.btnReportsFindData.Text = "Find Data";
            this.btnReportsFindData.UseVisualStyleBackColor = true;
            this.btnReportsFindData.Click += new System.EventHandler(this.GetData);
            // 
            // cmbReportsFormat
            // 
            this.cmbReportsFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbReportsFormat.TabIndex = 2;
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
            // dateReportsStartDate
            // 
            this.dateReportsStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateReportsStartDate.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.dateReportsStartDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dateReportsStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReportsStartDate.Location = new System.Drawing.Point(7, 39);
            this.dateReportsStartDate.Name = "dateReportsStartDate";
            this.dateReportsStartDate.Size = new System.Drawing.Size(104, 26);
            this.dateReportsStartDate.TabIndex = 0;
            this.dateReportsStartDate.ValueChanged += new System.EventHandler(this.StartDateChange);
            // 
            // dateReportsEndDate
            // 
            this.dateReportsEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateReportsEndDate.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.dateReportsEndDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dateReportsEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReportsEndDate.Location = new System.Drawing.Point(144, 39);
            this.dateReportsEndDate.Name = "dateReportsEndDate";
            this.dateReportsEndDate.Size = new System.Drawing.Size(104, 26);
            this.dateReportsEndDate.TabIndex = 1;
            this.dateReportsEndDate.ValueChanged += new System.EventHandler(this.EndDateChange);
            // 
            // dataReportTable
            // 
            this.dataReportTable.AllowUserToAddRows = false;
            this.dataReportTable.AllowUserToDeleteRows = false;
            this.dataReportTable.AllowUserToResizeRows = false;
            this.dataReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataReportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestamp,
            this.name,
            this.value});
            this.dataReportTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataReportTable.Location = new System.Drawing.Point(0, 44);
            this.dataReportTable.MultiSelect = false;
            this.dataReportTable.Name = "dataReportTable";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataReportTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataReportTable.RowHeadersVisible = false;
            this.dataReportTable.RowHeadersWidth = 10;
            this.dataReportTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            this.dataReportTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataReportTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataReportTable.Size = new System.Drawing.Size(542, 406);
            this.dataReportTable.TabIndex = 6;
            // 
            // timestamp
            // 
            this.timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.timestamp.HeaderText = "Time Stamp";
            this.timestamp.Name = "timestamp";
            this.timestamp.ReadOnly = true;
            this.timestamp.Width = 170;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // PrintDocumentReport
            // 
            this.PrintDocumentReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintData);
            // 
            // printPreviewReport
            // 
            this.printPreviewReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewReport.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewReport.Document = this.PrintDocumentReport;
            this.printPreviewReport.Enabled = true;
            this.printPreviewReport.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewReport.Icon")));
            this.printPreviewReport.Name = "printPreviewReport";
            this.printPreviewReport.Visible = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.dataReportTable);
            this.Controls.Add(this.btnReportsClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportsClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateReportsStartDate;
        private System.Windows.Forms.DateTimePicker dateReportsEndDate;
        private System.Windows.Forms.ComboBox cmbReportsFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReportsFindData;
        private System.Windows.Forms.DataGridView dataReportTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Drawing.Printing.PrintDocument PrintDocumentReport;
        private System.Windows.Forms.PrintPreviewDialog printPreviewReport;
    }
}