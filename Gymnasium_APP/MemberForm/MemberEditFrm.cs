using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.BLL;
using Gymnasium_APP.Model;
using Gymnasium_APP.SellCardForm;

namespace Gymnasium_APP.MemberForm
{
    public partial class MemberEditFrm : Form
    {
        private MemberBusinessType businessType;
        private MemberInfoManager memberInfoManager=new MemberInfoManager();
        private String formTitle;
        /// <summary>
        /// 设置窗体标题
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(String title)
        {
            if (!String.IsNullOrEmpty(title))
            {
                this.formTitle = title;
                this.Text = title;
                this.bsTitleLb.Text = title;
            }
            
        }
        /// <summary>
        /// 设置处理业务类型
        /// </summary>
        /// <param name="type"></param>
        public void SetBusinessType(MemberBusinessType type)
        {
            this.businessType = type;
        }
        //GymnasiumDbDataContext dataContext = new GymnasiumDbDataContext();
        public MemberEditFrm()
        {
            InitializeComponent();
            
        }

        private void MemberEditFrm_Load(object sender, EventArgs e)
        {
            
            switch (businessType)
            {
                    case MemberBusinessType.SellCardType:
                        SellCardLoadBusiness();
                    break;
                    case MemberBusinessType.ContinuedCardType:
                    ContinuedCardLoadBusiness();
                    break;

            }
            //cardTypeCbx.SelectedIndex = 0;
            //memberSexCbx.SelectedIndex = 0;
            //idTypeCbx.SelectedIndex = 0;
        }
        /// <summary>
        /// 续卡加载逻辑
        /// </summary>
        private void ContinuedCardLoadBusiness()
        {
            //// 设置卡类型
            //foreach (CardTypeInfo cardTypeInfo in dataContext.CardTypeInfo.ToList())
            //{
            //    this.cardTypeCbx.Items.Add(cardTypeInfo.CardTypeName);
            //}
            //this.memberNameTxt.Enabled = false;
            //this.memberSexCbx.Enabled = false;
            //this.birthdayDp.Enabled = false;
            //this.idTypeCbx.Enabled = false;
            //this.idNoTxt.Enabled = false;
            //this.phoneTxt.Enabled = false;
            //this.startTimeTp.Enabled = false;
            //this.endTimeTp.Enabled = false;
            //this.emailTxt.Enabled = false;
            //this.leftCountTxt.Enabled = false;
            //this.addressTxt.Enabled = false;
            //this.addTimeTp.Enabled = false;
        }
        /// <summary>
        /// 售卡逻辑
        /// </summary>
        private void SellCardLoadBusiness()
        {
            //// 设置卡类型
            //foreach (CardTypeInfo cardTypeInfo in dataContext.CardTypeInfo.ToList())
            //{
            //    this.cardTypeCbx.Items.Add(cardTypeInfo.CardTypeName);
            //}
            //// 生效日期当天
            //this.startTimeTp.Value = DateTime.Now;
            //this.startTimeTp.Enabled = false;
            //this.endTimeTp.Enabled = false;
            //this.addTimeTp.Value = DateTime.Now;
            //this.addTimeTp.Enabled = false;

        }
        //todo:修改卡失效时间
        private void cardTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //修改卡失效时间
            String selectedCardType = this.cardTypeCbx.Text;
            if (String.IsNullOrEmpty(selectedCardType))
            {
                MessageBox.Show("请选择卡类型");
                return;
            }

            //CardTypeInfo cardTypeInfo =
            //    dataContext.CardTypeInfo.FirstOrDefault(m => m.CardTypeName.Equals(selectedCardType));
            //if (cardTypeInfo != null)
            //{
            //    this.endTimeTp.Value = DateTime.Now.AddMonths(Convert.ToInt32(cardTypeInfo.Months));
            //}
            //if (cardTypeInfo.TypeName.Equals("计时产品"))
            //{
            //    this.leftCountTxt.Enabled = false;
            //}
            //else
            //{
            //    this.leftCountTxt.Enabled = true;
            //}
        }
        
        /// <summary>
        /// 查看数据
        /// </summary>
        /// <param name="swipingInfoModel"></param>
        public void DetialModel(MemberInfoModel memberInfoModel)
        {

            this.addTimeTp.Text = memberInfoModel.AddTime;
            this.addTimeTp.Enabled = false;
            this.addressTxt.Text = memberInfoModel.Unit;
            this.addressTxt.Enabled = false;
            this.birthdayDp.Text = memberInfoModel.Birthday;
            this.birthdayDp.Enabled = false;
            this.bsTitleLb.Text = "查看会员信息";
            this.btn_OK.Visible = false;
            this.cardTypeCbx.Text = memberInfoModel.CardType;
            this.cardTypeCbx.Enabled = false;
            this.emailTxt.Text = memberInfoModel.Mail;
            this.emailTxt.Enabled = false;
            this.endTimeTp.Text = memberInfoModel.EndTime;
            this.endTimeTp.Enabled = false;
            this.idNoTxt.Text = memberInfoModel.IDCard;
            this.idNoTxt.Enabled = false;
            this.idTypeCbx.Text = memberInfoModel.IDCardType;
            this.idTypeCbx.Enabled = false;
            this.leftCountTxt.Text = memberInfoModel.Count;
            this.leftCountTxt.Enabled = false;
            this.memberCardNoTxt.Text = memberInfoModel.CardID;
            this.memberCardNoTxt.Enabled = false;
            this.memberNameTxt.Text = memberInfoModel.Name;
            this.memberNameTxt.Enabled = false;
            this.memberSexCbx.Text = memberInfoModel.Sex;

            this.memberSexCbx.Enabled = false;
            this.phoneTxt.Text = memberInfoModel.Phone;
            this.phoneTxt.Enabled = false;
            if (memberInfoModel.Photo != null && memberInfoModel.Photo.Length > 0)
            {
                this.pictureBox1.Image = ByteToImg(memberInfoModel.Photo);
            }
            
            this.pictureBox1.Enabled = false;
            this.startTimeTp.Text = memberInfoModel.StartTime;
            this.startTimeTp.Enabled = false;
            

        }
        private void submitBt_Click(object sender, EventArgs e)
        {
            
           // MessageBox.Show("插入成功！");
        }
        private void SellCardSubmit()
        {
        //    // 保存数据
        //    MemberInfo memberInfo=new MemberInfo();
        //    memberInfo.AddTime = this.addTimeTp.Text;
        //    // todo:需要用户session
        //    memberInfo.AddUserName = "admin";
        //    memberInfo.Birthday = this.birthdayDp.Text;
        //    memberInfo.CardID = this.memberCardNoTxt.Text;
        //    memberInfo.CardType = this.cardTypeCbx.Text;
        //    memberInfo.Count = this.leftCountTxt.Text;
        //    memberInfo.EndTime = this.endTimeTp.Text;
        //    memberInfo.IDCard = this.idNoTxt.Text;
        //    memberInfo.IDCardType = this.idTypeCbx.Text;
        //    memberInfo.Mail = this.emailTxt.Text;
        //    memberInfo.Name = this.memberNameTxt.Text;
        //    memberInfo.Phone = this.phoneTxt.Text;
        //    memberInfo.Photo = GetByteFromImage(this.pictureBox1);
        //    memberInfo.Sex = this.memberSexCbx.Text;
        //    memberInfo.StartTime = this.startTimeTp.Text;
        //    memberInfo.Unit = this.addressTxt.Text;
        //    dataContext.MemberInfo.InsertOnSubmit(memberInfo);
            
        //    dataContext.SubmitChanges();

        //    SellCardCastFrm sellCardCastFrm=new SellCardCastFrm();
        //    sellCardCastFrm.SetMemberInfo(memberInfo);
        //    sellCardCastFrm.Owner = this.Owner;
        //    this.Close();
        //    sellCardCastFrm.Show();
        }
        /// <summary>
        /// 图片转化为二进制
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <returns></returns>
        private byte[] GetByteFromImage(PictureBox pictureBox)
        {
            Bitmap bitmap = new Bitmap(this.pictureBox1.Image);
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Jpeg);
            memoryStream.Seek(0, SeekOrigin.Begin);
            byte[] btImage = new byte[memoryStream.Length];
            memoryStream.Read(btImage, 0, btImage.Length);
            memoryStream.Close();
            return btImage;
        }

        /// <summary>
        /// 将byte[]数组转换成Image
        /// </summary>
        /// <param name="btImage">byte[]</param>
        /// <returns>Image img</returns>
        public Image ByteToImg(byte[] btImage)
        {
            MemoryStream memStream = new MemoryStream();
            //Stream memStream = null;
            memStream.Write(btImage, 0, btImage.Length);
            memStream.Position = 0;
            memStream.Seek(0, SeekOrigin.Begin);
            //Bitmap bmp = new Bitmap(memStream, true);
            Image img;
            try
            {
                img = Image.FromStream(memStream, true);
                memStream.Close();
                //img = new Bitmap(memStream);

            }
            catch (Exception ex)
            {
                img = null;
            }
            finally
            {
                //memStream.Close();
            }
            return img;
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memberCardNoTxt_TextChanged(object sender, EventArgs e)
        {
            switch (businessType)
            {
                    case MemberBusinessType.ContinuedCardType:
                    GetContinuedCardData();
                    break;
            }
        }
        /// <summary>
        /// 处理续卡逻辑
        /// </summary>
        private void GetContinuedCardData()
        {
            //if (!String.IsNullOrEmpty(this.memberCardNoTxt.Text))
            //{
            //    MemberInfo memberInfo = dataContext.MemberInfo.SingleOrDefault(m => m.CardID.Equals(this.memberCardNoTxt.Text));
            //    if (memberInfo != null)
            //    {

            //    }
            //}
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            switch (businessType)
            {
                case MemberBusinessType.SellCardType:
                    SellCardSubmit();
                    break;
            }
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
