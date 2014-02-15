﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.Model;
using Gymnasium_APP.BLL;

namespace Gymnasium_APP.SellCardForm
{
    public partial class SellCardCastFrm : Form
    {
        //private MemberInfo memberInfo;
        private MemberInfoModel addMemberModel = new MemberInfoModel();
       // GymnasiumDbDataContext dataContext=new GymnasiumDbDataContext();
        //public void SetMemberInfo()
        //{
            
        //}
        CardTypeInfoManager cardTypeManager = new CardTypeInfoManager();
        public SellCardCastFrm(MemberInfoModel memberModel)
        {
            InitializeComponent();
            addMemberModel = memberModel;
            this.cartTypeTxt.Enabled = false;
            this.startTimeTp.Enabled = false;
            this.endTimeTp.Enabled = false;
            this.priceAmountTxt.Enabled = false;
            this.changeAmountTxt.Enabled = false;
            if (addMemberModel != null)
            {
                cartTypeTxt.Text = addMemberModel.CardType;
                startTimeTp.Text = addMemberModel.StartTime;
                endTimeTp.Text = addMemberModel.EndTime;
                leftCountTxt.Text = addMemberModel.Count;
                List<CardTypeInfoModel> cardtypeModelList = cardTypeManager.GetModelList(" CardTypeName='"+addMemberModel.CardType+"'");
                if (cardtypeModelList.Count > 0)
                {
                    priceAmountTxt.Text = cardtypeModelList[0].MonthsPrice;
                }
            }
        }

        private void SellCardCastFrm_Load(object sender, EventArgs e)
        {
        }

        private void paymentAmountTxt_TextChanged(object sender, EventArgs e)
        {
            double payAmount = 0;
            if (!String.IsNullOrEmpty(this.paymentAmountTxt.Text) &&
                double.TryParse(this.paymentAmountTxt.Text, out payAmount))
            {
                this.changeAmountTxt.Text =
                    Convert.ToString(Convert.ToDecimal(this.paymentAmountTxt.Text) - Convert.ToDecimal(this.priceAmountTxt.Text));
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            model.CastId = manager.GetMaxId();
            model.MemberId = addMemberModel.MemberID.ToString();
            model.PriceAmount = Convert.ToDecimal(priceAmountTxt.Text.Trim());
            model.PaymentAmount = Convert.ToDecimal(paymentAmountTxt.Text.Trim());
            model.ChangeAmount = Convert.ToDecimal(changeAmountTxt.Text.Trim());
            model.CreateTime = Convert.ToDateTime(CommTools.GetDateFormatStrot(DateTime.Now));
            model.AddTypeName = addMemberModel.CardType;
            model.CardID = addMemberModel.CardID;
            model.TypeName = "现金消费";
            model.Des = "售卡";
            model.AddUserName = MainForm.userName;
            int isAdd = manager.Add(model);
            MessageBox.Show("会员：" + addMemberModel.Name + " 消费" + (isAdd > 0 ? "成功！" : "失败！"));
            CommTools.AddSystemLog("添加", "会员：" + addMemberModel.Name + " 消费信息 " + addMemberModel.CardType + "添加" + (isAdd > 0 ? "成功！" : "失败！"));
            this.Close();
        }

        private SellCastManager manager = new SellCastManager();
        private SellCastModel model = new SellCastModel();
        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确认要退出当前操作吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
           
        }
    }
}