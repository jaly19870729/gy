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

namespace Gymnasium_APP.BackCardFrom
{
    public partial class BackCardDialog : Form
    {


        public BackCardDialog()
        {
            InitializeComponent();

        }
        #region 窗体事件
        /// <summary>
        /// 有卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Extension_Click(object sender, EventArgs e)
        {
            new HasCardBackFrm(BackCardType.HasCard).Show();
            this.Close();
        }
        /// <summary>
        /// 无卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AllExtension_Click(object sender, EventArgs e)
        {
            new HasCardBackFrm(BackCardType.NoCard).Show();
            this.Close();
        }

        #endregion


    }
}
