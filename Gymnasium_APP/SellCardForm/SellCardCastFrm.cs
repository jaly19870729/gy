using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.Model;
using Gymnasium_APP.BLL;
using System.IO;
using Gymnasium_APP.SellCardForm;

namespace Gymnasium_APP.SellCardForm
{
    public partial class SellCardCastFrm : Form
    {
        private MemberInfoModel addMemberModel = new MemberInfoModel();
        CardTypeInfoManager cardTypeManager = new CardTypeInfoManager();
        private SellCastManager manager = new SellCastManager();
        private SellCastModel model = new SellCastModel();

        public SellCardCastFrm(MemberInfoModel memberModel)
        {
            InitializeComponent();
            addMemberModel = memberModel;
            this.txt_CardType.Enabled = false;
            this.dtp_StartTime.Enabled = false;
            this.dtp_EndTime.Enabled = false;
            this.txt_PriceAmount.Enabled = false;
            this.txt_ChangeAmount.Enabled = false;
            if (addMemberModel != null)
            {
                txt_CardType.Text = addMemberModel.CardType;
                dtp_StartTime.Text = addMemberModel.StartTime;
                dtp_EndTime.Text = addMemberModel.EndTime;
                txt_LeftCount.Text = addMemberModel.Count;
                List<CardTypeInfoModel> cardtypeModelList = cardTypeManager.GetModelList(" CardTypeName='" + addMemberModel.CardType + "'");
                if (cardtypeModelList.Count > 0)
                {
                    txt_PriceAmount.Text = cardtypeModelList[0].MonthsPrice;
                }
            }

        }

        private void SellCardCastFrmBak_Load(object sender, EventArgs e)
        {
            cmb_PayType.SelectedIndex = 0;
        }

        private void txt_PaymentAmount_TextChanged(object sender, EventArgs e)
        {
            double payAmount = 0;
            if (!String.IsNullOrEmpty(this.txt_PaymentAmount.Text) &&
                double.TryParse(this.txt_PaymentAmount.Text, out payAmount))
            {
                this.txt_ChangeAmount.Text =
                    Convert.ToString(Convert.ToDecimal(this.txt_PaymentAmount.Text) - Convert.ToDecimal(this.txt_PriceAmount.Text));
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txt_PaymentAmount.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_PaymentAmount, "请输入正确的金额！");

            
                return; 
            }
            try
            {
                Convert.ToDecimal(txt_PaymentAmount.Text.Trim());
            }
            catch (Exception)
            {
                errorProvider1.SetError(txt_PaymentAmount, "请输入正确的金额！");
                return;


            }
            model.CastId = manager.GetMaxId();
            model.MemberId = addMemberModel.MemberID.ToString();
            model.PriceAmount = Convert.ToDecimal(txt_PriceAmount.Text.Trim());
            model.PaymentAmount = Convert.ToDecimal(txt_PaymentAmount.Text.Trim());
            model.ChangeAmount = Convert.ToDecimal(txt_ChangeAmount.Text.Trim());
            model.CreateTime = CommTools.GetDateFormatStrot2(DateTime.Now);
            model.AddTypeName = addMemberModel.CardType;
            model.CardID = addMemberModel.CardID;
            model.TypeName =cmb_PayType.Text.Trim();
            model.Des = "售卡";
            model.AddUserName = MainForm.userName;
            int isAdd = manager.Add(model);
            MessageBox.Show("会员：" + addMemberModel.Name + " 消费" + (isAdd > 0 ? "成功！" : "失败！"));
            CommTools.AddSystemLog("添加", "会员：" + addMemberModel.Name + " 消费信息 " + addMemberModel.CardType + "添加" + (isAdd > 0 ? "成功！" : "失败！"));
            this.Close();
        }

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
