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
    public partial class ExtensionFrm : Form
    {

        #region 局部变量
        private MemberInfoManager memberInfoManager = new MemberInfoManager();
         
        #endregion

        public ExtensionFrm()
        {
            InitializeComponent();
            InitForm();

        }
        #region 窗体事件

        private void SellCardCastFrmBak_Load(object sender, EventArgs e)
        {

        }
        private void txt_CardNumber_TextChanged(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                CardNumberChange();
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            SubmitData();
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 数据库处理
        /// <summary>
        /// 窗体初始化方法
        /// </summary>
        private void InitForm()
        {
            List<Control> filterCtr=new List<Control>();
            filterCtr.Add(this.dtp_ExtensionStartTime);
            filterCtr.Add(this.dtp_ExtensionEndTime);
            DisableControls(filterCtr);
            this.dtp_ExtensionStartTime.MinDate = DateTime.Now;
            this.dtp_ExtensionEndTime.MinDate = this.dtp_ExtensionStartTime.Value.AddDays(1);

        }
        /// <summary>
        /// 卡号变化
        /// </summary>
        private void CardNumberChange()
        {
            String cardNumberString=this.txt_CardNumber.Text;
            List<MemberInfoModel> memberInfoModels = memberInfoManager.GetModelList("CardID='" + cardNumberString + "'");
            if (memberInfoModels != null && memberInfoModels.Count>0)
            {
                MemberInfoModel memberInfoModel = memberInfoModels[0];
                this.txt_CardType.Text = memberInfoModel.CardType;
                this.txt_Name.Text = memberInfoModel.Name;
                this.txt_IDCardNumber.Text = memberInfoModel.IDCard;
                this.dtp_EndTime.Text = memberInfoModel.EndTime;
                this.dtp_StartTime.Text = memberInfoModel.StartTime;
                
            }
            else
            {
                MessageBox.Show("没有这个卡号!");
            }
        }
        /// <summary>
        /// 验证控件数据
        /// </summary>
        /// <returns></returns>
        private bool ValidateControl()
        {
            Regex regex=new Regex("^\\w{6}$");
            return regex.IsMatch(this.txt_CardNumber.Text);

        }
        /// <summary>
        /// 提交数据
        /// </summary>
        private void SubmitData()
        {
            
        }
        #endregion

        #region 工具方法
        /// <summary>
        /// 禁用控件
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
