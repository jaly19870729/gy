using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Gymnasium_APP.MemberForm;
using Gymnasium_APP.Model;
using Gymnasium_APP.BLL;
using System.IO;
using Gymnasium_APP.SellCardForm;

namespace Gymnasium_APP.ExtensionFrom
{
    public partial class SingleExtensionFrm : Form
    {

        public SingleExtensionFrm()
        {
            InitializeComponent();
        }

        #region 局部变量
        private MemberInfoManager memberInfoManager=new MemberInfoManager();
        private ExtensionCardManager extensionCardManager=new ExtensionCardManager();
        private CardTypeInfoManager cardTypeInfoManager=new CardTypeInfoManager();
        private ExtensionCardInfoManager extensionCardInfoManager=new ExtensionCardInfoManager();
        private int memberId = 0;
        #endregion

        #region 窗体事件

        private void SingleExtensionFrm_Load(object sender, EventArgs e)
        {
            InitForm();
        }
        private void txt_CardNumber_TextChanged(object sender, EventArgs e)
        {
            if (ValidateCtronl())
            {
                CardNumChange();
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

        #region 数据处理
        /// <summary>
        /// 提交数据
        /// </summary>
        private void SubmitData()
        {
            ExtensionCard extensionCard=new ExtensionCard();
            extensionCard.CreateTime = DateTime.Now;
            extensionCard.ExtensionEndTm = this.dtp_ExtensionEndTime.Value;
            extensionCard.ExtensionStartTm = this.dtp_ExtensionStartTime.Value;
            extensionCard.MemberId = memberId;
            int result=extensionCardManager.Add(extensionCard);
            MessageBox.Show("单卡延期卡号：" + this.txt_CardNumber.Text + " 添加" + (result > 0 ? "成功！" : "失败！"));
            CommTools.AddSystemLog("单卡延期卡号", "卡号：" + txt_Name.Text.Trim() + " 添加" + (result > 0 ? "成功！" : "失败！"));
            // 添加记录
            AdddLog(extensionCard);
           this.Close();
        }
        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="extensionCard"></param>
        private void AdddLog(ExtensionCard extensionCard)
        {
            ExtensionCardInfoModel extensionCardInfoModel=new ExtensionCardInfoModel();
            extensionCardInfoModel.CreateTime = extensionCard.CreateTime;
            extensionCardInfoModel.ExtensionEndTm = extensionCard.ExtensionEndTm;
            extensionCardInfoModel.ExtensionStartTm = extensionCard.ExtensionStartTm;
            extensionCardInfoModel.MemberId = extensionCard.MemberId;
            int result=extensionCardInfoManager.Add(extensionCardInfoModel);
            
        }
        /// <summary>
        /// 初始化窗体
        /// </summary>
        private void InitForm()
        {
            List<Control> filterList=new List<Control>();
            filterList.Add(this.txt_CardNumber);
            filterList.Add(this.dtp_ExtensionStartTime);
            filterList.Add(this.dtp_ExtensionEndTime);
            this.linkLabel1.Enabled = false;
            this.linkLabel2.Enabled = false;
            DisableControls(filterList);
            //延期日期可以通过日历选择，只能是当天之后的日期，当天之前的日期不能选择。
            this.dtp_ExtensionStartTime.MinDate = DateTime.Now;
            this.dtp_ExtensionEndTime.MinDate = this.dtp_ExtensionStartTime.Value.AddDays(1);
            GetCardTypeCommBox();
        }
        /// <summary>
        /// 验证窗体输入
        /// </summary>
        /// <returns></returns>
        private bool ValidateCtronl()
        {
            errorProvider1.Clear();
            Regex regex=new Regex("^\\w{8}$");
            bool flag = regex.IsMatch(this.txt_CardNumber.Text);
            if (!flag)
            {
                errorProvider1.SetError(txt_CardNumber, "卡号输入有误,卡号8位!");
              //  MessageBox.Show("卡号输入有误!");
            }
            return flag;
        }

        /// <summary>
        /// 窗体卡号变化
        /// </summary>
        private void CardNumChange()
        { 
            errorProvider1.Clear();
            if (!String.IsNullOrEmpty(this.txt_CardNumber.Text))
            {
                // todo:需要selectOne函数
                List<MemberInfoModel> memberInfoModels =
                    memberInfoManager.GetModelList("CardID='" + this.txt_CardNumber.Text + "'");
                if (memberInfoModels != null && memberInfoModels.Count > 0)
                {
                    MemberInfoModel memberInfoModel = memberInfoModels[0];
                    memberId = memberInfoModel.MemberID;
                    this.cmb_CardType.Items.Add(memberInfoModel.CardType);
                    this.cmb_CardType.SelectedItem = memberInfoModel.CardType;
                    this.txt_Name.Text = memberInfoModel.Name;
                    this.cmb_IDType.SelectedItem = memberInfoModel.IDCardType;
                    this.txt_IDCard.Text = memberInfoModel.IDCard;
                    this.dtp_StartTime.Text = memberInfoModel.StartTime;
                    this.dtp_EndTime.Text = memberInfoModel.EndTime;
                    this.pictureBox1.Image = CommTools.ByteToImg(memberInfoModel.Photo);
                    // 判断是否已经延期
                    List<ExtensionCard> extensionCards =
                        extensionCardManager.GetModelList("MemberId='" + memberInfoModel.MemberID + "'");
                    if (extensionCards != null && extensionCards.Count > 0)
                    {
                        this.dtp_ExtensionStartTime.Value = extensionCards[0].ExtensionStartTm;
                        this.dtp_ExtensionEndTime.Value = extensionCards[0].ExtensionEndTm;
                        this.dtp_ExtensionStartTime.Enabled = false;
                        this.dtp_ExtensionEndTime.MinDate = extensionCards[0].ExtensionStartTm < DateTime.Now
                                                                ? extensionCards[0].ExtensionStartTm
                                                                : DateTime.Now;

                    }
                }
                else
                {
                    errorProvider1.SetError(txt_CardNumber, "没有此卡号信息!");
                }


            }
        }
        private void GetCardTypeCommBox()
        {
            List<CardTypeInfoModel> cardTypeInfoModels = cardTypeInfoManager.GetModelList("1=1");
            foreach (CardTypeInfoModel model in cardTypeInfoModels)
            {
                this.cmb_CardType.Items.Add(model.CardTypeName);
            }
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
