using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.Config;
using Gymnasium_APP.MemberForm;
using Gymnasium_APP.Model;
using Gymnasium_APP.BLL;
using System.IO;
using Gymnasium_APP.SellCardForm;

namespace Gymnasium_APP.SwipeCardFrom
{
    public partial class SwipeCardFrm : Form
    {

        public SwipeCardFrm()
        {
            InitializeComponent();
        }
        #region 局部变量
        private MemberInfoManager memberInfoManager=new MemberInfoManager();
        private  CardTypeInfoManager cardTypeInfoManager=new CardTypeInfoManager();
        private  SwipingInfoManager swipingInfoManager=new SwipingInfoManager();
        private bool ValidateFlag = true;
        private MemberInfoModel memberInfoModel;
        #endregion
        #region 窗体事件
        /**
         * 如果是会员卡，那么操作人员用会员卡刷卡，照片、卡号和卡类型自动录入。如果是时段卡，那么失效日期会自动显示，剩余次数和消费人数变为灰色，不能操作。如果是次卡，那么剩余次数会自动显示当前剩余次数，点进场以后，剩余次数自动减1，然后显示新的剩余次数；此时，失效日期和消费人数变为灰色，不能操作.如果是现金消费客户，那么失效日期和剩余次数都是灰色，不能操作，消费人数手工填入。刷卡日期自动填入，当时时间，精确到秒。现金消费的时候，点击进场也可以显示这个时间。（也可以去掉，系统自动记录时间，在后台。）
以上步骤完成后，点进场。完成进场操作。

         */
        private void cmb_CunsumeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            ValidateFlag = true;
            if (String.IsNullOrEmpty(this.cmb_CunsumeType.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.cmb_CunsumeType, "请选择消费类型");
                ValidateFlag = false;
                return;
            }
            else
            {
                switch (this.cmb_CunsumeType.Text)
                {
                    case "会员卡刷卡":
                        if (AppConfig.ValidateCardNumber(this.txt_CardNumber.Text))
                        {
                            MemberSwipeCaseInit();
                        }
                        else
                        {
                            this.errorProvider1.Clear();
                            this.errorProvider1.SetError(this.txt_CardNumber,AppConfig.CardNumberRegexError);
                            ValidateFlag = false;
                            return;
                        }
                        break;
                    case "现金消费":
                        CashSwipeCaseInit();
                        break;
                }
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SubmitInValidate();
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            SubmitOutValidate();
        }

        private void SwipeCardFrm_Load(object sender, EventArgs e)
        {
            this.dtp_AddTime.Value = DateTime.Now;
            this.dtp_AddTime.Enabled = false;
        }

        private void txt_CardNumber_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            ValidateFlag = true;
            if (AppConfig.ValidateCardNumber(this.txt_CardNumber.Text))
            {
                MemberSwipeCaseInit();
            }
            else
            {
                this.errorProvider1.Clear(); 
                this.errorProvider1.SetError(this.txt_CardNumber,AppConfig.CardNumberRegexError);
                ValidateFlag = false;
                return;

            }
        }

        #endregion

        #region 数据处理
        /// <summary>
        /// 出场逻辑
        /// </summary>
        private void SubmitOutValidate()
        {
            if (ValidateFlag)
            {
                SwipingInfoModel swipingInfoModel = new SwipingInfoModel();
                swipingInfoModel.AddTime = this.dtp_AddTime.Text;
                swipingInfoModel.CardID = this.txt_CardNumber.Text;
                swipingInfoModel.CardType = this.cmb_CardType.Text;
                swipingInfoModel.Desc = this.cmb_CunsumeType.Text.Equals("会员卡刷卡") ? "刷卡出场" : "现金消费出场";
                swipingInfoModel.SwipingPeople = this.txt_CunsumeCount.Text;
                swipingInfoModel.SwipingType = this.cmb_CunsumeType.Text;
                bool result = swipingInfoManager.Add(swipingInfoModel);
                CommTools.AddSystemLog("出场刷卡", swipingInfoModel.Desc + " " + (result ? "成功" : "失败"));
                MessageBox.Show(swipingInfoModel.Desc + " " + (result ? "成功" : "失败"));
                this.Close();
            }
            
        }

        /// <summary>
        /// 入场提交逻辑
        /// 
        /// </summary>
        private void SubmitInValidate()
        {
          if (ValidateFlag)
          {
              SwipingInfoModel swipingInfoModel=new SwipingInfoModel();
              swipingInfoModel.AddTime = this.dtp_AddTime.Text;
              swipingInfoModel.CardID = this.txt_CardNumber.Text;
              swipingInfoModel.CardType = this.cmb_CardType.Text;
              swipingInfoModel.Desc = this.cmb_CunsumeType.Text.Equals("会员卡刷卡") ? "刷卡入场" : "现金消费入场";
              swipingInfoModel.SwipingPeople = this.txt_CunsumeCount.Text;
              swipingInfoModel.SwipingType = this.cmb_CunsumeType.Text;
              bool result=swipingInfoManager.Add(swipingInfoModel);
              CommTools.AddSystemLog("入场刷卡",swipingInfoModel.Desc+" "+(result?"成功":"失败"));
              MessageBox.Show(swipingInfoModel.Desc + " " + (result ? "成功" : "失败"));
              // 如果是次卡，那么剩余次数会自动显示当前剩余次数，点进场以后，剩余次数自动减1，然后显示新的剩余次数
              SubmitByTimesCardType();
              this.Close();

          }
        }
        private void SubmitByTimesCardType()
        {
            if (String.IsNullOrEmpty(this.cmb_CardType.Text))
            {
                List<CardTypeInfoModel> cardTypeInfoModels =cardTypeInfoManager.GetModelList("CardTypeName='" + this.cmb_CardType.Text + "'");
                if (cardTypeInfoModels!= null && cardTypeInfoModels.Count > 0)
                {
                    if (cardTypeInfoModels[0].TypeName.Equals("计次产品") && memberInfoModel!=null)
                    {
                        memberInfoModel.Count = Convert.ToInt32(memberInfoModel.Count) > 0
                            ? Convert.ToString(Convert.ToInt32(memberInfoModel.Count) - 1):"";

                    }
                }

            }
        }
        /// <summary>
        /// 会员刷卡
        /// 如果是会员卡，那么操作人员用会员卡刷卡，照片、卡号和卡类型自动录入。如果是时段卡，那么失效日期会自动显示，剩余次数和消费人数变为灰色，不能操作。如果是次卡，那么剩余次数会自动显示当前剩余次数，点进场以后，剩余次数自动减1，然后显示新的剩余次数；此时，失效日期和消费人数变为灰色，不能操作
        /// </summary>
        private void MemberSwipeCaseInit()
        {
            ValidateFlag = true;   
            String cardNumber = this.txt_CardNumber.Text;
            List<MemberInfoModel> memberInfoModels =
                this.memberInfoManager.GetModelList("CardID='"+this.txt_CardNumber.Text + "' and InfoType='正常'");
            if (memberInfoModels != null && memberInfoModels.Count > 0)
            {
                memberInfoModel = memberInfoModels[0];
                if (memberInfoModels[0].Photo != null && memberInfoModels[0].Photo.Length > 0)
                {
                    this.pictureBox1.Image = CommTools.ByteToImg(memberInfoModels[0].Photo);

                }
                this.cmb_CardType.Items.Add(memberInfoModels[0].CardType);
                this.cmb_CardType.SelectedItem = memberInfoModels[0].CardType;
                List<CardTypeInfoModel> cardTypeInfoModels = this.cardTypeInfoManager.GetModelList("CardTypeName='"+memberInfoModels[0].CardType+"'");
                if (cardTypeInfoModels != null && cardTypeInfoModels.Count > 0)
                {
                    switch (cardTypeInfoModels[0].TypeName)
                    {
                        case "计时产品":
                            this.dtp_EndTime.Text=memberInfoModels[0].EndTime;
                            this.txt_LeftCount.Enabled = false;
                            this.txt_CunsumeCount.Enabled = false;

                            break;
                        case "计次产品":
                            this.txt_LeftCount.Text = memberInfoModels[0].Count;

                            this.txt_LeftCount.Enabled = false;
                            this.dtp_EndTime.Enabled = false;
                            if (Convert.ToInt32(memberInfoModels[0].Count) <= 0)
                            {
                                this.ValidateFlag = false;
                                this.errorProvider1.Clear();
                                this.errorProvider1.SetError(this.txt_LeftCount, "剩余次数为0");
                                MessageBox.Show("剩余次数为0");
                            }
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("此卡号不存在");
                return;
            }
        }
        /// <summary>
        /// 现金消费
        /// 如果是现金消费客户，那么失效日期和剩余次数都是灰色，不能操作，消费人数手工填入。
        /// </summary>
        private void CashSwipeCaseInit()
        {
            ValidateFlag = true;
            this.txt_CardNumber.Enabled = false;
            this.cmb_CardType.Enabled = false;
            this.dtp_EndTime.Enabled = false;
            this.txt_LeftCount.Enabled = false;
            
        }
        #endregion

        



    }
}
