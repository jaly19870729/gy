namespace Gymnasium_APP.SwipeCardFrom
{
    partial class SwipeCardFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwipeCardFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_CardType = new System.Windows.Forms.ComboBox();
            this.txt_CardNumber = new System.Windows.Forms.TextBox();
            this.cmb_CunsumeType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_AddTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CunsumeCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_LeftCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Abolish = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdUpload = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CusNum = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22F);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "刷卡";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 345);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.txt_CusNum, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txt_UserName, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cmb_CardType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_CardNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_CunsumeType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtp_AddTime, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txt_LeftCount, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.dtp_EndTime, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_CunsumeCount, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(680, 343);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_UserName.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_UserName.Location = new System.Drawing.Point(105, 136);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(221, 29);
            this.txt_UserName.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 43);
            this.label3.TabIndex = 17;
            this.label3.Text = "姓名";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_CardType
            // 
            this.cmb_CardType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_CardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CardType.Font = new System.Drawing.Font("宋体", 14F);
            this.cmb_CardType.FormattingEnabled = true;
            this.cmb_CardType.Location = new System.Drawing.Point(105, 94);
            this.cmb_CardType.Name = "cmb_CardType";
            this.cmb_CardType.Size = new System.Drawing.Size(221, 27);
            this.cmb_CardType.TabIndex = 30;
            // 
            // txt_CardNumber
            // 
            this.txt_CardNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CardNumber.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_CardNumber.Location = new System.Drawing.Point(105, 50);
            this.txt_CardNumber.Name = "txt_CardNumber";
            this.txt_CardNumber.Size = new System.Drawing.Size(221, 29);
            this.txt_CardNumber.TabIndex = 29;
            this.txt_CardNumber.TextChanged += new System.EventHandler(this.txt_CardNumber_TextChanged);
            // 
            // cmb_CunsumeType
            // 
            this.cmb_CunsumeType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_CunsumeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CunsumeType.Font = new System.Drawing.Font("宋体", 14F);
            this.cmb_CunsumeType.FormattingEnabled = true;
            this.cmb_CunsumeType.Items.AddRange(new object[] {
            "会员卡刷卡",
            "现金消费"});
            this.cmb_CunsumeType.Location = new System.Drawing.Point(105, 8);
            this.cmb_CunsumeType.Name = "cmb_CunsumeType";
            this.cmb_CunsumeType.Size = new System.Drawing.Size(221, 27);
            this.cmb_CunsumeType.TabIndex = 28;
            this.cmb_CunsumeType.SelectedIndexChanged += new System.EventHandler(this.cmb_CunsumeType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "卡号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "消费类型";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(359, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel2.SetRowSpan(this.panel2, 6);
            this.panel2.Size = new System.Drawing.Size(306, 240);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_AddTime
            // 
            this.dtp_AddTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_AddTime.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_AddTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_AddTime.Enabled = false;
            this.dtp_AddTime.Font = new System.Drawing.Font("宋体", 13F);
            this.dtp_AddTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_AddTime.Location = new System.Drawing.Point(445, 266);
            this.dtp_AddTime.Name = "dtp_AddTime";
            this.dtp_AddTime.Size = new System.Drawing.Size(221, 27);
            this.dtp_AddTime.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14F);
            this.label7.Location = new System.Drawing.Point(343, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 43);
            this.label7.TabIndex = 10;
            this.label7.Text = "刷卡日期";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F);
            this.label5.Location = new System.Drawing.Point(3, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 42);
            this.label5.TabIndex = 6;
            this.label5.Text = "消费人数";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_CunsumeCount
            // 
            this.txt_CunsumeCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CunsumeCount.Enabled = false;
            this.txt_CunsumeCount.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_CunsumeCount.Location = new System.Drawing.Point(105, 307);
            this.txt_CunsumeCount.Name = "txt_CunsumeCount";
            this.txt_CunsumeCount.Size = new System.Drawing.Size(221, 29);
            this.txt_CunsumeCount.TabIndex = 33;
            this.txt_CunsumeCount.TextChanged += new System.EventHandler(this.txt_CunsumeCount_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14F);
            this.label11.Location = new System.Drawing.Point(3, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 43);
            this.label11.TabIndex = 18;
            this.label11.Text = "剩余次数";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_LeftCount
            // 
            this.txt_LeftCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_LeftCount.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_LeftCount.Location = new System.Drawing.Point(105, 222);
            this.txt_LeftCount.Name = "txt_LeftCount";
            this.txt_LeftCount.Size = new System.Drawing.Size(221, 29);
            this.txt_LeftCount.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14F);
            this.label8.Location = new System.Drawing.Point(3, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 43);
            this.label8.TabIndex = 12;
            this.label8.Text = "失效日期";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_EndTime
            // 
            this.dtp_EndTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_EndTime.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_EndTime.Enabled = false;
            this.dtp_EndTime.Font = new System.Drawing.Font("宋体", 13F);
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndTime.Location = new System.Drawing.Point(105, 180);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.Size = new System.Drawing.Size(221, 27);
            this.dtp_EndTime.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(3, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 43);
            this.label6.TabIndex = 8;
            this.label6.Text = "卡类别";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Abolish
            // 
            this.btn_Abolish.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Abolish.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Abolish.Location = new System.Drawing.Point(380, 396);
            this.btn_Abolish.Name = "btn_Abolish";
            this.btn_Abolish.Size = new System.Drawing.Size(146, 43);
            this.btn_Abolish.TabIndex = 16;
            this.btn_Abolish.Text = "出场";
            this.btn_Abolish.UseVisualStyleBackColor = true;
            this.btn_Abolish.Click += new System.EventHandler(this.btn_Abolish_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_OK.Location = new System.Drawing.Point(187, 396);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(146, 43);
            this.btn_OK.TabIndex = 15;
            this.btn_OK.Text = "进场";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14F);
            this.label9.Location = new System.Drawing.Point(3, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 43);
            this.label9.TabIndex = 36;
            this.label9.Text = "消费序号";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_CusNum
            // 
            this.txt_CusNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CusNum.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_CusNum.Location = new System.Drawing.Point(105, 265);
            this.txt_CusNum.Name = "txt_CusNum";
            this.txt_CusNum.Size = new System.Drawing.Size(221, 29);
            this.txt_CusNum.TabIndex = 37;
            this.txt_CusNum.TextChanged += new System.EventHandler(this.txt_CusNum_TextChanged);
            // 
            // SwipeCardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 449);
            this.Controls.Add(this.btn_Abolish);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(711, 407);
            this.Name = "SwipeCardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "刷卡";
            this.Load += new System.EventHandler(this.SwipeCardFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Abolish;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.OpenFileDialog ofdUpload;
        private System.Windows.Forms.ComboBox cmb_CunsumeType;
        private System.Windows.Forms.TextBox txt_CardNumber;
        private System.Windows.Forms.ComboBox cmb_CardType;
        private System.Windows.Forms.TextBox txt_LeftCount;
        private System.Windows.Forms.TextBox txt_CunsumeCount;
        private System.Windows.Forms.DateTimePicker dtp_EndTime;
        private System.Windows.Forms.DateTimePicker dtp_AddTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CusNum;
    }
}