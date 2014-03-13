namespace Gymnasium_APP.UC
{
    partial class UC_Page
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_page = new System.Windows.Forms.ComboBox();
            this.lbl_My = new System.Windows.Forms.Label();
            this.lbl_Page = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.linkEnd = new System.Windows.Forms.LinkLabel();
            this.linkFirst = new System.Windows.Forms.LinkLabel();
            this.lbl_PageTotalCount = new System.Windows.Forms.Label();
            this.lbl_DataTotalCount = new System.Windows.Forms.Label();
            this.linkNext = new System.Windows.Forms.LinkLabel();
            this.linkBefore = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cmb_page
            // 
            this.cmb_page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_page.AutoCompleteCustomSource.AddRange(new string[] {
            "10",
            "20",
            "30"});
            this.cmb_page.Font = new System.Drawing.Font("宋体", 12F);
            this.cmb_page.FormattingEnabled = true;
            this.cmb_page.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40"});
            this.cmb_page.Location = new System.Drawing.Point(91, 0);
            this.cmb_page.Name = "cmb_page";
            this.cmb_page.Size = new System.Drawing.Size(50, 24);
            this.cmb_page.TabIndex = 183;
            this.cmb_page.Text = "15";
            this.cmb_page.SelectedIndexChanged += new System.EventHandler(this.cmb_page_SelectedIndexChanged);
            this.cmb_page.TextChanged += new System.EventHandler(this.cmb_page_TextChanged);
            // 
            // lbl_My
            // 
            this.lbl_My.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_My.AutoSize = true;
            this.lbl_My.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_My.Location = new System.Drawing.Point(5, 6);
            this.lbl_My.Name = "lbl_My";
            this.lbl_My.Size = new System.Drawing.Size(80, 16);
            this.lbl_My.TabIndex = 182;
            this.lbl_My.Text = "每页显示:";
            // 
            // lbl_Page
            // 
            this.lbl_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Page.AutoSize = true;
            this.lbl_Page.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_Page.Location = new System.Drawing.Point(343, 6);
            this.lbl_Page.Name = "lbl_Page";
            this.lbl_Page.Size = new System.Drawing.Size(16, 16);
            this.lbl_Page.TabIndex = 181;
            this.lbl_Page.Text = "0";
            // 
            // lbl_Count
            // 
            this.lbl_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_Count.Location = new System.Drawing.Point(233, 6);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(16, 16);
            this.lbl_Count.TabIndex = 180;
            this.lbl_Count.Text = "0";
            // 
            // linkEnd
            // 
            this.linkEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkEnd.AutoSize = true;
            this.linkEnd.Font = new System.Drawing.Font("宋体", 12F);
            this.linkEnd.Location = new System.Drawing.Point(548, 6);
            this.linkEnd.Name = "linkEnd";
            this.linkEnd.Size = new System.Drawing.Size(40, 16);
            this.linkEnd.TabIndex = 179;
            this.linkEnd.TabStop = true;
            this.linkEnd.Text = "尾页";
            this.linkEnd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEnd_LinkClicked);
            // 
            // linkFirst
            // 
            this.linkFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkFirst.AutoSize = true;
            this.linkFirst.Font = new System.Drawing.Font("宋体", 12F);
            this.linkFirst.Location = new System.Drawing.Point(389, 6);
            this.linkFirst.Name = "linkFirst";
            this.linkFirst.Size = new System.Drawing.Size(40, 16);
            this.linkFirst.TabIndex = 178;
            this.linkFirst.TabStop = true;
            this.linkFirst.Text = "首页";
            this.linkFirst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFirst_LinkClicked);
            // 
            // lbl_PageTotalCount
            // 
            this.lbl_PageTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PageTotalCount.AutoSize = true;
            this.lbl_PageTotalCount.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_PageTotalCount.Location = new System.Drawing.Point(280, 6);
            this.lbl_PageTotalCount.Name = "lbl_PageTotalCount";
            this.lbl_PageTotalCount.Size = new System.Drawing.Size(64, 16);
            this.lbl_PageTotalCount.TabIndex = 177;
            this.lbl_PageTotalCount.Text = "总页数:";
            // 
            // lbl_DataTotalCount
            // 
            this.lbl_DataTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DataTotalCount.AutoSize = true;
            this.lbl_DataTotalCount.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_DataTotalCount.Location = new System.Drawing.Point(147, 6);
            this.lbl_DataTotalCount.Name = "lbl_DataTotalCount";
            this.lbl_DataTotalCount.Size = new System.Drawing.Size(80, 16);
            this.lbl_DataTotalCount.TabIndex = 176;
            this.lbl_DataTotalCount.Text = "总记录数:";
            // 
            // linkNext
            // 
            this.linkNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkNext.AutoSize = true;
            this.linkNext.Font = new System.Drawing.Font("宋体", 12F);
            this.linkNext.Location = new System.Drawing.Point(493, 6);
            this.linkNext.Name = "linkNext";
            this.linkNext.Size = new System.Drawing.Size(56, 16);
            this.linkNext.TabIndex = 175;
            this.linkNext.TabStop = true;
            this.linkNext.Text = "下一页";
            this.linkNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNext_LinkClicked);
            // 
            // linkBefore
            // 
            this.linkBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkBefore.AutoSize = true;
            this.linkBefore.Font = new System.Drawing.Font("宋体", 12F);
            this.linkBefore.Location = new System.Drawing.Point(433, 6);
            this.linkBefore.Name = "linkBefore";
            this.linkBefore.Size = new System.Drawing.Size(56, 16);
            this.linkBefore.TabIndex = 174;
            this.linkBefore.TabStop = true;
            this.linkBefore.Text = "上一页";
            this.linkBefore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBefore_LinkClicked);
            // 
            // UC_Page
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cmb_page);
            this.Controls.Add(this.lbl_My);
            this.Controls.Add(this.lbl_Page);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.linkEnd);
            this.Controls.Add(this.linkFirst);
            this.Controls.Add(this.lbl_PageTotalCount);
            this.Controls.Add(this.lbl_DataTotalCount);
            this.Controls.Add(this.linkNext);
            this.Controls.Add(this.linkBefore);
            this.Name = "UC_Page";
            this.Size = new System.Drawing.Size(593, 24);
            this.Load += new System.EventHandler(this.UC_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_My;
        private System.Windows.Forms.Label lbl_PageTotalCount;
        private System.Windows.Forms.Label lbl_DataTotalCount;
        public System.Windows.Forms.LinkLabel linkBefore;
        public System.Windows.Forms.ComboBox cmb_page;
        public System.Windows.Forms.LinkLabel linkEnd;
        public System.Windows.Forms.LinkLabel linkFirst;
        public System.Windows.Forms.LinkLabel linkNext;
        public System.Windows.Forms.Label lbl_Page;
        public System.Windows.Forms.Label lbl_Count;
    }
}
