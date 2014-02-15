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

namespace Gymnasium_APP.SellCard
{
    public partial class AddAndUpdateSellCardForm : Form
    {
        string FormName = string.Empty;
        public AddAndUpdateSellCardForm(string formName)
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
        CardTypeInfoManager cardTypeManager = new CardTypeInfoManager();
        MemberInfoManager manager = new MemberInfoManager();
        MemberHistoryInfoManager hisManager = new MemberHistoryInfoManager();
        private void AddAndUpdateSellCardForm_Load(object sender, EventArgs e)
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

        private void btn_OK_Click(object sender, EventArgs e)
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
            if (FormName.Equals("ADD"))
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
                model.StartTime = CommTools.GetDateFormatStrot(Convert.ToDateTime(dtp_StartTime.Text.Trim()));
                model.Birthday = CommTools.GetDateFormatStrot(Convert.ToDateTime(dtp_Birthday.Text.Trim()));
                model.EndTime = CommTools.GetDateFormatStrot(Convert.ToDateTime(dtp_EndTime.Text.Trim()));
                model.Phone = txt_Phone.Text.Trim();
                model.Count = txt_Count.Text.Trim();
                model.Unit = txt_Unit.Text.Trim();
                model.AddTime = CommTools.GetDateFormatStrot(DateTime.Now);
                if (buffer == null)
                {
                    Image image = this.pictureBox1.Image;
                    model.Photo = CommTools.GetByteFromImage(this.pictureBox1);
                }
                model.InfoType = "正常";
                MainForm mf = (MainForm)this.Owner;
                model.AddUserName = mf.lbl_login_name.Text.Trim().Split(':')[1];
                int isAdd = manager.Add(model);
                MessageBox.Show("会员：" + txt_Name.Text.Trim() + " 添加" + (isAdd >0 ? "成功！" : "失败！"));
                CommTools.AddSystemLog("添加", "会员：" + txt_Name.Text.Trim() + " 添加" + (isAdd >0 ? "成功！" : "失败！"));
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
                hisModel.StartTime = CommTools.GetDateFormatStrot(Convert.ToDateTime(dtp_StartTime.Text.Trim()));
                hisModel.Birthday = CommTools.GetDateFormatStrot(Convert.ToDateTime(dtp_Birthday.Text.Trim()));
                hisModel.EndTime = CommTools.GetDateFormatStrot(Convert.ToDateTime(dtp_EndTime.Text.Trim()));
                hisModel.Phone = txt_Phone.Text.Trim();
                hisModel.Count = txt_Count.Text.Trim();
                hisModel.Unit = txt_Unit.Text.Trim();
                hisModel.AddTime = CommTools.GetDateFormatStrot(DateTime.Now);
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

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_CardType_SelectedIndexChanged(object sender, EventArgs e)
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

       
    }
}
