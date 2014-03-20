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
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using System.Threading;

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
        private string GetImagePath()
        {
            string personImgPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)
                         + Path.DirectorySeparatorChar.ToString() + "ReportImg";
            if (!Directory.Exists(personImgPath))
            {
                Directory.CreateDirectory(personImgPath);
            }

            return personImgPath;
        }
        private void SavePic(Bitmap bitmapSource, string name)
        {
            string path = GetImagePath();
            string filepath = path + "\\"+name + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpeg";
            bitmapSource.Save(filepath, ImageFormat.Jpeg);
        }
        private void ReportsFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                new PictureForm(GetFromPicture.GetWindowCapture(this.webBrowser1.Handle)).Show();
            }
        }
        #region MemberInfo 会员统计
        private bool GetMemberReport()
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
                return false;
            }

            string url = reportPath + "\\ReportFrom\\Pie3D\\Pie3D.html";
            this.webBrowser1.Url = new System.Uri(url);
            Thread.Sleep(500);
            return true;
            
        }
        private void btn_Member_OK_Click(object sender, EventArgs e)
        {
            MemberTiaoJian = " 1=1";
            MemberTiaoJian += " and AddTime > '" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Member_StartTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "' and  AddTime<'" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Member_EndTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "'";

            if (GetMemberReport())
            {
                SavePic(GetFromPicture.GetWindowCapture(this.webBrowser1.Handle), "Member");
            }
        }
        #endregion MemberInfo

        #region 预订
        private string ReservationTiaoJian = " 1=1";
        private bool GetReservationReport()
        {

            //AddTime > '2014-02-10 11:53:14' and AddTime < '2014-02-21 11:53:14'
            //DataSet ds_Memberinfo = memberManager.GetMemberInfoQuery("select CardType,Count(*) as 'Sum' from MemberInfo where " + MemberTiaoJian + " Group by CardType ");
            DataSet ds_Memberinfo = memberManager.GetMemberInfoQuery("select TypeName,Count(*) as 'Sum',CASE WHEN RState='0' THEN '未完成' WHEN RState='1' THEN '已完成' WHEN RState='2' THEN '已撤单' end as RState,sum(CONVERT(decimal(18, 0),ReservationInfo.Money)) as 'Money' from ReservationInfo where " + ReservationTiaoJian + " group by TypeName,RState");
            if (ds_Memberinfo != null && ds_Memberinfo.Tables.Count > 0 && ds_Memberinfo.Tables[0].Rows.Count > 0)
            {
                string d = reportPath + "\\ReportFrom\\MSCombiDY2D\\char.xml";
                string Content = string.Empty;
                string Content2 = string.Empty;
                string Content3 = string.Empty;
                for (int i = 0; i < ds_Memberinfo.Tables[0].Rows.Count; i++)
                {
                    Content += "<category label=\"" + ds_Memberinfo.Tables[0].Rows[i]["TypeName"].ToString() + "_" + ds_Memberinfo.Tables[0].Rows[i]["RState"].ToString() + "\" />\r\n";
                    Content2 += "<set value=\"" + ds_Memberinfo.Tables[0].Rows[i]["Money"].ToString() + "\" />\r\n";
                    Content3 += " <set value=\"" + ds_Memberinfo.Tables[0].Rows[i]["Sum"].ToString() + "\" />\r\n";
                }
                string xmlContent = "<chart palette=\"2\" caption=\"预订信息\" subCaption=\"\" showValues=\"0\" divLineDecimalPrecision=\"1\" limitsDecimalPrecision=\"1\" PYAxisName=\"金额\" SYAxisName=\"单数\" numberPrefix=\"￥\" formatNumberScale=\"0\" baseFont=\"Arial\" baseFontSize=\"12\" rotateYAxisName='0'>\r\n";
                xmlContent += " <categories>\r\n" + Content + "  </categories>\r\n";
                xmlContent += "<dataset seriesName=\"收入\">\r\n" + Content2 + "</dataset>\r\n";
                xmlContent += "<dataset lineThickness=\"3\" seriesName=\"单数\" parentYAxis=\"S\">\r\n" + Content3 + "</dataset>\r\n";
                xmlContent += "</chart> \r\n";
                writelog(xmlContent, d);
            }
            else
            {
                MessageBox.Show("无法查询数据结果！");
                return false;
            }
            string url = reportPath + "\\ReportFrom\\MSCombiDY2D\\MSCombiDY2D.html";
            this.web_Reservation.Url = new System.Uri(url);
            Thread.Sleep(500);
            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ReservationTiaoJian = " 1=1";
            ReservationTiaoJian += " and AddTime > '" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Reservation_StartTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "' and  AddTime<'" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Reservation_StopTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "'";

            if (GetReservationReport())
            {
                SavePic(GetFromPicture.GetWindowCapture(this.web_Reservation.Handle), "Reservation");
            }
        }
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                GetReservationReport();
            }
        }
    }
}
