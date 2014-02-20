using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gymnasium_APP.ReportFrom
{
    public partial class ReportsFrom : Form
    {
        public ReportsFrom()
        {
            InitializeComponent();
        }

        private void ReportsFrom_Load(object sender, EventArgs e)
        {
            
            string reportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            string url = reportPath + "\\ReportFrom\\Pie3D\\Pie3D.html";
            this.webBrowser1.Url = new System.Uri(url);
        }
    }
}
