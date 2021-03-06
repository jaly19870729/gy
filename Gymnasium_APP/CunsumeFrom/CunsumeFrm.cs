﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.Config;
using Gymnasium_APP.Model;
using Gymnasium_APP.BLL;
using System.IO;
using Gymnasium_APP.SellCardForm;
using System.Text.RegularExpressions;

namespace Gymnasium_APP.CunsumeFrom
{
    public partial class CunsumeFrm : Form
    {
        
        public CunsumeFrm()
        {
            InitializeComponent();
            

        }

        #region 局部变量
        private CunsumeTypeManager cunsumeTypeManager=new CunsumeTypeManager();
        private CunsumeCastManager cunsumeCastManager=new CunsumeCastManager();
        private MemberInfoManager memberInfoManager=new MemberInfoManager();
        private int memberId;
        #endregion

        #region 窗体事件
        private void CunsumeFrm_Load(object sender, EventArgs e)
        {
            linkLabel1_LinkClicked(null, null);
            Init();
            cmb_PayType.SelectedIndex = 0;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                SubmitData();
            }
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_CunsumeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPriceAmount();
        }
        private void txt_CunsumeCount_TextChanged(object sender, EventArgs e)
        {
            if (ValidateCount())
            {
                SetPayableAmount();
            }
        }
        private void txt_PaymentAmount_TextChanged(object sender, EventArgs e)
        {
            if (ValidatePaymentAmount())
            {
                SetChangeAmount();
            }
        }

        private void txt_CardNumber_TextChanged(object sender, EventArgs e)
        {

                //if (ValidateMember())
                //{

                //}
            
    }

        #endregion

        #region 数据处理

        private bool ValidatePaymentAmount()
        {
            if (!AppConfig.ValidateAmount(this.txt_PaymentAmount.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_PaymentAmount,AppConfig.AmountRegexError);
                return false;
            }
            return true;    
        }
        /// <summary>
        /// 验证人数
        /// </summary>
        /// <returns></returns>
        private bool ValidateCount()
        {
            if (!AppConfig.ValidateInt(this.txt_CunsumeCount.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_CunsumeCount, AppConfig.IntRegexError);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 验证member
        /// </summary>
        /// <returns></returns>
        private bool ValidateMember()
        {
            this.errorProvider1.Clear();
            if (AppConfig.ValidateCardNumber(this.txt_CardNumber.Text))
            {
                List<MemberInfoModel> memberInfoModels =
                    this.memberInfoManager.GetModelList("CardID='" +this.txt_CardNumber.Text+ "' AND InfoType='正常'");
                if (memberInfoModels != null && memberInfoModels.Count > 0 && memberInfoModels[0].CardType.Contains("次"))
                {
                    memberId = memberInfoModels[0].MemberID;
                    return true;
                }
                else
                {
                    this.errorProvider1.Clear();
                    this.errorProvider1.SetError(this.txt_CardNumber,"次卡不存在");
                    return false;
                }
            }
            else
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_CardNumber,AppConfig.CardNumberRegexError);
                return false;
            }
        }
        /// <summary>
        /// 验证控件
        /// </summary>
        /// <returns></returns>
        private bool ValidateControl()
        {
            return ValidatePaymentAmount() && ValidateCount();
        }
        private SellCastManager manager = new SellCastManager();
        private SellCastModel model = new SellCastModel();
        /// <summary>
        /// 提交数据
        /// </summary>
        private void SubmitData()
        {
            model.CastId = manager.GetMaxId();
            model.CusNum = txt_CardNumber.Text.Trim();
            model.MemberId = "0";
            model.CardID = "0";
            model.PriceAmount = Convert.ToDecimal(txt_PayableAmount.Text.Trim());
            model.PaymentAmount = Convert.ToDecimal(txt_PaymentAmount.Text.Trim());
            model.ChangeAmount = Convert.ToDecimal(txt_ChangeAmount.Text.Trim());
            model.CreateTime = CommTools.GetDateFormatStrot2(DateTime.Now);
            model.CusType = this.cmb_CunsumeType.Text;
            model.CreateTime = CommTools.GetDateFormatStrot2(DateTime.Now);
            model.Peoples = txt_PeoPles.Text.Trim();
            model.CusCount = txt_CunsumeCount.Text.Trim();
            model.TypeName = cmb_PayType.Text.Trim();
            model.Prices = txt_PriceAmount.Text.Trim();
            model.Des = "单次消费";
            model.AddUserName = MainForm.userName;
            model.CusState = 0;
            int isAdd = manager.Add(model);
            MessageBox.Show("单号：" +  txt_CardNumber.Text.Trim() + " 消费" + (isAdd > 0 ? "成功！" : "失败！"));
            //StringBuilder sb = new StringBuilder();
            //string content = Regex.Replace(CommTools.GetString(cmb_CunsumeType.Text.Trim(), 8), @" ", "    ");
            //string coi = Regex.Replace(CommTools.GetString(txt_CunsumeCount.Text.Trim(), 6), @" ", "    ");
            //string coi2 = Regex.Replace(CommTools.GetString(txt_PriceAmount.Text.Trim(), 6), @" ", "    ");
            //string coi3 = Regex.Replace(CommTools.GetString(txt_PaymentAmount.Text.Trim(), 6), @" ", "    ");
            //sb.Append(content + coi + coi2 + coi3);
            CommTools.AddSystemLog("添加", "单次消费：" + txt_CardNumber.Text.Trim() + " 消费信息 " + this.cmb_CunsumeType.Text + "添加" + (isAdd > 0 ? "成功！" : "失败！"));
            //string mes = CommTools.GetPrintStr(MainForm.PrintTitle, model.CusNum, MainForm.PrintAddress, MainForm.PrintPhone, MainForm.PrintEnd, Convert.ToDouble(model.PriceAmount), Convert.ToDouble(model.PaymentAmount), sb.ToString(), txt_PeoPles.Text.Trim());
            //MessageBox.Show(mes);
            PrintForm pf=new PrintForm (model.CusNum,cmb_CunsumeType.Text.Trim(),txt_CunsumeCount.Text.Trim(),txt_PriceAmount.Text.Trim(),txt_PayableAmount.Text.Trim(),txt_PeoPles.Text.Trim(),txt_PayableAmount.Text.Trim(),txt_PaymentAmount.Text.Trim(),txt_ChangeAmount.Text.Trim(),cmb_PayType.Text.Trim());
            pf.ShowDialog();
            this.Close();
            //CunsumeCastModel cunsumeCastModel=new CunsumeCastModel();
            //cunsumeCastModel.Id = cunsumeCastManager.GetMaxId();
            //cunsumeCastModel.ChangeAmount = Convert.ToDecimal(this.txt_ChangeAmount.Text);
            //cunsumeCastModel.Count = Convert.ToInt32(this.txt_CunsumeCount.Text);
            //cunsumeCastModel.CreateTime = this.dtp_AddTime.Value;
            //cunsumeCastModel.CusType = this.cmb_CunsumeType.Text;
            //cunsumeCastModel.MemberId = Convert.ToInt32(txt_CardNumber.Text.Trim());
            //cunsumeCastModel.PayableAmount = Convert.ToDecimal(this.txt_PayableAmount.Text);
            //cunsumeCastModel.PriceAmount = Convert.ToDecimal(this.txt_PriceAmount.Text);
            //cunsumeCastModel.TransactDate = this.dtp_AddTime.Value;
            //int result = this.cunsumeCastManager.Add(cunsumeCastModel);
            //CommTools.AddSystemLog("单次消费", "卡号：" + this.txt_CardNumber.Text + "消费：" + this.txt_PayableAmount.Text + (result > 0 ? "成功" : "失败"));
            //MessageBox.Show("卡号："+this.txt_CardNumber.Text+"消费："+this.txt_PayableAmount.Text+(result>0?"成功":"失败"));
            //this.Close();
        }
        /// <summary>
        /// 设置单价
        /// </summary>
        private void SetPriceAmount()
        {
            if (this.cmb_CunsumeType.SelectedItem != null && this.cmb_CunsumeType.SelectedItem is CunsumeTypeModel)
            {
                CunsumeTypeModel cunsumeTypeModel = this.cmb_CunsumeType.SelectedItem as CunsumeTypeModel;
                this.txt_PriceAmount.Text = Convert.ToString(cunsumeTypeModel.CusPrice);

            }
        }
        /// <summary>
        /// 计算应付金额
        /// </summary>
        private void SetPayableAmount()
        {
            this.txt_PayableAmount.Text =
                Convert.ToString(Convert.ToInt32(this.txt_CunsumeCount.Text)*Convert.ToDecimal(this.txt_PriceAmount.Text));
        }
        /// <summary>
        /// 计算找零
        /// </summary>
        private void SetChangeAmount()
        {
            this.txt_ChangeAmount.Text =
                Convert.ToString(Convert.ToDecimal(this.txt_PaymentAmount.Text) -
                                 Convert.ToDecimal(this.txt_PayableAmount.Text));
        }
        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            this.dtp_AddTime.Value = DateTime.Now;
            this.txt_PriceAmount.Enabled = false;
            this.txt_PayableAmount.Enabled = false;
            this.txt_ChangeAmount.Enabled = false;
            this.cmb_CunsumeType.DataSource = this.cunsumeTypeManager.GetModelList("1=1");
            this.cmb_CunsumeType.DisplayMember = "CusType";
            this.cmb_CunsumeType.ValueMember = "Id";

        }
        #endregion

        private void txt_PayableAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<SellCastModel> sellCastModelsList = manager.GetModelList(" Des='单次消费'");
            if (sellCastModelsList.Count == 0)
            {
                txt_CardNumber.Text = "000001";
            }
            else
            {
                int d = Convert.ToInt32(sellCastModelsList[sellCastModelsList.Count-1].CusNum) + 1;
                string a = "";
                if (d.ToString().Length < 6)
                {
                    for (int i = 0; i < 6-d.ToString().Length; i++)
                    {
                        a += "0";
                    }
                }
                txt_CardNumber.Text = a+d.ToString();
            }
        }

        private void CunsumeFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidateControl())
                {
                    SubmitData();
                }
            }
        }

        

        
    }
}
