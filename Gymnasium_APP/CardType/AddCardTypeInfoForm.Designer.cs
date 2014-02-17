namespace Gymnasium_APP.CardType
{
    partial class AddCardTypeInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCardTypeInfoForm));
            this.btn_Abolish = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txt_CardTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_TypeName = new System.Windows.Forms.ComboBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Months = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DayPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_CardCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Abolish
            // 
            this.btn_Abolish.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Abolish.Location = new System.Drawing.Point(214, 267);
            this.btn_Abolish.Name = "btn_Abolish";
            this.btn_Abolish.Size = new System.Drawing.Size(89, 43);
            this.btn_Abolish.TabIndex = 7;
            this.btn_Abolish.Text = "取消";
            this.btn_Abolish.UseVisualStyleBackColor = true;
            this.btn_Abolish.Click += new System.EventHandler(this.btn_Abolish_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_OK.Location = new System.Drawing.Point(100, 267);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(89, 43);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "确认";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_CardTypeName
            // 
            this.txt_CardTypeName.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_CardTypeName.Location = new System.Drawing.Point(111, 16);
            this.txt_CardTypeName.MaxLength = 20;
            this.txt_CardTypeName.Name = "txt_CardTypeName";
            this.txt_CardTypeName.Size = new System.Drawing.Size(189, 26);
            this.txt_CardTypeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "产品名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "产品类型";
            // 
            // cmb_TypeName
            // 
            this.cmb_TypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TypeName.Font = new System.Drawing.Font("宋体", 12F);
            this.cmb_TypeName.FormattingEnabled = true;
            this.cmb_TypeName.Items.AddRange(new object[] {
            "计时产品",
            "计次产品",
            "固定收费产品"});
            this.cmb_TypeName.Location = new System.Drawing.Point(113, 58);
            this.cmb_TypeName.Name = "cmb_TypeName";
            this.cmb_TypeName.Size = new System.Drawing.Size(189, 24);
            this.cmb_TypeName.TabIndex = 2;
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_Price.Location = new System.Drawing.Point(111, 97);
            this.txt_Price.MaxLength = 20;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(189, 26);
            this.txt_Price.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(33, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "产品价格";
            // 
            // txt_Months
            // 
            this.txt_Months.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_Months.Location = new System.Drawing.Point(111, 225);
            this.txt_Months.MaxLength = 20;
            this.txt_Months.Name = "txt_Months";
            this.txt_Months.Size = new System.Drawing.Size(189, 26);
            this.txt_Months.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(17, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "产品有效期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(298, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "月";
            // 
            // txt_DayPrice
            // 
            this.txt_DayPrice.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_DayPrice.Location = new System.Drawing.Point(111, 139);
            this.txt_DayPrice.MaxLength = 20;
            this.txt_DayPrice.Name = "txt_DayPrice";
            this.txt_DayPrice.Size = new System.Drawing.Size(189, 26);
            this.txt_DayPrice.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(33, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "单日价格";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_CardCount
            // 
            this.txt_CardCount.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_CardCount.Location = new System.Drawing.Point(111, 183);
            this.txt_CardCount.MaxLength = 20;
            this.txt_CardCount.Name = "txt_CardCount";
            this.txt_CardCount.Size = new System.Drawing.Size(189, 26);
            this.txt_CardCount.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(33, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "使用次数";
            // 
            // AddCardTypeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 322);
            this.Controls.Add(this.txt_CardCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_DayPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Months);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_TypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Abolish);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_CardTypeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 330);
            this.Name = "AddCardTypeInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消费型产品信息 — 添加";
            this.Activated += new System.EventHandler(this.AddCardTypeInfoForm_Activated);
            this.Load += new System.EventHandler(this.AddCardTypeInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abolish;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox txt_CardTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_TypeName;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Months;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DayPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_CardCount;
        private System.Windows.Forms.Label label7;
    }
}