namespace Gymnasium_APP.BackCardFrom
{
    partial class BackCardDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackCardDialog));
            this.btn_AllExtension = new System.Windows.Forms.Button();
            this.btn_Extension = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdUpload = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AllExtension
            // 
            this.btn_AllExtension.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_AllExtension.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_AllExtension.Location = new System.Drawing.Point(380, 109);
            this.btn_AllExtension.Name = "btn_AllExtension";
            this.btn_AllExtension.Size = new System.Drawing.Size(146, 43);
            this.btn_AllExtension.TabIndex = 16;
            this.btn_AllExtension.Text = "无卡退卡";
            this.btn_AllExtension.UseVisualStyleBackColor = true;
            this.btn_AllExtension.Click += new System.EventHandler(this.btn_AllExtension_Click);
            // 
            // btn_Extension
            // 
            this.btn_Extension.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Extension.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_Extension.Location = new System.Drawing.Point(187, 109);
            this.btn_Extension.Name = "btn_Extension";
            this.btn_Extension.Size = new System.Drawing.Size(146, 43);
            this.btn_Extension.TabIndex = 15;
            this.btn_Extension.Text = "有卡退卡";
            this.btn_Extension.UseVisualStyleBackColor = true;
            this.btn_Extension.Click += new System.EventHandler(this.btn_Extension_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22F);
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "退卡";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BackCardDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 162);
            this.Controls.Add(this.btn_AllExtension);
            this.Controls.Add(this.btn_Extension);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(690, 200);
            this.Name = "BackCardDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退卡";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AllExtension;
        private System.Windows.Forms.Button btn_Extension;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.OpenFileDialog ofdUpload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}