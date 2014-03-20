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
using Gymnasium_APP.Config;

namespace Gymnasium_APP.ReservationFrom
{
    public partial class ReaservationCustForm : Form
    {
        private ReservationInfoManager reservationInfoManager = new ReservationInfoManager();//预定单
        private ReservationInfoModel reservationInfoModel = new ReservationInfoModel();
        public ReaservationCustForm(ReservationInfoModel model)
        {
            InitializeComponent();
            reservationInfoModel = model;
            txt_CusNum.Text = reservationInfoModel.ReservationNum;
            txt_CusType.Text = reservationInfoModel.TypeName;
            txt_PriceAmount.Text = reservationInfoModel.Money;
            txt_Place.Text = reservationInfoModel.Position;
            txt_Times.Text = reservationInfoModel.Times;

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

        private void ReaservationCustForm_Load(object sender, EventArgs e)
        {
            cmb_PayType.SelectedIndex = 0;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!AppConfig.ValidateAmount(this.txt_PaymentAmount.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_PaymentAmount, AppConfig.AmountRegexError);
                return;
            }
            if (reservationInfoModel != null)
            {
                reservationInfoModel.PaymentAmount = txt_PaymentAmount.Text.Trim();
                reservationInfoModel.ChangeAmount = txt_ChangeAmount.Text.Trim();
                reservationInfoModel.PayType = cmb_PayType.Text.Trim();
                reservationInfoModel.RState = "1";
                bool isupdate = reservationInfoManager.Update(reservationInfoModel);
                MessageBox.Show("消费"+(isupdate==true?"成功":"失败")+"！");
                CommTools.AddSystemLog("添加", "预定单号：" + reservationInfoModel.ReservationNum + " 预定人： " + reservationInfoModel.Name + "添加" + (isupdate ==true? "成功！" : "失败！"));
                ReservationMainForm rmf = (ReservationMainForm) this.Owner;
                rmf.cmb_CunsumeType_SelectedIndexChanged(null,null);
                rmf.ClearText();
                this.Close();
            }
         
        }
    }
}
