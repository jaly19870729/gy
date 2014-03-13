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

namespace Gymnasium_APP.SellCard
{
    public partial class RevokeForm : Form
    {
        private int ID = 0;
        public RevokeForm(string str)
        {
            InitializeComponent();
            ID = Convert.ToInt32(str);
        }
        private SellCastManager manager = new SellCastManager();
        private SellCastModel model = new SellCastModel();

        private void btn_OK_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("您确认操作撤单吗？操作后将不可恢复！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
              if (result == DialogResult.OK)
              {
                  if (txt_password.Text.Trim().Equals(AppConfigTools.GetAppValue("Revoke")))
                  {
                     
                      model = manager.GetModel(Convert.ToInt32(ID));
                      if (model != null)
                      {
                          model.CusState = 1;
                          bool dst = manager.Update(model);
                          MessageBox.Show("撤单：" + (dst == true ? "成功！" : "失败！"));
                          CommTools.AddSystemLog("修改", "撤单" + ID + " " + model.CardID + " " + model.CusNum + (dst == true ? "成功！" : "失败！"));
                          MainForm maif = (MainForm)this.Owner;
                          maif.GetStatisticsCellCastList();
                          this.Close();
                      }
                  }
                  else
                  {
                      MessageBox.Show("密码输入错误！");
                      return;
                  }
              }
        }
    }
}
