using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Gymnasium_APP.BLL
{
    public class AppConfigTools
    {
        private static XmlDocument Doc = new XmlDocument();
        public AppConfigTools()
        {
            
        }
        public void LoadAppConfig()
        {
            Doc.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Gymnasium_APP.exe.config");
        }
        public static void SetAppValue(string key, string newValue)
        {
            try
            {
                Doc.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Gymnasium_APP.exe.config");
                Doc.SelectSingleNode("/configuration/appSettings/add[@key='" + key + "']").Attributes["value"].Value = newValue;
                Doc.Save(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Gymnasium_APP.exe.config");
            }
            catch (Exception)
            {
                return;
            }
        }
        public void SaveAppConfig()
        {
            try
            {
                Doc.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Gymnasium_APP.exe.config");
                Doc.Save(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Gymnasium_APP.exe.config");
                Doc.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Gymnasium_APP.exe.config");
            }
            catch (Exception)
            {
                return;
            }
        }
        public static string GetAppValue(string key)
        {
            try
            {
                Doc.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Gymnasium_APP.exe.config");
                return Doc.SelectSingleNode("/configuration/appSettings/add[@key='" + key + "']").Attributes["value"].Value;
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }
    }
}
