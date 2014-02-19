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
    public partial class BackCardCast : Form
    {
        private BackCardInfoModel backCardInfo;

        public BackCardCast(BackCardInfoModel backCardInfoModel)
        {
            InitializeComponent();
            this.backCardInfo = backCardInfoModel;
        }
        #region 窗体事件
        private void BackCardCast_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 数据处理
        /// <summary>
        /// 加载数据
        /// </summary>
        private void Init()
        {
            DisableControls(null);
            this.txt_ChnageAmount.Text = Convert.ToString(backCardInfo.ChangeAmount);
            this.txt_PaidAmount.Text = Convert.ToString(backCardInfo.PaidAmount);
            this.txt_UsedAmount.Text = Convert.ToString(backCardInfo.UsedAmount);
        }
        #endregion

        #region 工具辅助
        /// <summary>
        /// 禁用窗体
        /// </summary>
        /// <param name="filter"></param>
        private void DisableControls(List<Control> filter)
        {
            foreach (Control ctr in this.tableLayoutPanel2.Controls)
            {
                if (filter != null && filter.Contains(ctr))
                {
                    ctr.Enabled = true;
                }
                else if (ctr.GetType().Equals(typeof(TextBox)) || ctr.GetType().Equals(typeof(DateTimePicker)) ||
                     ctr.GetType().Equals(typeof(ComboBox)))
                {
                    ctr.Enabled = false;
                }
                else
                {
                    ctr.Enabled = true;
                }

            }
        }
        #endregion



    }
}
