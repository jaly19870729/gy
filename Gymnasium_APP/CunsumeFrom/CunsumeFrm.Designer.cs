﻿namespace Gymnasium_APP.CunsumeFrom
{
    partial class CunsumeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CunsumeFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_CunsumeCount = new System.Windows.Forms.TextBox();
            this.cmb_CunsumeType = new System.Windows.Forms.ComboBox();
            this.txt_ChangeAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_AddTime = new System.Windows.Forms.DateTimePicker();
            this.txt_PaymentAmount = new System.Windows.Forms.TextBox();
            this.txt_PayableAmount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_PriceAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CardNumber = new System.Windows.Forms.TextBox();
            this.btn_Abolish = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdUpload = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "单次消费";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 212);
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
            this.tableLayoutPanel2.Controls.Add(this.txt_CunsumeCount, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmb_CunsumeType, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_ChangeAmount, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtp_AddTime, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_PaymentAmount, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_PayableAmount, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label18, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_PriceAmount, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label17, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_CardNumber, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(680, 204);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txt_CunsumeCount
            // 
            this.txt_CunsumeCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CunsumeCount.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_CunsumeCount.Location = new System.Drawing.Point(105, 113);
            this.txt_CunsumeCount.Name = "txt_CunsumeCount";
            this.txt_CunsumeCount.Size = new System.Drawing.Size(221, 29);
            this.txt_CunsumeCount.TabIndex = 40;
            this.txt_CunsumeCount.TextChanged += new System.EventHandler(this.txt_CunsumeCount_TextChanged);
            // 
            // cmb_CunsumeType
            // 
            this.cmb_CunsumeType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_CunsumeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CunsumeType.Font = new System.Drawing.Font("宋体", 14F);
            this.cmb_CunsumeType.FormattingEnabled = true;
            this.cmb_CunsumeType.Items.AddRange(new object[] {
            "健身房"});
            this.cmb_CunsumeType.Location = new System.Drawing.Point(445, 12);
            this.cmb_CunsumeType.Name = "cmb_CunsumeType";
            this.cmb_CunsumeType.Size = new System.Drawing.Size(221, 27);
            this.cmb_CunsumeType.TabIndex = 39;
            this.cmb_CunsumeType.SelectedIndexChanged += new System.EventHandler(this.cmb_CunsumeType_SelectedIndexChanged);
            // 
            // txt_ChangeAmount
            // 
            this.txt_ChangeAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ChangeAmount.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_ChangeAmount.Location = new System.Drawing.Point(445, 164);
            this.txt_ChangeAmount.Name = "txt_ChangeAmount";
            this.txt_ChangeAmount.Size = new System.Drawing.Size(221, 29);
            this.txt_ChangeAmount.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(343, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 51);
            this.label3.TabIndex = 37;
            this.label3.Text = "找零金额";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_AddTime
            // 
            this.dtp_AddTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_AddTime.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_AddTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_AddTime.Font = new System.Drawing.Font("宋体", 13F);
            this.dtp_AddTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_AddTime.Location = new System.Drawing.Point(105, 63);
            this.dtp_AddTime.Name = "dtp_AddTime";
            this.dtp_AddTime.Size = new System.Drawing.Size(221, 27);
            this.dtp_AddTime.TabIndex = 35;
            // 
            // txt_PaymentAmount
            // 
            this.txt_PaymentAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_PaymentAmount.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_PaymentAmount.Location = new System.Drawing.Point(105, 164);
            this.txt_PaymentAmount.Name = "txt_PaymentAmount";
            this.txt_PaymentAmount.Size = new System.Drawing.Size(221, 29);
            this.txt_PaymentAmount.TabIndex = 34;
            this.txt_PaymentAmount.TextChanged += new System.EventHandler(this.txt_PaymentAmount_TextChanged);
            // 
            // txt_PayableAmount
            // 
            this.txt_PayableAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_PayableAmount.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_PayableAmount.Location = new System.Drawing.Point(445, 113);
            this.txt_PayableAmount.Name = "txt_PayableAmount";
            this.txt_PayableAmount.Size = new System.Drawing.Size(221, 29);
            this.txt_PayableAmount.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 14F);
            this.label18.Location = new System.Drawing.Point(343, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 51);
            this.label18.TabIndex = 31;
            this.label18.Text = "应付金额";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_PriceAmount
            // 
            this.txt_PriceAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_PriceAmount.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_PriceAmount.Location = new System.Drawing.Point(445, 62);
            this.txt_PriceAmount.Name = "txt_PriceAmount";
            this.txt_PriceAmount.Size = new System.Drawing.Size(221, 29);
            this.txt_PriceAmount.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 14F);
            this.label17.Location = new System.Drawing.Point(343, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 51);
            this.label17.TabIndex = 29;
            this.label17.Text = "单价金额";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 14F);
            this.label16.Location = new System.Drawing.Point(343, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 51);
            this.label16.TabIndex = 27;
            this.label16.Text = "消费类别";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14F);
            this.label8.Location = new System.Drawing.Point(3, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 51);
            this.label8.TabIndex = 12;
            this.label8.Text = "交费金额";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 51);
            this.label6.TabIndex = 8;
            this.label6.Text = "消费人数";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(3, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 51);
            this.label4.TabIndex = 4;
            this.label4.Text = "办理日期";
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
            this.label2.Size = new System.Drawing.Size(96, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = "卡号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_CardNumber
            // 
            this.txt_CardNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CardNumber.Font = new System.Drawing.Font("宋体", 14F);
            this.txt_CardNumber.Location = new System.Drawing.Point(105, 11);
            this.txt_CardNumber.Name = "txt_CardNumber";
            this.txt_CardNumber.Size = new System.Drawing.Size(221, 29);
            this.txt_CardNumber.TabIndex = 1;
            this.txt_CardNumber.TextChanged += new System.EventHandler(this.txt_CardNumber_TextChanged);
            // 
            // btn_Abolish
            // 
            this.btn_Abolish.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Abolish.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Abolish.Location = new System.Drawing.Point(380, 276);
            this.btn_Abolish.Name = "btn_Abolish";
            this.btn_Abolish.Size = new System.Drawing.Size(146, 43);
            this.btn_Abolish.TabIndex = 16;
            this.btn_Abolish.Text = "取消";
            this.btn_Abolish.UseVisualStyleBackColor = true;
            this.btn_Abolish.Click += new System.EventHandler(this.btn_Abolish_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_OK.Location = new System.Drawing.Point(187, 276);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(146, 43);
            this.btn_OK.TabIndex = 15;
            this.btn_OK.Text = "确认";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CunsumeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 331);
            this.Controls.Add(this.btn_Abolish);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(711, 500);
            this.MinimizeBox = false;
            this.Name = "CunsumeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单次消费";
            this.Load += new System.EventHandler(this.CunsumeFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CardNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Abolish;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.OpenFileDialog ofdUpload;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_PriceAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_PayableAmount;
        private System.Windows.Forms.TextBox txt_PaymentAmount;
        private System.Windows.Forms.DateTimePicker dtp_AddTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ChangeAmount;
        private System.Windows.Forms.ComboBox cmb_CunsumeType;
        private System.Windows.Forms.TextBox txt_CunsumeCount;
    }
}