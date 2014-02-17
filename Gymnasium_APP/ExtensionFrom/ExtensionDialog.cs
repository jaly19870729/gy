using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Gymnasium_APP.Model;
using Gymnasium_APP.BLL;
using System.IO;
using Gymnasium_APP.SellCardForm;

namespace Gymnasium_APP.ExtensionFrom
{
    public partial class ExtensionDialog : Form
    {

       
        public ExtensionDialog()
        {
            InitializeComponent();

        }
        #region 窗体事件

        private void SellCardCastFrmBak_Load(object sender, EventArgs e)
        {

        }
       
        private void btn_Extension_Click(object sender, EventArgs e)
        {
            new SingleExtensionFrm().Show();
            this.Close();
        }
        private void btn_AllExtension_Click(object sender, EventArgs e)
        {

        }
        #endregion

       

        

       

        



    }
}
