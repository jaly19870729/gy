using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Gymnasium_APP.Config;
using Gymnasium_APP.MemberForm;
using Gymnasium_APP.Model;
using Gymnasium_APP.BLL;
using System.IO;
using Gymnasium_APP.SellCardForm;

namespace Gymnasium_APP.BackCardFrom
{
    public partial class HasCardBackFrm : Form
    {
        
        public HasCardBackFrm(BackCardType type)
        {
             InitializeComponent();
            this.backCardType = type;
        }

        #region 局部变量

        private decimal patchAmount = 10;
        private MemberInfoModel toupdateMemberInfo;
        private BackCardType backCardType;
        private CardTypeInfoManager cardTypeInfoManager=new CardTypeInfoManager();
        private MemberInfoManager memberInfoManager = new MemberInfoManager();
        private BackCardInfoManager backCardInfoManager=new BackCardInfoManager();
        #endregion

        #region 窗体事件
        private void HasCardBackFrm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void txt_CardNumber_TextChanged(object sender, EventArgs e)
        {
            if (this.backCardType==BackCardType.HasCard && ValidateHasCard())
            {
                SetControlValue(GetMemberInfo());
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                Submit();
            }
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmb_IDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.backCardType == BackCardType.NoCard)
            {
                if (ValidateNoCard())
                {
                    SetControlValue(GetMemberInfoByID());
                }
                

            }
        }

        private void txt_IDCard_TextChanged(object sender, EventArgs e)
        {
            if (this.backCardType == BackCardType.NoCard)
            {
                if (ValidateNoCard())
                {
                    SetControlValue(GetMemberInfoByID());
                }
            }
        }
        #endregion
        
        #region 数据处理
        /// <summary>
        /// 获取会员数据通过ID
        /// </summary>
        /// <returns></returns>
        private MemberInfoModel GetMemberInfoByID()
        {
            List<MemberInfoModel> memberInfoModels =
               memberInfoManager.GetModelList("IDCardType='" + this.cmb_IDType.Text + "' and IDCard='" + this.txt_IDCard.Text + "'  and InfoType='正常'");
            if (memberInfoModels != null && memberInfoModels.Count > 0)
            {
                toupdateMemberInfo = memberInfoModels[0];
                return memberInfoModels[0];
            }
            return null;
        }
        /// <summary>
        /// 数据初始化
        /// </summary>
        private void Init()
        {
            switch (backCardType)
            {
                case BackCardType.NoCard:
                    this.tableLayoutPanel2.SetCellPosition(this.txt_CardNumber, new TableLayoutPanelCellPosition(1, 4));
                    this.tableLayoutPanel2.SetCellPosition(this.label2, new TableLayoutPanelCellPosition(0, 4));
                    this.tableLayoutPanel2.SetCellPosition(this.cmb_CardType, new TableLayoutPanelCellPosition(1, 3));
                    this.tableLayoutPanel2.SetCellPosition(this.label4, new TableLayoutPanelCellPosition(0, 3));
                    this.tableLayoutPanel2.SetCellPosition(this.txt_IDCard, new TableLayoutPanelCellPosition(1, 0));
                    this.tableLayoutPanel2.SetCellPosition(this.label5, new TableLayoutPanelCellPosition(0, 0));
                    this.tableLayoutPanel2.SetCellPosition(this.cmb_IDType, new TableLayoutPanelCellPosition(1, 1));
                    this.tableLayoutPanel2.SetCellPosition(this.label7, new TableLayoutPanelCellPosition(0, 1));
                    this.Text = "无卡退卡";
                    this.label1.Text = "无卡退卡";
                    break;
            }
        }
        /// <summary>
        /// 提交数据
        /// </summary>
        private void Submit()
        {
            BackCardInfoModel backCardInfoModel=new BackCardInfoModel();
            backCardInfoModel.AddTime = this.dtp_AddTime.Value;
            backCardInfoModel.CardNumber = this.txt_CardNumber.Text;
            backCardInfoModel.CardType = this.cmb_CardType.Text;
            backCardInfoModel.ChangeAmount = Convert.ToDecimal(this.txt_ChangeAmount.Text);
            backCardInfoModel.CreateTime = DateTime.Now;
            backCardInfoModel.EndTime = this.dtp_EndTime.Value;
            backCardInfoModel.IDCardNumber = this.txt_IDCard.Text;
            backCardInfoModel.IDCardType = this.cmb_IDType.Text;
            backCardInfoModel.LeftDays = String.IsNullOrEmpty(this.txt_LeftDays.Text)?0:Convert.ToInt32(this.txt_LeftDays.Text);
            backCardInfoModel.LeftTimes = String.IsNullOrEmpty(this.txt_LeftTimes.Text)
                                              ? 0
                                              : Convert.ToInt32(this.txt_LeftTimes.Text);
            backCardInfoModel.Name = this.txt_Name.Text;
            backCardInfoModel.PaidAmount = Convert.ToDecimal(this.txt_PaidAmount.Text);
            backCardInfoModel.StartTime = this.dtp_StartTime.Value;
            backCardInfoModel.TotalDays = String.IsNullOrEmpty(this.txt_TotalDays.Text) ? 0 : Convert.ToInt32(this.txt_TotalDays.Text);
            backCardInfoModel.TotalTimes = String.IsNullOrEmpty(this.txt_TotalTimes.Text)
                                               ? 0
                                               : Convert.ToInt32(this.txt_TotalTimes.Text);
            backCardInfoModel.UsedAmount = backCardInfoModel.PaidAmount - backCardInfoModel.ChangeAmount;
            backCardInfoModel.PatchAmount = patchAmount;
            bool result=backCardInfoManager.Add(backCardInfoModel);
            //todo:删除会员信息
            if (toupdateMemberInfo != null)
            {
                toupdateMemberInfo.InfoType = "已退卡";
                memberInfoManager.Update(toupdateMemberInfo);
            }
            CommTools.AddSystemLog(this.label1.Text,this.label1.Text+"卡号："+backCardInfoModel.CardNumber+(result==true?"成功":"失败"));
            MessageBox.Show(this.label1.Text+"卡号：" + backCardInfoModel.CardNumber + (result == true ? "成功" : "失败"));
            if (backCardType == BackCardType.HasCard)
            {
                BackCardCast backCardCast=new BackCardCast(backCardInfoModel);
                backCardCast.Show();
            }else if(backCardType==BackCardType.NoCard)
            {
                NoCardBackCardCast noCardBackCardCast=new NoCardBackCardCast(backCardInfoModel);
                noCardBackCardCast.Show();
            }
            this.Close();
        }
        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <returns></returns>
        private MemberInfoModel GetMemberInfo()
        {
            List<MemberInfoModel> memberInfoModels =
                memberInfoManager.GetModelList("CardID='" + this.txt_CardNumber.Text + "' and InfoType='正常'");
            if (memberInfoModels != null && memberInfoModels.Count > 0)
            {
                toupdateMemberInfo = memberInfoModels[0];
                return memberInfoModels[0];
            }
            return null;
        }

        /// <summary>
        /// 设置控件数据
        /// </summary>
        private void SetControlValue(MemberInfoModel memberInfoModel)
        {
            if (memberInfoModel == null) return;
            List<CardTypeInfoModel> cardTypeInfoModels =
                cardTypeInfoManager.GetModelList("CardTypeName='" + memberInfoModel.CardType + "'");
            if (cardTypeInfoModels != null && cardTypeInfoModels.Count > 0)
            {

                this.cmb_CardType.Items.Add(memberInfoModel.CardType);
                this.cmb_CardType.SelectedItem = memberInfoModel.CardType;
                this.txt_Name.Text = memberInfoModel.Name;
                if (backCardType == BackCardType.HasCard)
                {
                    this.cmb_IDType.Items.Add(memberInfoModel.IDCardType);
                    this.cmb_IDType.SelectedItem = memberInfoModel.IDCardType;
                    this.txt_IDCard.Text = memberInfoModel.IDCard;
                }
                else if(backCardType==BackCardType.NoCard)
                {
                    this.txt_CardNumber.Text = memberInfoModel.CardID;
                    this.cmb_CardType.Items.Add(memberInfoModel.CardType);
                    this.cmb_CardType.SelectedItem = memberInfoModel.CardType;
                }
                this.txt_Phone.Text = memberInfoModel.Phone;
                this.dtp_AddTime.Text = memberInfoModel.AddTime;
                this.dtp_StartTime.Text = memberInfoModel.StartTime;
                this.dtp_EndTime.Text = memberInfoModel.EndTime;
                if (memberInfoModel.Photo != null && memberInfoModel.Photo.Length > 0)
                {
                    this.pictureBox1.Image = CommTools.ByteToImg(memberInfoModel.Photo);
                }
                if (cardTypeInfoModels[0].TypeName.Equals("计时产品"))
                {
                    this.txt_TotalTimes.Enabled = false;
                    this.txt_LeftTimes.Text = "0";
                    this.txt_LeftTimes.Enabled = false;
                    this.txt_TotalTimes.Text = "0";
                    // 计算剩余天数
                    DateTime startTime=DateTime.Parse(memberInfoModel.StartTime);
                    DateTime endTime = DateTime.Parse(memberInfoModel.EndTime);
                    TimeSpan totalDate = endTime - startTime;
                    this.txt_TotalDays.Text = Convert.ToString((int)totalDate.TotalDays);
                    TimeSpan leftDate = endTime - DateTime.Now;
                    this.txt_LeftDays.Text = Convert.ToString((int)leftDate.TotalDays);
                    // 计算金额
                    this.txt_PaidAmount.Text = cardTypeInfoModels[0].MonthsPrice;
                    this.txt_ChangeAmount.Text = Convert.ToString(Convert.ToSingle(cardTypeInfoModels[0].MonthsPrice
                                                                      )*(float)(leftDate.TotalDays/totalDate.TotalDays));


                }
                else if (cardTypeInfoModels[0].TypeName.Equals("计次产品"))
                {
                    this.txt_TotalDays.Enabled = false;
                    this.txt_LeftDays.Enabled = false;
                    this.txt_TotalDays.Text = "0";
                    this.txt_LeftDays.Text = "0";
                    this.txt_TotalTimes.Text = cardTypeInfoModels[0].CardCount;
                    this.txt_LeftTimes.Text =
                        Convert.ToString(Convert.ToInt32(cardTypeInfoModels[0].CardCount) -
                                         Convert.ToInt32(memberInfoModel.Count));
                    this.txt_PaidAmount.Text = cardTypeInfoModels[0].MonthsPrice;
                    this.txt_ChangeAmount.Text =
                        Convert.ToString(Convert.ToSingle(cardTypeInfoModels[0].MonthsPrice) *
                                         (double)Convert.ToInt32(this.txt_LeftTimes) / Convert.ToUInt32(this.txt_TotalTimes));

                }
            }
            
            
        }
        /// <summary>
        /// 有卡验证逻辑
        /// </summary>
        private bool ValidateHasCard()
        {
            //卡号验证
            if (!AppConfig.ValidateCardNumber(this.txt_CardNumber.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_CardNumber, AppConfig.CardNumberRegexError);
                return false;
            }
            this.errorProvider1.Clear();
            return true;
        }

        /// <summary>
        /// 无卡逻辑验证
        /// </summary>
        /// <returns></returns>
        private bool ValidateNoCard()
        {
            if (String.IsNullOrEmpty(this.cmb_IDType.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.cmb_IDType, "请选择证件类型");
                return false;
            }
            else
            {
                switch (this.cmb_CardType.Text)
                {
                    case "身份证":
                        if (!AppConfig.ValidateID(this.txt_IDCard.Text))
                        {
                            this.errorProvider1.Clear();
                            this.errorProvider1.SetError(this.txt_IDCard, AppConfig.IDCardNumberRegexError);
                            return false;
                        }
                        break;
                    case "学生证":
                        if (!AppConfig.ValidateStudentCard(this.txt_IDCard.Text))
                        {
                            this.errorProvider1.Clear();
                            this.errorProvider1.SetError(this.txt_IDCard, AppConfig.StudentRegexError);
                            return false;
                        }
                        break;
                    case "教师证":
                        if (!AppConfig.ValidateTeacher(this.txt_IDCard.Text))
                        {
                            this.errorProvider1.Clear();
                            this.errorProvider1.SetError(this.txt_IDCard, AppConfig.TeacherRegexError);
                            return false;
                        }
                        break;
                }
            }
            this.errorProvider1.Clear();
            return true;
        }
        /// <summary>
        /// 数据验证
        /// </summary>
        /// <returns></returns>
        private bool ValidateControl()
        {
            //卡号验证
            if (!AppConfig.ValidateCardNumber(this.txt_CardNumber.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_CardNumber,AppConfig.CardNumberRegexError);
                return false;
            }
            if (String.IsNullOrEmpty(this.cmb_CardType.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.cmb_CardType,"请选择卡类别");
                return false;
            }
            if (!AppConfig.ValidateXingMing(this.txt_Name.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_Name,AppConfig.XingMingError);
                return false;
            }
            if (String.IsNullOrEmpty(this.cmb_IDType.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.cmb_IDType, "请选择证件类型");
                return false;
            }
            else
            {
                switch (this.cmb_CardType.Text)
                {
                    case "身份证":
                        if (!AppConfig.ValidateID(this.txt_IDCard.Text))
                        {
                            this.errorProvider1.Clear();
                            this.errorProvider1.SetError(this.txt_IDCard,AppConfig.IDCardNumberRegexError);
                            return false;
                        }
                        break;
                    case "学生证":
                        if (!AppConfig.ValidateStudentCard(this.txt_IDCard.Text))
                        {
                            this.errorProvider1.Clear();
                            this.errorProvider1.SetError(this.txt_IDCard, AppConfig.StudentRegexError);
                            return false;
                        }
                        break;
                    case "教师证":
                        if (!AppConfig.ValidateTeacher(this.txt_IDCard.Text))
                        {
                            this.errorProvider1.Clear();
                            this.errorProvider1.SetError(this.txt_IDCard, AppConfig.TeacherRegexError);
                            return false;
                        }
                        break;
                }
            }

            if (!AppConfig.ValidateInt(this.txt_TotalDays.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_TotalDays, AppConfig.IntRegexError);
                return false;
            }

            if (!AppConfig.ValidateInt(this.txt_LeftDays.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_LeftDays, AppConfig.IntRegexError);
                return false;
            }

            if (!AppConfig.ValidateInt(this.txt_TotalTimes.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_TotalTimes, AppConfig.IntRegexError);
                return false;
            }
            if (!AppConfig.ValidateInt(this.txt_LeftTimes.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_LeftTimes, AppConfig.IntRegexError);
                return false;
            }
            if (!AppConfig.ValidateAmount(this.txt_ChangeAmount.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_ChangeAmount, AppConfig.AmountRegexError);
                return false;
            }

            if (!AppConfig.ValidateAmount(this.txt_PaidAmount.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_PaidAmount, AppConfig.AmountRegexError);
                return false;
            }
            this.errorProvider1.Clear();
            return true;
        }
        #endregion

        

    }
    public enum BackCardType
    {
        HasCard,
        NoCard
    }
}
