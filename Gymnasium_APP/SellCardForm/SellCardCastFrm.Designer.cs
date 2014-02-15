namespace Gymnasium_APP.SellCardForm
{
    partial class SellCardCastFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellCardCastFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartTypeTxt = new System.Windows.Forms.TextBox();
            this.changeAmountTxt = new System.Windows.Forms.TextBox();
            this.paymentAmountTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceAmountTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.leftCountTxt = new System.Windows.Forms.TextBox();
            this.endTimeTp = new System.Windows.Forms.DateTimePicker();
            this.startTimeTp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Abolish = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(317, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "交费";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cartTypeTxt);
            this.panel1.Controls.Add(this.changeAmountTxt);
            this.panel1.Controls.Add(this.paymentAmountTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.priceAmountTxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.leftCountTxt);
            this.panel1.Controls.Add(this.endTimeTp);
            this.panel1.Controls.Add(this.startTimeTp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 199);
            this.panel1.TabIndex = 1;
            // 
            // cartTypeTxt
            // 
            this.cartTypeTxt.Enabled = false;
            this.cartTypeTxt.Font = new System.Drawing.Font("宋体", 12F);
            this.cartTypeTxt.Location = new System.Drawing.Point(116, 18);
            this.cartTypeTxt.Name = "cartTypeTxt";
            this.cartTypeTxt.Size = new System.Drawing.Size(189, 26);
            this.cartTypeTxt.TabIndex = 14;
            // 
            // changeAmountTxt
            // 
            this.changeAmountTxt.Enabled = false;
            this.changeAmountTxt.Font = new System.Drawing.Font("宋体", 12F);
            this.changeAmountTxt.Location = new System.Drawing.Point(425, 102);
            this.changeAmountTxt.Name = "changeAmountTxt";
            this.changeAmountTxt.Size = new System.Drawing.Size(189, 26);
            this.changeAmountTxt.TabIndex = 13;
            // 
            // paymentAmountTxt
            // 
            this.paymentAmountTxt.Font = new System.Drawing.Font("宋体", 12F);
            this.paymentAmountTxt.Location = new System.Drawing.Point(425, 60);
            this.paymentAmountTxt.Name = "paymentAmountTxt";
            this.paymentAmountTxt.Size = new System.Drawing.Size(189, 26);
            this.paymentAmountTxt.TabIndex = 12;
            this.paymentAmountTxt.TextChanged += new System.EventHandler(this.paymentAmountTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(353, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "找零金额";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(353, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "交费金额";
            // 
            // priceAmountTxt
            // 
            this.priceAmountTxt.Enabled = false;
            this.priceAmountTxt.Font = new System.Drawing.Font("宋体", 12F);
            this.priceAmountTxt.Location = new System.Drawing.Point(425, 19);
            this.priceAmountTxt.Name = "priceAmountTxt";
            this.priceAmountTxt.Size = new System.Drawing.Size(189, 26);
            this.priceAmountTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(353, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "单价金额";
            // 
            // leftCountTxt
            // 
            this.leftCountTxt.Enabled = false;
            this.leftCountTxt.Font = new System.Drawing.Font("宋体", 12F);
            this.leftCountTxt.Location = new System.Drawing.Point(116, 143);
            this.leftCountTxt.Name = "leftCountTxt";
            this.leftCountTxt.Size = new System.Drawing.Size(189, 26);
            this.leftCountTxt.TabIndex = 7;
            // 
            // endTimeTp
            // 
            this.endTimeTp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endTimeTp.Enabled = false;
            this.endTimeTp.Font = new System.Drawing.Font("宋体", 12F);
            this.endTimeTp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimeTp.Location = new System.Drawing.Point(116, 101);
            this.endTimeTp.Name = "endTimeTp";
            this.endTimeTp.Size = new System.Drawing.Size(189, 26);
            this.endTimeTp.TabIndex = 6;
            // 
            // startTimeTp
            // 
            this.startTimeTp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startTimeTp.Enabled = false;
            this.startTimeTp.Font = new System.Drawing.Font("宋体", 12F);
            this.startTimeTp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeTp.Location = new System.Drawing.Point(116, 59);
            this.startTimeTp.Name = "startTimeTp";
            this.startTimeTp.Size = new System.Drawing.Size(189, 26);
            this.startTimeTp.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(40, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "剩余次数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(40, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "失效日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(40, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "生效日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(56, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "卡类别";
            // 
            // btn_Abolish
            // 
            this.btn_Abolish.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Abolish.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Abolish.Location = new System.Drawing.Point(391, 254);
            this.btn_Abolish.Name = "btn_Abolish";
            this.btn_Abolish.Size = new System.Drawing.Size(146, 43);
            this.btn_Abolish.TabIndex = 18;
            this.btn_Abolish.Text = "取消";
            this.btn_Abolish.UseVisualStyleBackColor = true;
            this.btn_Abolish.Click += new System.EventHandler(this.btn_Abolish_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_OK.Location = new System.Drawing.Point(164, 254);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(146, 43);
            this.btn_OK.TabIndex = 17;
            this.btn_OK.Text = "确认";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SellCardCastFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 306);
            this.Controls.Add(this.btn_Abolish);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(711, 344);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(711, 344);
            this.Name = "SellCardCastFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "交费";
            this.Load += new System.EventHandler(this.SellCardCastFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox changeAmountTxt;
        private System.Windows.Forms.TextBox paymentAmountTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceAmountTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox leftCountTxt;
        private System.Windows.Forms.DateTimePicker endTimeTp;
        private System.Windows.Forms.DateTimePicker startTimeTp;
        private System.Windows.Forms.TextBox cartTypeTxt;
        private System.Windows.Forms.Button btn_Abolish;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}