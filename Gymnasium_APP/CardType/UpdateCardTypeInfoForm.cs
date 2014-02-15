using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.BLL;
using Gymnasium_APP.Model;

namespace Gymnasium_APP.CardType
{
    public partial class UpdateCardTypeInfoForm : Form
    {
        private int cardTypeid;
        public UpdateCardTypeInfoForm(int cardTypeID)
        {
            InitializeComponent();
            cardTypeid = cardTypeID;
            cmb_TypeName.SelectedIndex = 0;
        }
        private CardTypeInfoManager manager = new CardTypeInfoManager();
        private void btn_OK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txt_CardTypeName.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_CardTypeName, "请输入产品名称！");
                return;
            }
            if (manager.GetModelList(" CardTypeName='" + txt_CardTypeName.Text.Trim() + "' and CardTypeID <> " + cardTypeid + "").Count > 0)
            {
                errorProvider1.SetError(txt_CardTypeName, "产品名称已存在，请更换！");
                return;
            }
            if (txt_Price.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Price, "请输入产品价格！");
                return;
            }
            try
            {
                Convert.ToInt32(txt_Price.Text.Trim());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_Price, "价格输入错误，请重新输入！");
                return;
            }
            try
            {
                Convert.ToInt32(txt_DayPrice.Text.Trim());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_DayPrice, "价格输入错误，请重新输入！");
                return;
            }
            if (txt_DayPrice.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_DayPrice, "请输入单日价格！");
                return;
            }
            if (txt_Months.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Months, "请输入产品有效期！");
                return;
            }
            try
            {
                Convert.ToInt32(txt_Months.Text.Trim());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_Months, "产品有效期输入错误，请重新输入！");
                return;
            }
            CardTypeInfoModel model = new CardTypeInfoModel();
            model.CardTypeID =cardTypeid;
            model.CardTypeName = txt_CardTypeName.Text.Trim();
            model.TypeName = cmb_TypeName.Text.Trim();
            model.Months = txt_Months.Text.Trim();
            model.MonthsPrice = txt_Price.Text.Trim();
            model.DayPrice = txt_DayPrice.Text.Trim();
            model.DateTime = CommTools.GetDateFormatStrot(DateTime.Now);
            bool isAdd = manager.Update(model);
            MessageBox.Show("消费型产品：" + txt_CardTypeName.Text.Trim() + " 修改" + (isAdd == true ? "成功！" : "失败！"));
            CommTools.AddSystemLog("修改", "消费型产品：" + txt_CardTypeName.Text.Trim() + " 修改" + (isAdd == true ? "成功！" : "失败！"));
            MainForm mf = (MainForm)this.Owner;
            mf.GetCardTypeDataList();
            this.Close();
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCardTypeInfoForm_Load(object sender, EventArgs e)
        {
            CardTypeInfoModel cardTypeModel = manager.GetModel(cardTypeid);
            if (cardTypeModel != null)
            {
                txt_CardTypeName.Text = cardTypeModel.CardTypeName;
                txt_Price.Text = cardTypeModel.MonthsPrice;
                txt_Months.Text = cardTypeModel.Months;
                txt_DayPrice.Text = cardTypeModel.DayPrice;
                cmb_TypeName.Text = cardTypeModel.TypeName;
            }

        }
    }
}
