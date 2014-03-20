using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.BLL;
using System.Xml;
using System.IO;

namespace Gymnasium_APP.ReportFrom
{
    public partial class ReportsFrom : Form
    {
        public ReportsFrom()
        {
            InitializeComponent();
        }
        //string reportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
        string reportPath = Application.StartupPath;
        MemberInfoManager memberManager = new MemberInfoManager();
        private string MemberTiaoJian = " 1=1";
        #region 写日志
        public static void writelog(string txt, string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    FileInfo fi = new FileInfo(path);
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.Write | FileShare.ReadWrite | FileShare.Read);
                    fs.SetLength(0);
                    StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));
                    sw.Write(txt);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            catch
            {
                return;
            }
        }
        #endregion 
        private void ReportsFrom_Load(object sender, EventArgs e)
        {
            this.dtp_Member_StartTime.MaxDate = DateTime.Now;
            this.dtp_Member_EndTime.MaxDate = this.dtp_Member_StartTime.Value.AddDays(1);
            GetMemberReport();
        }

        private void ReportsFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                new PictureForm(GetFromPicture.GetWindowCapture(this.webBrowser1.Handle)).Show();
            }
        }
        #region MemberInfo
        private void GetMemberReport()
        {
           
            //AddTime > '2014-02-10 11:53:14' and AddTime < '2014-02-21 11:53:14'
            DataSet ds_Memberinfo = memberManager.GetMemberInfoQuery("select CardType,Count(*) as 'Sum' from MemberInfo where " + MemberTiaoJian + " Group by CardType ");
            if (ds_Memberinfo != null && ds_Memberinfo.Tables.Count > 0 && ds_Memberinfo.Tables[0].Rows.Count > 0)
            {
                string d = reportPath + "\\ReportFrom\\Pie3D\\char.xml";
                string Content = string.Empty;
                for (int i = 0; i < ds_Memberinfo.Tables[0].Rows.Count; i++)
                {
                    Content += " <set label=\"" + ds_Memberinfo.Tables[0].Rows[i]["CardType"].ToString() + "\" value=\"" + ds_Memberinfo.Tables[0].Rows[i]["Sum"].ToString() + "\" /> \r\n";
                }
                string xmlContent = "<chart palette=\"4\" decimals=\"0\" enableSmartLabels=\"1\" enableRotation=\"0\" bgColor=\"99CCFF,FFFFFF\" bgAlpha=\"40,100\" bgRatio=\"0,100\" bgAngle=\"360\" showBorder=\"1\" startingAngle=\"70\" baseFont=\"Arial\" baseFontSize=\"12\" caption=\"会员人数统计\" xAxisName=\"会员信息\" showFCMenuItem=\"0\"> \r\n";
                xmlContent += Content;
                xmlContent += "</chart> \r\n";
                writelog(xmlContent, d);
            }
            else
            {
                MessageBox.Show("无法查询数据结果！");
                return;
            }

            string url = reportPath + "\\ReportFrom\\Pie3D\\Pie3D.html";
            this.webBrowser1.Url = new System.Uri(url);
        }
        private void btn_Member_OK_Click(object sender, EventArgs e)
        {
            MemberTiaoJian = " 1=1";
            MemberTiaoJian += " and AddTime > '" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Member_StartTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "' and  AddTime<'" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Member_EndTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "'";

            GetMemberReport();
        }
        #endregion MemberInfo
    }
}
