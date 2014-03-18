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
using Gymnasium_APP.Config;

namespace Gymnasium_APP.ReservationFrom
{
    public partial class AddAndUpdatePositionForm : Form
    {
        private string TypeName = string.Empty;
        private string ID = "0";
        public AddAndUpdatePositionForm(string typeName,string id)
        {
            InitializeComponent();
            TypeName = typeName;
            ID = id;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (!AppConfig.ValidateName(this.txt_Name.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_Name, AppConfig.ContentError);
                return;
            }
            if (!AppConfig.ValidateAmount(this.txt_Price.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_Price, AppConfig.AmountRegexError);
                return;
            }
            if (!AppConfig.ValidateName(this.cmb_State.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.cmb_State, AppConfig.ContentError);
                return;
            }
            if (TypeName.Equals("ADD"))
            {
                List<PositionInfoModel> modelList = positionInfoManager.GetModelList(" Name='" + txt_Name.Text.Trim() + "' and TypeName='" + cmb_TypeName.Text.Trim() + "'");
                if (modelList.Count > 0)
                {

                    errorProvider1.SetError(txt_Name, "名称已经存在，请更换！");
                    return;

                }
                PositionInfoModel model = new PositionInfoModel();
                model.ID = positionInfoManager.GetMaxId();
                model.Name = txt_Name.Text.Trim();
                model.Price = txt_Price.Text.Trim();
                model.PState = cmb_State.Text.Trim();
                model.TypeName = cmb_TypeName.Text.Trim();
                model.Des = txt_Des.Text.Trim();
                bool isAdd = positionInfoManager.Add(model);
                MessageBox.Show("位置信息：" + txt_Name.Text.Trim() + " 添加" + (isAdd == true ? "成功！" : "失败！"));
                ReservationMainForm rmf = (ReservationMainForm)this.Owner;
                rmf.GetPositionInfoManagerList();
                CommTools.AddSystemLog("添加", "位置信息：" + txt_Name.Text.Trim() + " 添加" + (isAdd == true ? "成功！" : "失败！"));
                this.Close();
            }
            else
            {
                List<PositionInfoModel> modelList = positionInfoManager.GetModelList(" Name='" + txt_Name.Text.Trim() + "' and TypeName='" + cmb_TypeName.Text.Trim() + "' and ID<>"+ID+"");
                if (modelList.Count > 0)
                {

                    errorProvider1.SetError(txt_Name, "名称已经存在，请更换！");
                    return;

                }
                PositionInfoModel model = positionInfoManager.GetModel(Convert.ToInt32(ID));
                if (model != null)
                {
                    model.Name = txt_Name.Text.Trim();
                    model.Price = txt_Price.Text.Trim();
                    model.PState = cmb_State.Text.Trim();
                    model.TypeName = cmb_TypeName.Text.Trim();
                    model.Des = txt_Des.Text.Trim();
                    bool isAdd = positionInfoManager.Update(model);
                    MessageBox.Show("位置信息：" + txt_Name.Text.Trim() + " 修改" + (isAdd == true ? "成功！" : "失败！"));
                    ReservationMainForm rmf = (ReservationMainForm)this.Owner;
                    rmf.GetPositionInfoManagerList();
                    CommTools.AddSystemLog("修改", "位置信息：" + txt_Name.Text.Trim() + " 修改" + (isAdd == true ? "成功！" : "失败！"));
                    this.Close();
                }
            }
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private CunsumeTypeManager cunsumeTypeManager = new CunsumeTypeManager();
        private PositionInfoManager positionInfoManager = new PositionInfoManager();
        private void AddAndUpdatePositionForm_Load(object sender, EventArgs e)
        {
            this.cmb_TypeName.DataSource = this.cunsumeTypeManager.GetModelList("1=1");
            this.cmb_TypeName.DisplayMember = "CusType";
            this.cmb_TypeName.ValueMember = "Id";
            cmb_TypeName.SelectedIndex = 0;
            cmb_State.SelectedIndex = 0;
            if (!TypeName.Equals("ADD"))
            {
                this.Text = "位置信息 — 修改";
                PositionInfoModel model = positionInfoManager.GetModel(Convert.ToInt32(ID));
                if (model != null)
                {
                    txt_Name.Text = model.Name;
                    txt_Price.Text = model.Price;
                    txt_Des.Text = model.Des;
                    cmb_State.Text = model.PState;
                    cmb_TypeName.Text = model.TypeName;
                }

            }
        }
    }
}
