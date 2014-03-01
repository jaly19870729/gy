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

namespace Gymnasium_APP.CunsumeFrom
{
    public partial class AddAndUpdateCunsumeTypeForm : Form
    {
        private string TypeName = "ADD";
        private int TypeID = 0;
        public AddAndUpdateCunsumeTypeForm(string typeName,int typeID)
        {
            InitializeComponent();
            TypeName = typeName;
            TypeID = typeID;
        }

        private void AddAndUpdateCunsumeTypeForm_Load(object sender, EventArgs e)
        {
            if (!TypeName.Equals("ADD"))
            {
                this.Text = "消费类型 — 修改 ";
                CunsumeTypeModel model = manager.GetModel(TypeID);
                if (model != null)
                {
                    txt_CardTypeName.Text = model.CusType;
                    txt_DayPrice.Text = model.CusPrice.ToString();
                }

            }
        }

        private void UpdateModel()
        {
            errorProvider1.Clear();
            if (txt_CardTypeName.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_CardTypeName, "请输入产品名称！");
                return;
            }
            if (manager.GetModelList(" CusType='" + txt_CardTypeName.Text.Trim() + "' and Id <> "+TypeID+"").Count > 0)
            {
                errorProvider1.SetError(txt_CardTypeName, "名称已存在，请更换！");
                return;
            }
            try
            {
                Convert.ToInt32(txt_DayPrice.Text.Trim());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_DayPrice, "价格输入错误，请重新输入！");
                return;
            }
            if (txt_DayPrice.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_DayPrice, "请输入价格！");
                return;
            }
            CunsumeTypeModel model = manager.GetModel(TypeID);
            if (model != null)
            {
                model.CusType = txt_CardTypeName.Text.Trim();
                model.CusPrice = Convert.ToDecimal(txt_DayPrice.Text.Trim());
                model.CreateTime = Convert.ToDateTime(CommTools.GetDateFormatStrot2(DateTime.Now));
                bool isAdd = manager.Update(model);
                MessageBox.Show("消费类型：" + txt_CardTypeName.Text.Trim() + " 修改" + (isAdd == true ? "成功！" : "失败！"));
                CommTools.AddSystemLog("修改",
                                       "消费类型：" + txt_CardTypeName.Text.Trim() + " 修改" + (isAdd == true ? "成功！" : "失败！"));
                MainForm mf = (MainForm) this.Owner;
                mf.GetCunsumeTypeDataList();
                this.Close();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (TypeName.Equals("ADD"))
            {
                AddModel();

            }
            else
            {
                UpdateModel();

            }

        }
        private CunsumeTypeManager manager = new CunsumeTypeManager();
        private void AddModel()
        {
            errorProvider1.Clear();
            if (txt_CardTypeName.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_CardTypeName, "请输入产品名称！");
                return;
            }
            if (manager.GetModelList(" CusType='" + txt_CardTypeName.Text.Trim() + "'").Count > 0)
            {
                errorProvider1.SetError(txt_CardTypeName, "名称已存在，请更换！");
                return;
            }
            try
            {
                Convert.ToInt32(txt_DayPrice.Text.Trim());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_DayPrice, "价格输入错误，请重新输入！");
                return;
            }
            if (txt_DayPrice.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_DayPrice, "请输入价格！");
                return;
            }
            CunsumeTypeModel model = new CunsumeTypeModel();
            model.Id = manager.GetMaxId();
            model.CusType = txt_CardTypeName.Text.Trim();
            model.CusPrice = Convert.ToDecimal(txt_DayPrice.Text.Trim());
            model.CreateTime = Convert.ToDateTime(CommTools.GetDateFormatStrot2(DateTime.Now));
            int isAdd = manager.Add(model);
            MessageBox.Show("消费类型：" + txt_CardTypeName.Text.Trim() + " 添加" + (isAdd > 0 ? "成功！" : "失败！"));
            CommTools.AddSystemLog("添加", "消费类型：" + txt_CardTypeName.Text.Trim() + " 添加" + (isAdd > 0 ? "成功！" : "失败！"));
            MainForm mf = (MainForm)this.Owner;
            mf.GetCunsumeTypeDataList();
            this.Close();
        }

        private void btn_Abolish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
