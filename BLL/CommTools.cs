using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using Gymnasium_APP.Model;
using System.Threading;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Gymnasium_APP.BLL
{
    public class CommTools
    {
        #region 更新App.Config
        public static void UpdateAppConfig(string newKey, string newValue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }

            // Open App.Config of executable
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // You need to remove the old settings object before you can replace it
            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            // Add an Application Setting.
            config.AppSettings.Settings.Add(newKey, newValue);
            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }
        #endregion

        /// <summary>
        /// 将byte[]数组转换成Image
        /// </summary>
        /// <param name="btImage">byte[]</param>
        /// <returns>Image img</returns>
        public static Image ByteToImg(byte[] btImage)
        {
            MemoryStream memStream = new MemoryStream();
            //Stream memStream = null;
            memStream.Write(btImage, 0, btImage.Length);
            memStream.Position = 0;
            memStream.Seek(0, SeekOrigin.Begin);
            //Bitmap bmp = new Bitmap(memStream, true);
            Image img;
            try
            {
                img = Image.FromStream(memStream, true);
                memStream.Close();
                //img = new Bitmap(memStream);

            }
            catch (Exception ex)
            {
                img = null;
            }
            finally
            {
                //memStream.Close();
            }
            return img;
        }

        /// <summary>
        /// 图片转化为二进制
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <returns></returns>
        public static byte[] GetByteFromImage(PictureBox pictureBox)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Image);
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Jpeg);
            memoryStream.Seek(0, SeekOrigin.Begin);
            byte[] btImage = new byte[memoryStream.Length];
            memoryStream.Read(btImage, 0, btImage.Length);
            memoryStream.Close();
            return btImage;
        }

        public static string GetDateFormatStrot(DateTime date)
        {
            string year = date.Year.ToString();
            string month = date.Month.ToString();
            string day = date.Day.ToString();
            string hour = date.Hour.ToString();
            string min = date.Minute.ToString();
            string mm = date.Second.ToString();

            if (Convert.ToInt32(month) < 10)
            {

                month = "0" + month.Substring(month.LastIndexOf("0") + 1).ToLower(); ;
            }
            if (Convert.ToInt32(day) < 10)
            {
                day = "0" + day.Substring(day.LastIndexOf("0") + 1).ToLower(); ;
                //day = day;
            }
            if (Convert.ToInt32(hour) < 10)
            {
                hour = "0" + hour.Substring(hour.LastIndexOf("0") + 1).ToLower(); ;
                //day = day;
            }
            if (Convert.ToInt32(min) < 10)
            {
                min = "0" + min.Substring(min.LastIndexOf("0") + 1).ToLower(); ;
                //day = day;
            }
            if (Convert.ToInt32(mm) < 10)
            {
                mm = "0" + mm.Substring(mm.LastIndexOf("0") + 1).ToLower(); ;
                //day = day;
            }
            return year + "-" + month + "-" + day ;
        }
        public static string GetDateFormatStrot2(DateTime date)
        {
            string year = date.Year.ToString();
            string month = date.Month.ToString();
            string day = date.Day.ToString();
            string hour = date.Hour.ToString();
            string min = date.Minute.ToString();
            string mm = date.Second.ToString();

            if (Convert.ToInt32(month) < 10)
            {

                month = "0"+month.Substring(month.LastIndexOf("0") + 1).ToLower();
            }
            if (Convert.ToInt32(day) < 10)
            {
                day = "0" + day.Substring(day.LastIndexOf("0") + 1).ToLower();
                //day = day;
            }
            if (Convert.ToInt32(hour) < 10)
            {
                hour = "0" + hour.Substring(hour.LastIndexOf("0") + 1).ToLower();
                //day = day;
            }
            if (Convert.ToInt32(min) < 10)
            {
                min = "0" + min.Substring(min.LastIndexOf("0") + 1).ToLower();
                //day = day;
            }
            if (Convert.ToInt32(mm) < 10)
            {
                mm = "0" + mm.Substring(mm.LastIndexOf("0") + 1).ToLower();
                //day = day;
            }
            return year + "-" + month + "-" + day + " " + hour + ":" + min + ":" + mm;
        }

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="cb_"></param>
        public static void CheckBoxSelect(DataGridView dgv,CheckBox cb_)
        {
            if (cb_.Checked)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].Cells[0].Value = false;
                }
            }
        }

        #region 写入日志
        private static SystemLoginLogManager systemLoginLogManager = new SystemLoginLogManager();
        public static int UserID;
        public static void AddSystemLog(string type, string content)
        {
            SystemLoginLogModel systemLoginLogModel = new SystemLoginLogModel();
            systemLoginLogModel.LoginLogId = systemLoginLogManager.GetMaxId();
            systemLoginLogModel.LoginIP = "";
            systemLoginLogModel.LoginAddress = "";
            systemLoginLogModel.UserId = UserID;
            systemLoginLogModel.LoginType = type;
            systemLoginLogModel.LoginCont = content;
            systemLoginLogModel.LoginDate = CommTools.GetDateFormatStrot2(DateTime.Now);
            systemLoginLogManager.Add(systemLoginLogModel);
        }
        #endregion


        #region 进度条
        public static bool isRun = true;
        public static void RunBar(ProgressBar bar, int min, int max)
        {
            if (isRun)
            {
                for (int i = min; i < max; i++)
                {
                    bar.Value = i;
                    Thread.Sleep(50);
                }
            }
        }
        #endregion


        #region 打印机
        public static void InitprinterComboBox(ComboBox comboBox)
        {
            List<String> list = LocalPrinter.GetLocalPrinters(); //获得系统中的打印机列表
            foreach (String s in list)
            {
                comboBox.Items.Add(s); //将打印机名称添加到下拉框中
            }
            if (list.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }
        private int getYc(double cm)
        {

            return (int)(cm / 25.4) * 100;

        }
        public static string GetString(string str, int len)
        {
            string newStr = str;
            if (str.Length > len)
            {
                newStr = string.Empty;
                int s = str.Length % len;
                for (int i = 0; i < s; i++)
                {
                    str += " ";
                }
                for (int i = 0; i < str.Length; i++)
                {
                    if (i % len - 1 == 0 && i != 0 && str != "")
                    {
                        if (str.Trim().Length > 0)
                        {
                            newStr += str.Substring(0, len);
                            str = str.Substring(len, str.Length - 8);
                            i = 0;
                            if (str.Trim().Length > 0)
                            {
                                newStr += "\r\n";
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < len-str.Length; i++)
                {
                    str += " ";
                }
                newStr = str;
            }

            return newStr;
        }
        public static string GetPrintStr(string title, string numbers, string address, string phone, string printEnd, double total, double fukuan, string content, string peoples)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("                " + title + "     \r\n");
            sb.Append("-----------------------------------------------------------------\r\n");
            sb.Append("日期:" + DateTime.Now.ToShortDateString() + "  " + "单号:" + numbers + "\r\n");
            sb.Append("-----------------------------------------------------------------\r\n");
            sb.Append("项目" + "                    " + "数量" + "    " + "单价" + "  " + "小计" + "\r\n");
            sb.Append(content);
            sb.Append("-----------------------------------------------------------------\r\n");
            sb.Append("人数:   " + peoples + "\r\n");
            sb.Append("合计:   " + total + "\r\n");
            sb.Append("付款: 现金" + "    " + fukuan + "\r\n");
            sb.Append("现金找零:" + "   " + (fukuan - total) + "\r\n");
            sb.Append("-----------------------------------------------------------------\r\n");
            sb.Append("地址：" + address + "\r\n");
            sb.Append("电话：" + phone + "\r\n");
            sb.Append(printEnd + "\r\n");
            sb.Append(DateTime.Now.ToString() + "\r\n");
            return sb.ToString();
        }

        public static class Externs
        {
            [DllImport("winspool.drv")]
            public static extern bool SetDefaultPrinter(String Name); //调用win api将指定名称的打印机设置为默认打印机
        }
        public static class LocalPrinter
        {
            private static PrintDocument fPrintDocument = new PrintDocument();
            //获取本机默认打印机名称
            public static String DefaultPrinter()
            {
                return fPrintDocument.PrinterSettings.PrinterName;
            }
            public static List<String> GetLocalPrinters()
            {
                List<String> fPrinters = new List<String>();
                fPrinters.Add(DefaultPrinter()); //默认打印机始终出现在列表的第一项
                foreach (String fPrinterName in PrinterSettings.InstalledPrinters)
                {
                    if (!fPrinters.Contains(fPrinterName))
                    {
                        fPrinters.Add(fPrinterName);
                    }
                }
                return fPrinters;
            }
        }
        #endregion
    }
}
