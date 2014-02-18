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
    public partial class AllExtensionFrm : Form
    {

        public AllExtensionFrm()
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

        private void AllExtensionFrm_Load(object sender, EventArgs e)
        {
            InitForm();
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
            List<MemberInfoModel> memberInfoModels = memberInfoManager.GetModelList("1=1");
            if (memberInfoModels != null && memberInfoModels.Count > 0)
            {
                foreach (MemberInfoModel infoModel in memberInfoModels)
                {
                    AddExtension(infoModel);
                }
            }
            MessageBox.Show("全体延期完成!");
            CommTools.AddSystemLog("全体延期", "全体延期完成");
           this.Close();
        }
        /// <summary>
        /// 添加延期数据
        /// </summary>
        private void AddExtension(MemberInfoModel memberInfoModel)
        {
            ExtensionCard extensionCard = new ExtensionCard();
            extensionCard.CreateTime = DateTime.Now;
            extensionCard.ExtensionEndTm = this.dtp_ExtensionEndTime.Value;
            extensionCard.ExtensionStartTm = this.dtp_ExtensionStartTime.Value;
            extensionCard.MemberId = memberInfoModel.MemberID;
            int result = extensionCardManager.Add(extensionCard);
            if (result > 0) AdddLog(extensionCard);
        }
        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="extensionCard"></param>
        private void AdddLog(ExtensionCard extensionCard)
        {
            ExtensionCardInfoModel extensionCardInfoModel = new ExtensionCardInfoModel();
            extensionCardInfoModel.CreateTime = extensionCard.CreateTime;
            extensionCardInfoModel.ExtensionEndTm = extensionCard.ExtensionEndTm;
            extensionCardInfoModel.ExtensionStartTm = extensionCard.ExtensionStartTm;
            extensionCardInfoModel.MemberId = extensionCard.MemberId;
            int result = extensionCardInfoManager.Add(extensionCardInfoModel);

        }
        /// <summary>
        /// 初始化窗体
        /// </summary>
        private void InitForm()
        {
            
            //延期日期可以通过日历选择，只能是当天之后的日期，当天之前的日期不能选择。
            this.dtp_ExtensionStartTime.MinDate = DateTime.Now;
            this.dtp_ExtensionEndTime.MinDate = this.dtp_ExtensionStartTime.Value.AddDays(1);
            
        }

       
        #endregion 

        
        

        

    }
}
