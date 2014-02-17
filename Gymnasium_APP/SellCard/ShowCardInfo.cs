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
    public partial class ShowCardInfo : Form
    {
        string FormName = string.Empty;
        private MemberBusinessType memberBusinessType;

        CardTypeInfoManager cardTypeManager = new CardTypeInfoManager();
        MemberInfoManager manager = new MemberInfoManager();
        MemberHistoryInfoManager hisManager = new MemberHistoryInfoManager();

        /// <summary>
        /// 设置处理业务逻辑类型
        /// </summary>
        /// <param name="type"></param>
        public void SetBusinessType(MemberBusinessType type)
        {
            this.memberBusinessType = type;
        }
        public ShowCardInfo(string formName, MemberBusinessType type)
        {
            this.memberBusinessType = type;
            switch (memberBusinessType)
            {
                    case MemberBusinessType.SellCardType:
                    InitFormForSellCard(formName);
                    break;
                    case MemberBusinessType.ContinuedCardType:
                    InitFormForContinued(formName);
                    break;
            }
            

        }
        #region 售卡逻辑
        /// <summary>
        /// 初始化售卡
        /// </summary>
        /// <param name="formName"></param>
        private void InitFormForSellCard(String formName)
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
            this.Name = "会员信息 — 添加 ";
            FormName = formName;
            if (!formName.Equals("ADD"))
            {
                this.Name = "会员信息 — 修改 ";
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
        /// 提交售卡
        /// </summary>
        private void SubmitForSellCard()
        {
            errorProvider1.Clear();
            if (txt_CardNumber.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_CardNumber, "卡号不能为空！");
                return;
            }
            List<MemberInfoModel> modelList = manager.GetModelList(" CardID='" + txt_CardNumber.Text + "'");
            if (modelList.Count > 0)
            {
                if (txt_CardNumber.Text.Trim() == "")
                {
                    errorProvider1.SetError(txt_CardNumber, "卡号已经存在，请更换！");
                    return;
                }
            }
            if (txt_Mail.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Mail, "邮箱不能为空！");
                return;
            }
            if (cmb_CardType.Text.Trim() == "")
            {
                errorProvider1.SetError(cmb_CardType, "卡类别不能为空！");
                return;
            }

            if (cmb_IDType.Text.Trim() == "")
            {
                errorProvider1.SetError(cmb_IDType, "证件类型不能为空！");
                return;
            }
            if (txt_Name.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Name, "姓名不能为空！");
                return;
            }
            if (txt_IDCard.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_IDCard, "证件号不能为空！");
                return;
            }
            if (cmb_Sex.Text.Trim() == "")
            {
                errorProvider1.SetError(cmb_Sex, "性别不能为空！");
                return;
            }

            if (cmb_CardType.SelectedValue is Int32)
            {
                CardTypeInfoModel cardtypeModel = cardTypeManager.GetModel(Convert.ToInt32(cmb_CardType.SelectedValue));
                if (cardtypeModel.TypeName.Equals("计时产品"))
                {
                    if (dtp_StartTime.Text.Trim() == "")
                    {
                        errorProvider1.SetError(dtp_StartTime, "生效日期不能为空！");
                        return;
                    }

                    if (dtp_EndTime.Text.Trim() == "")
                    {
                        errorProvider1.SetError(dtp_EndTime, "失效日期不能为空！");
                        return;
                    }
                }
                if (cardtypeModel.TypeName.Equals("计次产品"))
                {
                    if (txt_Count.Text.Trim() == "")
                    {
                        errorProvider1.SetError(txt_Count, "剩余次数不能为空！");
                        return;
                    }
                }

            }
            if (dtp_Birthday.Text.Trim() == "")
            {
                errorProvider1.SetError(dtp_Birthday, "生日不能为空！");
                return;
            }
            if (txt_Phone.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Phone, "电话不能为空！");
                return;
            }
            if (dtp_AddTime.Text.Trim() == "")
            {
                errorProvider1.SetError(dtp_AddTime, "办理日期不能为空！");
                return;
            }
            //添加
            if (FormName.Equals("ADD") || FormName.Equals("CONTINUED"))
            {
                MemberInfoModel model = new MemberInfoModel();
                model.MemberID = manager.GetMaxId();
                model.CardID = txt_CardNumber.Text.Trim();
                model.Mail = txt_Mail.Text.Trim();
                model.CardType = cmb_CardType.Text.Trim();
                model.IDCardType = cmb_IDType.Text.Trim();
                model.Name = txt_Name.Text.Trim();
                model.IDCard = txt_IDCard.Text.Trim();
                model.Sex = cmb_Sex.Text.Trim();
                model.StartTime = CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_StartTime.Text.Trim()));
                model.Birthday = CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Birthday.Text.Trim()));
                model.EndTime = CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_EndTime.Text.Trim()));
                model.Phone = txt_Phone.Text.Trim();
                model.Count = txt_Count.Text.Trim();
                model.Unit = txt_Unit.Text.Trim();
                model.AddTime = CommTools.GetDateFormatStrot2(DateTime.Now);
                if (buffer != null || this.pictureBox1.Image!=null)
                {
                    Image image = this.pictureBox1.Image;
                    model.Photo = CommTools.GetByteFromImage(this.pictureBox1);
                }
                model.InfoType = "正常";
                MainForm mf = (MainForm)this.Owner;
                model.AddUserName = mf.lbl_login_name.Text.Trim().Split(':')[1];
                int isAdd = 0;
                switch (memberBusinessType)
                {
                        case MemberBusinessType.SellCardType:
                         isAdd= manager.Add(model);
                MessageBox.Show("会员：" + txt_Name.Text.Trim() + " 添加" + (isAdd > 0 ? "成功！" : "失败！"));
                CommTools.AddSystemLog("添加", "会员：" + txt_Name.Text.Trim() + " 添加" + (isAdd > 0 ? "成功！" : "失败！"));
                        break;
                        case MemberBusinessType.ContinuedCardType:
                        List<MemberInfoModel> memberInfoModels = manager.GetModelList("CardID='" + model.CardID + "'");
                        if (memberInfoModels != null && memberInfoModels.Count > 0)
                        {
                            model.MemberID = memberInfoModels[0].MemberID;
                            bool isFlag = manager.Update(model);
                            if (isFlag) isAdd = 1;
                            MessageBox.Show("会员：" + txt_Name.Text.Trim() + " 续卡" + (isAdd > 0 ? "成功！" : "失败！"));
                            CommTools.AddSystemLog("续卡", "会员：" + txt_Name.Text.Trim() + " 续卡" + (isAdd > 0 ? "成功！" : "失败！"));
                        }
                       
                        break;
                }
                
                //添加历史记录
                MemberHistoryInfoModel hisModel = new MemberHistoryInfoModel();
                hisModel.MemberID = manager.GetMaxId();
                hisModel.CardID = txt_CardNumber.Text.Trim();
                hisModel.Mail = txt_Mail.Text.Trim();
                hisModel.CardType = cmb_CardType.Text.Trim();
                hisModel.IDCardType = cmb_IDType.Text.Trim();
                hisModel.Name = txt_Name.Text.Trim();
                hisModel.IDCard = txt_IDCard.Text.Trim();
                hisModel.Sex = cmb_Sex.Text.Trim();
                hisModel.Photo = model.Photo;
                hisModel.InfoType = model.InfoType;
                hisModel.StartTime = CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_StartTime.Text.Trim()));
                hisModel.Birthday = CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Birthday.Text.Trim()));
                hisModel.EndTime = CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_EndTime.Text.Trim()));
                hisModel.Phone = txt_Phone.Text.Trim();
                hisModel.Count = txt_Count.Text.Trim();
                hisModel.Unit = txt_Unit.Text.Trim();
                hisModel.AddTime = CommTools.GetDateFormatStrot2(DateTime.Now);
                hisModel.AddUserName = mf.lbl_login_name.Text.Trim().Split(':')[1];
                hisModel.InfoType = "添加";
                int isAddHis = hisManager.Add(hisModel);
                this.Close();
                //显示费用
                SellCardCastFrm sellCardCastForm = new SellCardCastFrm(model);
                sellCardCastForm.Owner = this.Owner;
                sellCardCastForm.Show();

            }
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
                    txt_Count.Enabled = true;
                }
            }
        }
        #endregion

        #region 续卡逻辑
        /// <summary>
        /// 初始化续卡
        /// </summary>
        /// <param name="formName"></param>
        private void InitFormForContinued(String formName)
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
            this.Name = "续卡 ";
            this.Text = "续卡";
            this.label1.Text = "续卡";
            FormName = formName;
            
        }
        /// <summary>
        /// 加载续卡
        /// </summary>
        private void LoadFormForContinued()
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

            List<Control> filterList=new List<Control>();
            filterList.Add(this.cmb_CardType);
            filterList.Add(this.txt_CardNumber);
            DisableControls(filterList);

        }
        /// <summary>
        /// 续卡卡号变化
        /// </summary>
        private void CardNumTextChangeForContinued()
        {
            if (!String.IsNullOrEmpty(this.txt_CardNumber.Text))
            {
                List<MemberInfoModel> memberInfoModels =
                    manager.GetModelList("CardID='" + this.txt_CardNumber.Text + "'");
                if (memberInfoModels != null && memberInfoModels.Count > 0)
                {
                    this.cmb_CardType.SelectedText = memberInfoModels[0].CardType;
                    foreach (CardTypeInfoModel item in this.cmb_CardType.Items)
                    {
                        if (item.CardTypeName.Equals(memberInfoModels[0].CardType))
                        {
                            this.cmb_CardType.SelectedItem = item;
                            break;
                        }
                    }
                    this.txt_Name.Text = memberInfoModels[0].Name;
                    this.cmb_Sex.Items.Add(memberInfoModels[0].Sex);
                    this.cmb_Sex.SelectedItem = memberInfoModels[0].Sex;
                    this.dtp_Birthday.Text = memberInfoModels[0].Birthday;
                    this.cmb_IDType.Items.Add(memberInfoModels[0].IDCardType);
                    this.cmb_IDType.SelectedItem = memberInfoModels[0].IDCardType;
                    this.txt_IDCard.Text = memberInfoModels[0].IDCard;
                    this.dtp_StartTime.Text =Convert.ToString(Convert.ToDateTime(memberInfoModels[0].StartTime).AddDays(1));
                    this.txt_Phone.Text = memberInfoModels[0].Phone;
                    this.dtp_EndTime.Text = memberInfoModels[0].EndTime;
                    this.txt_Mail.Text = memberInfoModels[0].Mail;
                    this.txt_Count.Text = memberInfoModels[0].Count;
                    this.txt_Unit.Text = memberInfoModels[0].Unit;
                    this.dtp_AddTime.Text = memberInfoModels[0].AddTime;
                    if (memberInfoModels[0].Photo != null && memberInfoModels[0].Photo.Length > 0)
                    {
                        this.pictureBox1.Image = CommTools.ByteToImg(memberInfoModels[0].Photo);
                    }
                }
            }
        }
        /// <summary>
        /// 卡类别变化
        /// </summary>
        private void CardTypeChangeForContinued()
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
                //todo:次数计算
                if (cardtypeModel.TypeName.Equals("计次产品"))
                {
                    dtp_StartTime.Text = DateTime.Now.ToString();
                    dtp_EndTime.Text = DateTime.Now.AddMonths(Convert.ToInt32(cardtypeModel.Months)).ToString();
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
                    LoadFormForSellCard();
                    break;
                    case MemberBusinessType.ContinuedCardType:
                    LoadFormForContinued();
                    break;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            switch (memberBusinessType)
            {
                    case MemberBusinessType.SellCardType:
                    SubmitForSellCard();
                    break;
                    case MemberBusinessType.ContinuedCardType:
                    SubmitForSellCard();
                    break;
            }
        }
        /// <summary>
        /// 查看数据
        /// </summary>
        /// <param name="swipingInfoModel"></param>
        public void DetialModel(MemberInfoModel memberInfoModel)
        {

            this.dtp_AddTime.Text = memberInfoModel.AddTime;
            List<Control> filter = new List<Control>();
           // filter.Add(this.cardTypeCbx);
            DisableControls(filter);
            //this.addTimeTp.Enabled = false;
            this.txt_Unit.Text = memberInfoModel.Unit;
            //this.addressTxt.Enabled = false;
            this.dtp_Birthday.Text = memberInfoModel.Birthday;
            //this.birthdayDp.Enabled = false;
            this.label1.Text = "查看会员信息";
            this.Text = "查看会员信息";
            this.btn_OK.Visible = false;
            this.btn_Abolish.Text = "关闭";
            this.btn_Abolish.Location = new Point(this.Width / 2 - this.btn_Abolish.Size.Width / 2, this.btn_Abolish.Location.Y);
            this.cmb_CardType.Items.Add(memberInfoModel.CardType);
            this.cmb_CardType.SelectedItem = memberInfoModel.CardType;
            // this.cardTypeCbx.Text = memberInfoModel.CardType;
            //this.cardTypeCbx.Enabled = false;
            this.txt_Mail.Text = memberInfoModel.Mail;
            //this.emailTxt.Enabled = false;
            this.dtp_EndTime.Text = memberInfoModel.EndTime;
            //this.endTimeTp.Enabled = false;
            this.txt_IDCard.Text = memberInfoModel.IDCard;
            // this.idNoTxt.Enabled = false;
            this.cmb_IDType.Text = memberInfoModel.IDCardType;
            //this.idTypeCbx.Enabled = false;
            this.txt_Count.Text = memberInfoModel.Count;
            //this.leftCountTxt.Enabled = false;
            this.txt_CardNumber.Text = memberInfoModel.CardID;
            // this.memberCardNoTxt.Enabled = false;
            this.txt_Name.Text = memberInfoModel.Name;
            //this.memberNameTxt.Enabled = false;
            this.cmb_Sex.Text = memberInfoModel.Sex;

            // this.memberSexCbx.Enabled = false;
            this.txt_Phone.Text = memberInfoModel.Phone;
            // this.phoneTxt.Enabled = false;
            if (memberInfoModel.Photo != null && memberInfoModel.Photo.Length > 0)
            {
                this.pictureBox1.Image = CommTools.ByteToImg(memberInfoModel.Photo);
            }

            // this.pictureBox1.Enabled = false;
            this.dtp_StartTime.Text = memberInfoModel.StartTime;
            // this.startTimeTp.Enabled = false;


        }
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
                case MemberBusinessType.ContinuedCardType:
                    CardTypeChangeForContinued();
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
            switch (memberBusinessType)
            {
                    case MemberBusinessType.ContinuedCardType:
                    CardNumTextChangeForContinued();
                    break;
            }
        }

       
    }
}
