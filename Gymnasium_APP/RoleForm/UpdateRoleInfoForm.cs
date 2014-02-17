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

namespace Gymnasium_APP.RoleForm
{
    public partial class UpdateRoleInfoForm : Form
    {
        private int roleid;
        public UpdateRoleInfoForm(int roleID)
        {
            InitializeComponent();
            roleid = roleID;
        }
        private RoleManager manager = new RoleManager();
        
        private void UpdateRoleInfoForm_Load(object sender, EventArgs e)
        {
            if (manager.Exists(Convert.ToInt32(roleid)))
            {
                RoleModel model = manager.GetModel(roleid);
                if (model != null)
                {
                    txt_RoleName.Text = model.RoleName;
                    txt_Desc.Text = model.RoleSynopsis;
                }
            }
            else
            {
                MessageBox.Show("       修改信息不存在，请重新选择！      ");
                return;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            if (txt_RoleName.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_RoleName, "请输入角色名称！");
                return;
            }
            errorProvider1.Clear();
            List<RoleModel> roleModel_List = manager.GetModelList(" RoleName='" + txt_RoleName.Text.Trim() + "' and RoleId <> " + roleid + "");
            if (roleModel_List.Count > 0)
            {
                errorProvider1.SetError(txt_RoleName, "角色名称已存在，请更换！");
                return;
            }
            DialogResult result = MessageBox.Show("您确认要修改吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                RoleModel model = new RoleModel();
                model.RoleId = roleid;
                model.RoleName = txt_RoleName.Text.Trim();
                model.RoleSynopsis = txt_Desc.Text.Trim();
                model.DataTime = CommTools.GetDateFormatStrot2(DateTime.Now);
                bool isUpdate = manager.Update(model);
                MessageBox.Show("角色：" + txt_RoleName.Text.Trim() + " 修改" + (isUpdate == true ? "成功！" : "失败！"));
                CommTools.AddSystemLog("修改", "角色：" + txt_RoleName.Text.Trim() + " 修改" + (isUpdate == true ? "成功！" : "失败！"));
                MainForm mf = (MainForm)this.Owner;
                mf.GetRoleManagerList();
                this.Close();
            }
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateRoleInfoForm_Activated(object sender, EventArgs e)
        {

        }
    }
}
