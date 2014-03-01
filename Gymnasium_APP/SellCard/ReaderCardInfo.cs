using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.MemberForm;
using Gymnasium_APP.Model;
using Gymnasium_APP.BLL;
using System.IO;
using Gymnasium_APP.SellCardForm;

namespace Gymnasium_APP.SellCard
{
    public partial class ReaderCardInfo : Form
    {
         string FormName = string.Empty;
        private MemberBusinessType memberBusinessType;

        CardTypeInfoManager cardTypeManager = new CardTypeInfoManager();
        MemberInfoManager manager = new MemberInfoManager();
        MemberHistoryInfoManager hisManager = new MemberHistoryInfoManager();
        public string CardID = string.Empty;
        /// <summary>
        /// 设置处理业务逻辑类型
        /// </summary>
        /// <param name="type"></param>
        public void SetBusinessType(MemberBusinessType type)
        {
            this.memberBusinessType = type;
        }
        public ReaderCardInfo()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
            this.Text = "会员信息 — 读取 ";
            label1.Text = "会员信息读取 ";
            LoadFormForSellCard();
        }
        #region 售卡逻辑
        /// <summary>
        /// 初始化售卡
        /// </summary>
        /// <param name="formName"></param>
        private void InitFormForSellCard(String formName)
        {
            this.Text = "会员信息 — 浏览 ";
            FormName = formName;
            if (formName.Equals("READER"))
            {
                this.Text = "会员信息 — 读取 ";
                label1.Text = "会员信息读取 ";
                List<MemberInfoModel> modelList = manager.GetModelList(" CardID='" + CardID + "'");
                if (modelList != null && modelList.Count > 0)
                {

                    MemberInfoModel updateModel = modelList[0];
                    if (updateModel != null)
                    {
                        txt_CardNumber.Text = updateModel.CardID;
                        txt_Count.Text = updateModel.Count;
                        txt_IDCard.Text = updateModel.IDCard;
                        txt_Mail.Text = updateModel.Mail;
                        txt_Name.Text = updateModel.Name;
                        txt_Phone.Text = updateModel.Name;
                        txt_Unit.Text = updateModel.Unit;
                        cmb_CardType.Text = updateModel.CardType;
                        cmb_IDType.Text = updateModel.IDCardType;
                        cmb_Sex.Text = updateModel.Sex;
                        dtp_AddTime.Text = updateModel.AddTime;
                        dtp_Birthday.Text = updateModel.Birthday;
                        dtp_StartTime.Text = updateModel.StartTime;
                        dtp_EndTime.Text = updateModel.EndTime;
                        if (updateModel.Photo != null && updateModel.Photo.Length > 0)
                        {
                            this.pictureBox1.Image = CommTools.ByteToImg(updateModel.Photo);
                        }

                    }
                }
            }
        }
        
        /// <summary>
        /// 加载售卡
        /// </summary>
        private void LoadFormForSellCard()
        {
            List<CardTypeInfoModel> cardTypeInfoList = cardTypeManager.GetModelList(" 1=1");
            if (cardTypeInfoList != null)
            {
                cmb_CardType.DataSource = cardTypeInfoList;
                cmb_CardType.DisplayMember = "CardTypeName";
                cmb_CardType.ValueMember = "CardTypeID";
                cmb_CardType.SelectedIndex = 0;
            }
            cmb_IDType.SelectedIndex = 0;
            cmb_Sex.SelectedIndex = 0;
        }
   
 
        /// <summary>
        /// 售卡卡类型变化
        /// </summary>
        private void CardTypeChangeForSellCard()
        {
            if (cmb_CardType.SelectedValue is Int32)
            {
                CardTypeInfoModel cardtypeModel = cardTypeManager.GetModel(Convert.ToInt32(cmb_CardType.SelectedValue));
                if (cardtypeModel.TypeName.Equals("计时产品"))
                {
                    txt_Count.Enabled = false;
                    dtp_StartTime.Text = DateTime.Now.ToString();
                    dtp_EndTime.Text = DateTime.Now.AddMonths(Convert.ToInt32(cardtypeModel.Months)).ToString();
                }
                if (cardtypeModel.TypeName.Equals("计次产品"))
                {
                    dtp_StartTime.Text = DateTime.Now.ToString();
                    dtp_EndTime.Text = DateTime.Now.AddMonths(Convert.ToInt32(cardtypeModel.Months)).ToString();
                    txt_Count.Text = cardtypeModel.CardCount;
                    txt_Count.Enabled = true;
                }
            }
        }
        #endregion

        

        
        private void AddAndUpdateSellCardForm_Load(object sender, EventArgs e)
        {
            switch (memberBusinessType)
            {
                    case MemberBusinessType.SellCardType:
                   
                    break;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 查看数据
        /// </summary>
        /// <param name="swipingInfoModel"></param>
   
      
        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_CardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (memberBusinessType)
            {
                case MemberBusinessType.SellCardType:
                    CardTypeChangeForSellCard();
                    break;
               

            }
        }
        //定义一个图片对象
        private Image img = null;
        //字节数组
        private byte[] buffer = null;
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdUpload.Filter = "Image Files(*.BMP; *.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            ofdUpload.Title = "请选择一张图片";
            ofdUpload.FileName = "map.";
            if (this.ofdUpload.ShowDialog(this) == DialogResult.OK)
            {
                string old_fileName = this.ofdUpload.FileName;//源文件路径
                img = Image.FromFile(old_fileName);
                Bitmap newPic = new Bitmap(72, 103);//新图片的大小  
                Graphics g = Graphics.FromImage(newPic);

                g.DrawImage(img, 0, 0, newPic.Width, newPic.Height);

                this.pictureBox1.Image = newPic;
                newPic.Save(Application.StartupPath + "\\pic", System.Drawing.Imaging.ImageFormat.Bmp);
                //把文件暂时保存在字节码里
                FileStream fs = new FileStream(Application.StartupPath + "\\pic", FileMode.Open, FileAccess.Read);
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Flush();
                fs.Close();
            }

        }

        private void txt_CardNumber_TextChanged(object sender, EventArgs e)
        {
            CardID = txt_CardNumber.Text.Trim();
            InitFormForSellCard("READER");
        }

       

       
    }
}

