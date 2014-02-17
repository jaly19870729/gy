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
    }
}
