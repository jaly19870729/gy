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

namespace Gymnasium_APP.LossFrom
{
    public partial class LossCardFrm : Form
    {
      
        public LossCardFrm()
        {
             
             InitializeComponent();
        }
        #region 局部变量
        private MemberInfoManager memberInfoManager=new MemberInfoManager();
        private LossCardManager lossCardManager=new LossCardManager();
        private int memberId=0;
        #endregion

        #region 窗体事件
        private void cmb_IDCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                SetControlValue(GetMemberInfo());
            }
        }

        private void txt_IDNumber_TextChanged(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                SetControlValue(GetMemberInfo());
            }
        }

        private void LossCardFrm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                SubmitData();
            }
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
            Regex regex=new Regex(@"^\w{8}$");
            if (regex.IsMatch(this.txt_PatchCardNumber.Text))
            {
                LossCardModel lossCardModel=new LossCardModel();
                lossCardModel.CreateTime = DateTime.Now;
                lossCardModel.MemberId = memberId;
                lossCardModel.PatchCardNo = this.txt_PatchCardNumber.Text;
                lossCardModel.PatchTime = DateTime.Now;
                int result=lossCardManager.Add(lossCardModel);
                // 日志
                CommTools.AddSystemLog("挂失","挂失补领卡号： "+lossCardModel.PatchCardNo+" "+(result>0?" 成功":"失败"));
                MessageBox.Show("挂失补领卡号： " + lossCardModel.PatchCardNo + " " + (result > 0 ? " 成功" : "失败"));
                //获取更新后信息
                if (result > 0)
                {
                    List<LossCardModel> lossCardModels = lossCardManager.GetModelList("MemberId='" + memberId + "' and PatchCardNo='" + lossCardModel.PatchCardNo + "'");
                    if (lossCardModels != null && lossCardModels.Count > 0)
                    {
                        LossCastFrm lossCastFrm = new LossCastFrm(lossCardModels[0].Id, lossCardModels[0].PatchCardNo);
                        lossCastFrm.Show();
                        this.Close();
                    }
                   
                }
                
                //收费

            }
            else
            {
                MessageBox.Show("卡号输入错误");
            }
        }
        /// <summary>
        /// 窗体初始化
        /// </summary>
        private void Init()
        {
            List<Control> filter=new List<Control>();
            filter.Add(this.cmb_IDCardType);
            filter.Add(this.txt_IDNumber);
            filter.Add(this.dtp_PatchCardTime);
            filter.Add(this.txt_PatchCardNumber);
            DisableControls(filter);
        }
        /// <summary>
        /// 设置窗体控件值
        /// </summary>
        /// <param name="memberInfoModel"></param>
        private void SetControlValue(MemberInfoModel memberInfoModel)
        {
            if (memberInfoModel == null) return;
            
            this.txt_CardNumber.Text = memberInfoModel.CardID;
            this.cmb_CardType.Items.Add(memberInfoModel.CardType);
            this.cmb_CardType.SelectedItem = memberInfoModel.CardType;
            this.txt_Name.Text = memberInfoModel.Name;
            this.cmb_Sex.Items.Add(memberInfoModel.Sex);
            this.cmb_Sex.SelectedItem = memberInfoModel.Sex;
            this.dtp_Birthday.Text = memberInfoModel.Birthday;
            this.dtp_StartTime.Text = memberInfoModel.StartTime;
            this.txt_Phone.Text = memberInfoModel.Phone;
            this.dtp_EndTime.Text = memberInfoModel.EndTime;
            this.txt_Mail.Text = memberInfoModel.Mail;
            this.txt_Count.Text = memberInfoModel.Count;
            this.txt_Unit.Text = memberInfoModel.Unit;
            this.dtp_AddTime.Text = memberInfoModel.AddTime;
            this.memberId = memberInfoModel.MemberID;
            if (memberInfoModel.Photo != null && memberInfoModel.Photo.Length > 0)
            {
                this.pictureBox1.Image = CommTools.ByteToImg(memberInfoModel.Photo);
            }
            
        }
        /// <summary>
        /// 条件变化时获取数据
        /// </summary>
        /// <returns></returns>
        private MemberInfoModel GetMemberInfo()
        {
            List<MemberInfoModel> memberInfoModels = memberInfoManager.GetModelList("IDCardType='" +this.cmb_IDCardType.Text+ "' and  IDCard='"+this.txt_IDNumber.Text+"'");
            if (memberInfoModels != null && memberInfoModels.Count > 0)
            {
                MemberInfoModel memberInfoModel = memberInfoModels[0];
                
                return memberInfoModel;
            }
            else
            {
                MessageBox.Show("未找到此身份信息");
                return null;
            }
            
        }
        /// <summary>
        /// 数据验证
        /// </summary>
        /// <returns></returns>
        private bool ValidateControl()
        {
            String idCardType = this.cmb_IDCardType.Text;
            String idNumber = this.txt_IDNumber.Text;
            if (String.IsNullOrEmpty(idNumber)) return false;
            switch (idCardType)
            {
                case "身份证":
                    Regex regex1=new Regex(@"^[1-9]\d{7}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}$");
                    Regex regex2=new Regex(@"^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{4}$");
                    if (regex1.IsMatch(idNumber) || regex2.IsMatch(idNumber))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case "学生证":
                    // todo:学生证验证
                    break;
                case "教师证":
                    //todo:教师证验证
                    break;
            }
            return true;
        }
        #endregion

        #region 工具方法 
        /// <summary>
        /// 禁用控件
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
