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
using Gymnasium_APP.ReservationFrom;

namespace Gymnasium_APP.SellCard
{
    public partial class RevokeForm : Form
    {
        private int ID = 0;
        string TypeName = "";
        public RevokeForm(string str,string typeName)
        {
            InitializeComponent();
            ID = Convert.ToInt32(str);
            TypeName = typeName;
        }
      
        private void btn_OK_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("您确认操作撤单吗？操作后将不可恢复！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
              if (result == DialogResult.OK)
              {
                  if (txt_password.Text.Trim().Equals(AppConfigTools.GetAppValue("Revoke")))
                  {
                      if (TypeName.Equals("SellCast"))
                      {
                          SellCastManager manager = new SellCastManager();
                          SellCastModel model = new SellCastModel();

                          model = manager.GetModel(Convert.ToInt32(ID));
                          if (model != null)
                          {
                              model.CusState = 1;
                              model.PriceAmount = Convert.ToDecimal("-" + model.PriceAmount.ToString());
                              bool dst = manager.Update(model);
                              MessageBox.Show("撤单：" + (dst == true ? "成功！" : "失败！"));
                              CommTools.AddSystemLog("修改", "撤单" + ID + " " + model.CardID + " " + model.CusNum + " 金额：" + model.PriceAmount+(dst == true ? " 成功！" : " 失败！"));
                              MainForm maif = (MainForm)this.Owner;
                              maif.GetStatisticsCellCastList();
                              this.Close();
                          }
                      }
                      if (TypeName.Equals("Reservation"))
                      {  
                          ReservationInfoManager reservationInfoManager = new ReservationInfoManager();//预定单
                          ReservationInfoModel model = new ReservationInfoModel();
                          model = reservationInfoManager.GetModel(Convert.ToInt32(ID));
                          if (model != null)
                          {
                              model.RState = "2";
                              model.Money = "-" + model.Money;
                              bool dst = reservationInfoManager.Update(model);
                              MessageBox.Show("预订撤单：" + (dst == true ? "成功！" : "失败！"));
                              if (dst)
                              { 
                                  PositionReservationInfoManager positionReservationInfoManager = new PositionReservationInfoManager();
                                  string sql = "delete from PositionReservationInfo where ReservationNum='" + model.ReservationNum.Trim() + "'";
                                  int count = positionReservationInfoManager.ExecuteSql(sql);
                              }
                              CommTools.AddSystemLog("修改", "预订撤单" + ID + " " + model.ReservationNum + " 金额：" + model.Money + (dst == true ? " 成功！" : " 失败！"));
                              ReservationMainForm maif = (ReservationMainForm)this.Owner;
                              maif.GetReservationInfoManagerList();
                              this.Close();
                          }
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
