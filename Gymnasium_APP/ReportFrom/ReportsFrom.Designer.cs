namespace Gymnasium_APP.ReportFrom
{
    partial class ReportsFrom
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Member_OK = new System.Windows.Forms.Button();
            this.dtp_Member_EndTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_Member_StartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 524);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsFrom_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_Member_EndTime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtp_Member_StartTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Member_OK);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 66);
            this.panel1.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(4, 78);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(909, 414);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Member_OK
            // 
            this.btn_Member_OK.Font = new System.Drawing.Font("宋体", 14F);
            this.btn_Member_OK.Location = new System.Drawing.Point(792, 11);
            this.btn_Member_OK.Name = "btn_Member_OK";
            this.btn_Member_OK.Size = new System.Drawing.Size(105, 42);
            this.btn_Member_OK.TabIndex = 0;
            this.btn_Member_OK.Text = "确定";
            this.btn_Member_OK.UseVisualStyleBackColor = true;
            this.btn_Member_OK.Click += new System.EventHandler(this.btn_Member_OK_Click);
            // 
            // dtp_Member_EndTime
            // 
            this.dtp_Member_EndTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_Member_EndTime.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_Member_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_Member_EndTime.Font = new System.Drawing.Font("宋体", 13F);
            this.dtp_Member_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Member_EndTime.Location = new System.Drawing.Point(565, 23);
            this.dtp_Member_EndTime.Name = "dtp_Member_EndTime";
            this.dtp_Member_EndTime.Size = new System.Drawing.Size(221, 27);
            this.dtp_Member_EndTime.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14F);
            this.label8.Location = new System.Drawing.Point(474, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "结束时间";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_Member_StartTime
            // 
            this.dtp_Member_StartTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_Member_StartTime.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_Member_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_Member_StartTime.Font = new System.Drawing.Font("宋体", 13F);
            this.dtp_Member_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Member_StartTime.Location = new System.Drawing.Point(237, 23);
            this.dtp_Member_StartTime.Name = "dtp_Member_StartTime";
            this.dtp_Member_StartTime.Size = new System.Drawing.Size(221, 27);
            this.dtp_Member_StartTime.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(146, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "开始时间";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReportsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 525);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 563);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 563);
            this.Name = "ReportsFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsFrom";
            this.Load += new System.EventHandler(this.ReportsFrom_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsFrom_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Member_OK;
        private System.Windows.Forms.DateTimePicker dtp_Member_EndTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_Member_StartTime;
        private System.Windows.Forms.Label label3;
    }
}