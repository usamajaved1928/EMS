
namespace EMS_Project
{
    partial class mainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            this.title = new System.Windows.Forms.Label();
            this.BtnDashKbaIRAC = new System.Windows.Forms.Button();
            this.btnDashKbaMachine = new System.Windows.Forms.Button();
            this.btnDashKomoriL528 = new System.Windows.Forms.Button();
            this.btnDashSM102 = new System.Windows.Forms.Button();
            this.btnDashPaperBag = new System.Windows.Forms.Button();
            this.btnDashKomoriL528AC = new System.Windows.Forms.Button();
            this.btnDashSM1028AC = new System.Windows.Forms.Button();
            this.btnDashSM1028 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.RoyalBlue;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Arial", 16F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 44);
            this.title.TabIndex = 1;
            this.title.Text = "EMS Dashboard";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDashKbaIRAC
            // 
            this.BtnDashKbaIRAC.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnDashKbaIRAC.Location = new System.Drawing.Point(12, 47);
            this.BtnDashKbaIRAC.Name = "BtnDashKbaIRAC";
            this.BtnDashKbaIRAC.Size = new System.Drawing.Size(151, 34);
            this.BtnDashKbaIRAC.TabIndex = 0;
            this.BtnDashKbaIRAC.Tag = "EMSV1.1.REAL_ENERGY_S_1";
            this.BtnDashKbaIRAC.Text = "SM 102.10";
            this.BtnDashKbaIRAC.UseVisualStyleBackColor = true;
            this.BtnDashKbaIRAC.Click += new System.EventHandler(this.report_window);
            // 
            // btnDashKbaMachine
            // 
            this.btnDashKbaMachine.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDashKbaMachine.Location = new System.Drawing.Point(12, 87);
            this.btnDashKbaMachine.Name = "btnDashKbaMachine";
            this.btnDashKbaMachine.Size = new System.Drawing.Size(151, 34);
            this.btnDashKbaMachine.TabIndex = 1;
            this.btnDashKbaMachine.Tag = "EMSV1.2.REAL_ENERGY_S_1";
            this.btnDashKbaMachine.Text = "Envelope";
            this.btnDashKbaMachine.UseVisualStyleBackColor = true;
            this.btnDashKbaMachine.Click += new System.EventHandler(this.report_window);
            // 
            // btnDashKomoriL528
            // 
            this.btnDashKomoriL528.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDashKomoriL528.Location = new System.Drawing.Point(12, 127);
            this.btnDashKomoriL528.Name = "btnDashKomoriL528";
            this.btnDashKomoriL528.Size = new System.Drawing.Size(151, 34);
            this.btnDashKomoriL528.TabIndex = 2;
            this.btnDashKomoriL528.Tag = "EMSV1.3.REAL_ENERGY_S_1";
            this.btnDashKomoriL528.Text = "Paper Bag";
            this.btnDashKomoriL528.UseVisualStyleBackColor = true;
            this.btnDashKomoriL528.Click += new System.EventHandler(this.report_window);
            // 
            // btnDashSM102
            // 
            this.btnDashSM102.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDashSM102.Location = new System.Drawing.Point(12, 247);
            this.btnDashSM102.Name = "btnDashSM102";
            this.btnDashSM102.Size = new System.Drawing.Size(151, 34);
            this.btnDashSM102.TabIndex = 5;
            this.btnDashSM102.Tag = "EMSV1.6.REAL_ENERGY_S_1";
            this.btnDashSM102.Text = "SM 102.8";
            this.btnDashSM102.UseVisualStyleBackColor = true;
            this.btnDashSM102.Click += new System.EventHandler(this.report_window);
            // 
            // btnDashPaperBag
            // 
            this.btnDashPaperBag.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDashPaperBag.Location = new System.Drawing.Point(12, 207);
            this.btnDashPaperBag.Name = "btnDashPaperBag";
            this.btnDashPaperBag.Size = new System.Drawing.Size(151, 34);
            this.btnDashPaperBag.TabIndex = 4;
            this.btnDashPaperBag.Tag = "EMSV1.5.REAL_ENERGY_S_1";
            this.btnDashPaperBag.Text = "KBA IR AC";
            this.btnDashPaperBag.UseVisualStyleBackColor = true;
            this.btnDashPaperBag.Click += new System.EventHandler(this.report_window);
            // 
            // btnDashKomoriL528AC
            // 
            this.btnDashKomoriL528AC.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDashKomoriL528AC.Location = new System.Drawing.Point(12, 167);
            this.btnDashKomoriL528AC.Name = "btnDashKomoriL528AC";
            this.btnDashKomoriL528AC.Size = new System.Drawing.Size(151, 34);
            this.btnDashKomoriL528AC.TabIndex = 3;
            this.btnDashKomoriL528AC.Tag = "EMSV1.4.REAL_ENERGY_S_1";
            this.btnDashKomoriL528AC.Text = "KBA Machine";
            this.btnDashKomoriL528AC.UseVisualStyleBackColor = true;
            this.btnDashKomoriL528AC.Click += new System.EventHandler(this.report_window);
            // 
            // btnDashSM1028AC
            // 
            this.btnDashSM1028AC.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDashSM1028AC.Location = new System.Drawing.Point(12, 327);
            this.btnDashSM1028AC.Name = "btnDashSM1028AC";
            this.btnDashSM1028AC.Size = new System.Drawing.Size(151, 34);
            this.btnDashSM1028AC.TabIndex = 7;
            this.btnDashSM1028AC.Tag = "EMSV1.8.REAL_ENERGY_S_1";
            this.btnDashSM1028AC.Text = "KOMORI L528";
            this.btnDashSM1028AC.UseVisualStyleBackColor = true;
            this.btnDashSM1028AC.Click += new System.EventHandler(this.report_window);
            // 
            // btnDashSM1028
            // 
            this.btnDashSM1028.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDashSM1028.Location = new System.Drawing.Point(12, 287);
            this.btnDashSM1028.Name = "btnDashSM1028";
            this.btnDashSM1028.Size = new System.Drawing.Size(151, 34);
            this.btnDashSM1028.TabIndex = 6;
            this.btnDashSM1028.Tag = "EMSV1.7.REAL_ENERGY_S_1";
            this.btnDashSM1028.Text = "SM 102.8 AC";
            this.btnDashSM1028.UseVisualStyleBackColor = true;
            this.btnDashSM1028.Click += new System.EventHandler(this.report_window);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F);
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 34);
            this.button1.TabIndex = 8;
            this.button1.Tag = "EMSV1.9.REAL_ENERGY_S_1";
            this.button1.Text = "KOMORI L528 AC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.report_window);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDashSM1028AC);
            this.Controls.Add(this.btnDashSM1028);
            this.Controls.Add(this.btnDashSM102);
            this.Controls.Add(this.btnDashPaperBag);
            this.Controls.Add(this.btnDashKomoriL528AC);
            this.Controls.Add(this.btnDashKomoriL528);
            this.Controls.Add(this.btnDashKbaMachine);
            this.Controls.Add(this.BtnDashKbaIRAC);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainScreen";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button BtnDashKbaIRAC;
        private System.Windows.Forms.Button btnDashKbaMachine;
        private System.Windows.Forms.Button btnDashKomoriL528;
        private System.Windows.Forms.Button btnDashSM102;
        private System.Windows.Forms.Button btnDashPaperBag;
        private System.Windows.Forms.Button btnDashKomoriL528AC;
        private System.Windows.Forms.Button btnDashSM1028AC;
        private System.Windows.Forms.Button btnDashSM1028;
        private System.Windows.Forms.Button button1;
    }
}

