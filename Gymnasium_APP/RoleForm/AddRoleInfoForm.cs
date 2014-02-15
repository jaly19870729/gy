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
    public partial class AddRoleInfoForm : Form
    {
        public AddRoleInfoForm()
        {
            InitializeComponent();
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private RoleManager roleManager = new RoleManager();
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_RoleName.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_RoleName, "请输入角色名称！");
                return;
            }
            errorProvider1.Clear();
            List<RoleModel> roleModel_List=roleManager.GetModelList(" RoleName='"+txt_RoleName.Text.Trim()+"'");
            if(roleModel_List.Count>0)
            {
                errorProvider1.SetError(txt_RoleName, "角色名称已存在，请更换！");
                return;
            }
            RoleModel model = new RoleModel();
            model.RoleId = roleManager.GetMaxId();
            model.RoleName = txt_RoleName.Text.Trim();
            model.RoleSynopsis = txt_Desc.Text.Trim();
            model.DataTime = CommTools.GetDateFormatStrot(DateTime.Now);
            bool isAdd=roleManager.Add(model);
            MessageBox.Show("角色：" + txt_RoleName.Text.Trim() + " 添加" + (isAdd == true ? "成功！" : "失败！"));
            CommTools.AddSystemLog("添加","角色：" + txt_RoleName.Text.Trim() + " 添加" + (isAdd == true ? "成功！" : "失败！"));
            MainForm mf = (MainForm)this.Owner;
            mf.GetRoleManagerList();
            this.Close();
            
        }
    }
}
