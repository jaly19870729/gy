using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.BLL;
using Gymnasium_APP.Model;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Gymnasium_APP.UserInfoForm
{
    public partial class AddUserInfoForm : Form
    {
        public AddUserInfoForm()
        {
            InitializeComponent();
        }
        private RoleManager roleManager = new RoleManager();

        private void AddUserInfoForm_Activated(object sender, EventArgs e)
        {
            txt_UserName.Focus();
            cmb_Sex.SelectedIndex = 0;
            cmb_State.SelectedIndex = 0;
        }

        private void AddUserInfoForm_Load(object sender, EventArgs e)
        {
            txt_UserName.Focus();
            List<RoleModel> roleList = roleManager.GetModelList(" 1=1");
            if (roleList != null)
            {
                cmb_Role.DataSource = roleList;
                cmb_Role.DisplayMember = "RoleName";
                cmb_Role.ValueMember = "RoleId";
            }
        }
        private UserInfoManager userManager = new UserInfoManager();
        private void btn_OK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txt_UserName.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_UserName,"用户名不能为空！");
                return;
            }
            if (userManager.GetModelList(" UserName='" + txt_UserName.Text.Trim() + "'").Count > 0)
            {
                errorProvider1.SetError(txt_UserName,"用户名已存在，请更换！");
                return;
            }
            if (txt_RealName.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_RealName, "真实姓名不能为空！");
                return;
            }
            if (txt_PassWord.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_PassWord, "密码不能为空！");
                return;
            }
            if (txt_PassWord2.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_PassWord2, "密码不能为空！");
                return;
            }
            if (!txt_PassWord.Text.Trim().Equals(txt_PassWord2.Text.Trim()))
            {
                errorProvider1.SetError(txt_PassWord2, "两次输入的密码不一致，请重新输入！");
                txt_PassWord.Text = txt_PassWord2.Text = "";
                return;
            }
            if (cmb_Role.Text.Trim() == "")
            {
                errorProvider1.SetError(cmb_Role, "请选择用户角色！");
                return;
            }
            if (roleManager.GetModelList(" RoleName='" + cmb_Role.Text + "'").Count == 0)
            {
                errorProvider1.SetError(cmb_Role, "角色信息不存在，请确认用户角色！");
                return;
            }
            if (txt_Mac.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Mac, "注册机器Mac不能为空！");
                return;
            }
            UserInfoModel userModel = new UserInfoModel();
            userModel.UserID = userManager.GetMaxId();
            userModel.UserName = txt_UserName.Text.Trim();
            string passMd5_ = FormsAuthentication.HashPasswordForStoringInConfigFile(txt_PassWord.Text.Trim(), "MD5");
            userModel.UserPass = passMd5_;
            userModel.RealName = txt_RealName.Text.Trim();
            userModel.Phone = txt_Phone.Text.Trim();
            userModel.Mail = txt_Mail.Text.Trim();
            userModel.Mac = txt_Mac.Text.Trim();
            userModel.Sex = cmb_Sex.Text.Trim();
            userModel.State =cmb_State.Text.Trim();
            userModel.RoleID = Convert.ToInt32(cmb_Role.SelectedValue);
            userModel.DateTime = CommTools.GetDateFormatStrot2(DateTime.Now);
            int isAdd = userManager.Add(userModel);
            MessageBox.Show("用户：" + txt_UserName.Text.Trim() + " 添加" + (isAdd >0 ? "成功！" : "失败！"));
            CommTools.AddSystemLog("添加", "用户：" + txt_UserName.Text.Trim() + " 添加" + (isAdd > 0 ? "成功！" : "失败！"));
            MainForm mf = (MainForm)this.Owner;
            mf.GetUserInfoDataList();
            this.Close();

        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
