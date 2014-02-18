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

namespace Gymnasium_APP.LossFrom
{
    public partial class LossCastFrm : Form
    {
        
        public LossCastFrm(int lossCardId,String cardNumber)
        {
            InitializeComponent();

            this.lossCardId = lossCardId;
            this.cardNumber = cardNumber;
        }
        #region 局部变量
        private LossCastManager lossCastManager=new LossCastManager();
        private String cardNumber;
        private int lossCardId;
        private decimal payableAmount = 10;
        #endregion

        #region 窗体事件

        private void LossCastFrm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void txt_PriceAmount_TextChanged(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CalAmount();
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            SubmitData();
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            //此处为bug
            this.Close();
        }
        #endregion

        #region 数据处理
        /// <summary>
        /// 提交数据
        /// </summary>
        private void SubmitData()
        {
            LossCastModel lossCastModel=new LossCastModel();
            lossCastModel.ChangeAmount = Convert.ToDecimal(this.txt_ChangeAmount.Text);
            lossCastModel.CreateTime = DateTime.Now;
            lossCastModel.LossCardId = lossCardId;
            lossCastModel.PayableAmount = Convert.ToDecimal(this.txt_PayableAmount.Text);
            lossCastModel.PaymentAmount = Convert.ToDecimal(this.txt_PaymentAmount.Text);
            // 添加
            int result=lossCastManager.Add(lossCastModel);
            CommTools.AddSystemLog("挂失交费","挂失补领卡号："+this.cardNumber+"收费 "+(result>0?"成功":"失败"));
            MessageBox.Show("挂失补领卡号：" + this.cardNumber + "收费 " + (result > 0 ? "成功" : "失败"));
            this.Close();
        }

        /// <summary>
        /// 初始化窗体
        /// </summary>
        private void Init()
        {
            //禁用窗体
            this.txt_PayableAmount.Enabled = false;
            this.txt_ChangeAmount.Enabled = false;
            this.txt_PayableAmount.Text = Convert.ToString(payableAmount);
        }
        /// <summary>
        /// 计算金额
        /// </summary>
        private void CalAmount()
        {
            this.txt_ChangeAmount.Text = Convert.ToString(Convert.ToDecimal(this.txt_PaymentAmount.Text) -
                                         Convert.ToDecimal(this.txt_PayableAmount.Text));
        }

        /// <summary>
        /// 验证数据
        /// </summary>
        /// <returns></returns>
        private bool ValidateData()
        {
            decimal payAmount = 0;
            if (decimal.TryParse(this.txt_PaymentAmount.Text, out payAmount))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        

       


    }
}
