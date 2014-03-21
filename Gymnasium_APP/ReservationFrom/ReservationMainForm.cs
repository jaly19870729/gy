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
using Gymnasium_APP.SellCard;

namespace Gymnasium_APP.ReservationFrom
{
    public partial class ReservationMainForm : Form
    {
        public ReservationMainForm()
        {
            InitializeComponent();
            uC_Page_Position.OnPageChanged += new EventHandler(uC_Page_Position_OnPageChanged);
            uC_Page_Reservation_Manager.OnPageChanged += new EventHandler(uC_Page_Reservation_Manager_OnPageChanged);
        }

      
        #region 位置设置
        private string position_TiaoJian = " 1=1";
        private PositionInfoManager positionInfoManager = new PositionInfoManager();

        public void GetPositionInfoManagerList()
        {
            this.dgv_Position_Manager.Rows.Clear();
            uC_Page_Position.tp.DataTotalCount = positionInfoManager.GetRecordCount(position_TiaoJian);
            DataSet ds_RoleManagerList = positionInfoManager.GetList(uC_Page_Position.tp.Count,
                                                             uC_Page_Position.tp.CurrentPage, position_TiaoJian);
            if (ds_RoleManagerList != null && ds_RoleManagerList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_RoleManagerList.Tables[0].Rows.Count; i++)
                {
                    if (ds_RoleManagerList.Tables[0].Rows[i] != null)
                        this.dgv_Position_Manager.Rows.Add();
                    this.dgv_Position_Manager.Rows[i].Cells["dgv_Position_Num"].Value =
                        (uC_Page_Position.tp.CurrentPage * uC_Page_Position.tp.Count) - uC_Page_Position.tp.Count +
                        i + 1; //序号
                    this.dgv_Position_Manager.Rows[i].Cells["dgv_Position_ID"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["ID"].ToString();
                    this.dgv_Position_Manager.Rows[i].Cells["dgv_Position_Name"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["Name"].ToString();
                    this.dgv_Position_Manager.Rows[i].Cells["dgv_Position_TypeName"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["TypeName"].ToString();
                    this.dgv_Position_Manager.Rows[i].Cells["dgv_Position_State"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["PState"].ToString();
                    this.dgv_Position_Manager.Rows[i].Cells["dgv_Position_Des"].Value =
                       ds_RoleManagerList.Tables[0].Rows[i]["Des"].ToString();
                }

            }
            uC_Page_Position.lbl_Count.Text = uC_Page_Position.tp.DataTotalCount.ToString();
            uC_Page_Position.lbl_Page.Text = uC_Page_Position.tp.CurrentPage + "/" +
                                                uC_Page_Position.tp.PageTotalCount + "页";
        }


        void uC_Page_Position_OnPageChanged(object sender, EventArgs e)
        {
            GetPositionInfoManagerList();
        }
        private void btn_Position_Select_Click(object sender, EventArgs e)
        {
            position_TiaoJian = " 1=1";

            if (txt_Position_Name.Text.Trim() != "")
            {

                position_TiaoJian += " and CardID  like '%" + txt_Position_Name.Text.Trim()+"%'";

            }

            if (cmb_Position_Type.Text.Trim() != "" && cmb_Position_Type.Text.Trim() != "全部")
            {
                position_TiaoJian += " and TypeName='" + cmb_Position_Type.Text.Trim() + "'";
            }
            if (cmb_Position_State.Text.Trim() != "" && cmb_Position_State.Text.Trim() != "全部")
            {
                position_TiaoJian += " and PState='" + cmb_Position_State.Text.Trim() + "'";
            }
            uC_Page_Position.tp.CurrentPage = 1;
            GetPositionInfoManagerList();
        }

        private void btn_Position_Add_Click(object sender, EventArgs e)
        {
            AddAndUpdatePositionForm addAndUpdateForm = new AddAndUpdatePositionForm("ADD","0");
            addAndUpdateForm.Owner = this;
            addAndUpdateForm.ShowDialog();
        }

        private void btn_Position_Delete_Click(object sender, EventArgs e)
        {
            string str = this.dgv_Position_Manager.SelectedCells[0].Value.ToString();
            DialogResult result = MessageBox.Show("您确认要删除第" + this.dgv_Position_Manager.SelectedCells[1].Value.ToString() + "条数据吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                try
                {

                    bool isDelete = positionInfoManager.Delete(Convert.ToInt32(str));
                    GetPositionInfoManagerList();
                    MessageBox.Show("      删除数据" + (isDelete == true ? "成功！" : "失败！     "));
                    CommTools.AddSystemLog("删除", "删除位置信息数据" + (isDelete == true ? "成功！" : "失败！"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
        }

        private void btn_Position_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Position_Manager.RowCount > 0)
            {
                string str = this.dgv_Position_Manager.SelectedCells[0].Value.ToString();
                AddAndUpdatePositionForm addAndUpdateForm = new AddAndUpdatePositionForm("UPDATE", str);
                addAndUpdateForm.Owner = this;
                addAndUpdateForm.ShowDialog();
            }
        }
        #endregion


        #region 预订单信息
        private string ReservationInfo_TiaoJian = " 1=1";

        public void GetReservationInfoManagerList()
        {
            this.dgv_Reservation_Manager.Rows.Clear();
            uC_Page_Reservation_Manager.tp.DataTotalCount = reservationInfoManager.GetRecordCount(ReservationInfo_TiaoJian);
            DataSet ds_RoleManagerList = reservationInfoManager.GetList(uC_Page_Reservation_Manager.tp.Count,
                                                             uC_Page_Reservation_Manager.tp.CurrentPage, ReservationInfo_TiaoJian);
            if (ds_RoleManagerList != null && ds_RoleManagerList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_RoleManagerList.Tables[0].Rows.Count; i++)
                {
                    if (ds_RoleManagerList.Tables[0].Rows[i] != null)
                        this.dgv_Reservation_Manager.Rows.Add();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_Num"].Value =
                        (uC_Page_Reservation_Manager.tp.CurrentPage * uC_Page_Reservation_Manager.tp.Count) - uC_Page_Reservation_Manager.tp.Count +
                        i + 1; //序号
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_ID"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["ID"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_ReservationNum"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["ReservationNum"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_Position"].Value =
                       ds_RoleManagerList.Tables[0].Rows[i]["Position"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_Times"].Value =
                    ds_RoleManagerList.Tables[0].Rows[i]["Times"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_Money"].Value =
                ds_RoleManagerList.Tables[0].Rows[i]["Money"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_Peoples"].Value =
            ds_RoleManagerList.Tables[0].Rows[i]["Peoples"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_Phone"].Value =
      ds_RoleManagerList.Tables[0].Rows[i]["Phone"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_PayType"].Value =
    ds_RoleManagerList.Tables[0].Rows[i]["PayType"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_PriceAmount"].Value =
 ds_RoleManagerList.Tables[0].Rows[i]["PriceAmount"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_PaymentAmount"].Value =
ds_RoleManagerList.Tables[0].Rows[i]["PaymentAmount"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_ChangeAmount"].Value =
ds_RoleManagerList.Tables[0].Rows[i]["ChangeAmount"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_AddTime"].Value =
ds_RoleManagerList.Tables[0].Rows[i]["AddTime"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_AddUserName"].Value =
ds_RoleManagerList.Tables[0].Rows[i]["AddUserName"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_Name"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["Name"].ToString();
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_TypeName"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["TypeName"].ToString();
                    string state = "已完成";
                    string sd=ds_RoleManagerList.Tables[0].Rows[i]["RState"].ToString().Trim();
                    switch (sd)
                    {
                        case "0":
                            state = "未完成";
                            break;
                        case "2":
                            state = "已撤单";
                            break;
                    }
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_RState"].Value = state;
                    this.dgv_Reservation_Manager.Rows[i].Cells["dgv_Reservation_Des"].Value =
                       ds_RoleManagerList.Tables[0].Rows[i]["Des"].ToString();
                }

            }
            uC_Page_Reservation_Manager.lbl_Count.Text = uC_Page_Reservation_Manager.tp.DataTotalCount.ToString();
            uC_Page_Reservation_Manager.lbl_Page.Text = uC_Page_Reservation_Manager.tp.CurrentPage + "/" +
                                                uC_Page_Reservation_Manager.tp.PageTotalCount + "页";
        }
        void uC_Page_Reservation_Manager_OnPageChanged(object sender, EventArgs e)
        {
            GetReservationInfoManagerList();
        }
        private void btn_Reservation_Select_Click(object sender, EventArgs e)
        {
            if (dtp_Reservation_StartTime.Value > dtp_Reservation_EndTime.Value)
            {
                MessageBox.Show("起始时间不得大于截止时间！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtp_Reservation_EndTime.Value < dtp_Reservation_StartTime.Value)
            {
                MessageBox.Show("截止时间不得小于起始时间！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ReservationInfo_TiaoJian = " 1=1";
            if (txt_Reservation_ReservationNum.Text.Trim() != "")
            {
                ReservationInfo_TiaoJian += " and (ReservationNum  like '%" + txt_Reservation_ReservationNum.Text.Trim() + "%')";
            }
            if (cmb_ReservationType.Text.Trim() != "" && cmb_ReservationType.Text.Trim() != "全部")
            {
                ReservationInfo_TiaoJian += " and TypeName='" + cmb_ReservationType.Text.Trim() + "'";
            }
            if (cmb_Reservation_PayType.Text.Trim() != "" && cmb_Reservation_PayType.Text.Trim() != "全部")
            {
                ReservationInfo_TiaoJian += " and PayType='" + cmb_Reservation_PayType.Text.Trim() + "'";
            }
            if (cmb_Reservation_State.Text.Trim() != "" && cmb_Reservation_State.Text.Trim() != "全部")
            {
                string state = "1";
                switch (cmb_Reservation_State.Text.Trim())
                { 
                         
                    case "未完成":
                        state = "0";
                        break;
                    case "已撤单":
                        state = "2";
                        break;
                }
                ReservationInfo_TiaoJian += " and RState='" + state + "'";
            }
            ReservationInfo_TiaoJian += " and (AddTime > '" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Reservation_StartTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "' and  AddTime<'" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Reservation_EndTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "')";
            uC_Page_Reservation_Manager.tp.CurrentPage = 1;
            GetReservationInfoManagerList();
        }

        #endregion
        private CunsumeTypeManager cunsumeTypeManager = new CunsumeTypeManager();
        private void ReservationMainForm_Load(object sender, EventArgs e)
        {
            label2.Text= System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            this.dataGridView1.MultiSelect = false;
            List<CunsumeTypeModel> ctmList = this.cunsumeTypeManager.GetModelList("1=1");
            if (ctmList != null && ctmList.Count > 0)
            {
                this.cmb_CunsumeType.DataSource = ctmList;
                this.cmb_CunsumeType.DisplayMember = "CusType";
                this.cmb_CunsumeType.ValueMember = "Id";
                //dtp_Statistics_Member_StartTime.MinDate = DateTime.Now;

                CunsumeTypeModel model = new CunsumeTypeModel();
                model.CusType = "全部";
                model.Id = 0;
                ctmList.Add(model);
                cmb_ReservationType.DataSource = ctmList;
                this.cmb_ReservationType.DisplayMember = "CusType";
                this.cmb_ReservationType.ValueMember = "Id";
                cmb_ReservationType.SelectedIndex = ctmList.Count-1;
            }
            cmb_Reservation_PayType.SelectedIndex = 0;
            cmb_Reservation_State.SelectedIndex = 0;
            //DataGridViewTextBoxColumn acCode0 = new DataGridViewTextBoxColumn();
            //acCode0.HeaderText = " ";
            //acCode0.Frozen = true;
            ////acCode0.Width = 80;
            //dataGridView1.Columns.Add(acCode0);
            //for (int i = 9; i < 24; i++)
            //{
            //    DataGridViewTextBoxColumn acCode = new DataGridViewTextBoxColumn();
            //    acCode.HeaderText = i.ToString();
            //    acCode.Width = 42;
            //    dataGridView1.Columns.Add(acCode);
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    int index = this.dataGridView1.Rows.Add();
            //    this.dataGridView1.Rows[index].Height = 35;
            //    this.dataGridView1.Rows[index].DefaultCellStyle.Font = new Font("宋体", 12, FontStyle.Bold);
            //    this.dataGridView1.Rows[index].Cells[0].Value = "场地" + i;
            //}
            //this.dataGridView1.Rows[0].Selected = false;
        }
        private int beforRowIndex = -2;
        private Dictionary<string, Dictionary<string, string>> dic_collesIndex = new Dictionary<string, Dictionary<string, string>>();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1||e.ColumnIndex==0)
            {
                return;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Red;
                return;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.SteelBlue)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.SteelBlue;
                return;
            }
            if (beforRowIndex == -2 || beforRowIndex == e.RowIndex)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.BurlyWood;
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.BurlyWood)
                {
                     dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor= Color.White;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                    beforRowIndex = e.RowIndex;
                    if (dic_collesIndex.ContainsKey(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        Dictionary<string, string> dic_clless = dic_collesIndex[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()];
                        if (dic_clless.ContainsKey(e.ColumnIndex.ToString()))
                        {
                            dic_clless.Remove(e.ColumnIndex.ToString());
                        }
                        dic_collesIndex[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()] = dic_clless;
                    }
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.BurlyWood;
                    if (!dic_collesIndex.ContainsKey(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        Dictionary<string, string> dic_clless = new Dictionary<string, string>();
                        dic_clless.Add(e.ColumnIndex.ToString(), e.ColumnIndex.ToString() + "," + e.RowIndex.ToString());
                        dic_collesIndex.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dic_clless);
                    }
                    else
                    {
                        Dictionary<string, string> dic_clless = dic_collesIndex[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()];
                        if (!dic_clless.ContainsKey(e.ColumnIndex.ToString()))
                        {
                            dic_clless.Add(e.ColumnIndex.ToString(), e.ColumnIndex.ToString() + "," + e.RowIndex.ToString());
                        }
                        dic_collesIndex[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()] = dic_clless;
                    }
                    beforRowIndex = e.RowIndex;
                }
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                if (dic_collesIndex.Count > 0)
                {
                    if (dic_collesIndex.ContainsKey(dataGridView1.Rows[beforRowIndex].Cells[0].Value.ToString()))
                    {
                        Dictionary<string, string> dic_clless = dic_collesIndex[dataGridView1.Rows[beforRowIndex].Cells[0].Value.ToString()];
                        foreach (var item in dic_clless)
                        {
                            
                            dataGridView1.Rows[beforRowIndex].Cells[Convert.ToInt32(item.Key)].Style.BackColor = Color.White;
                        }
                    }
                }
                dic_collesIndex.Clear();
                beforRowIndex = e.RowIndex;


            }
            if (dic_collesIndex.Count > 0)
            {
                if (dic_collesIndex.ContainsKey(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                {
                    label3.Text = dic_collesIndex[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()].Values.Count.ToString();
                    lbl_place.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    lbl_Times.Text = label3.Text;
                    txt_CusMoney.Text = (Convert.ToInt32(lbl_Times.Text) * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].ToolTipText.Split(',')[2])).ToString();
                    label19.Text = dataGridView1.Rows[e.RowIndex].Cells[0].ToolTipText.Split(',')[2].ToString();
                }
            }
           
        }

        private void dtp_Statistics_Member_StartTime_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(Convert.ToDateTime(dtp_Statistics_Member_StartTime.Text).DayOfWeek);
            cmb_CunsumeType_SelectedIndexChanged(null,null);
        }
        private PositionReservationInfoManager prm = new PositionReservationInfoManager();

        public void cmb_CunsumeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dic_collesIndex.Clear();
            beforRowIndex = -2;
            lbl_CusType.Text = cmb_CunsumeType.Text.Trim();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            DataGridViewTextBoxColumn acCode0 = new DataGridViewTextBoxColumn();
            acCode0.HeaderText = " ";
            acCode0.Frozen = true;
            //acCode0.Width = 80;
            dataGridView1.Columns.Add(acCode0);
            for (int i = 9; i < 24; i++)
            {
                DataGridViewTextBoxColumn acCode = new DataGridViewTextBoxColumn();
                acCode.HeaderText = i.ToString();
                acCode.Width = 42;
                dataGridView1.Columns.Add(acCode);
            }
            List<PositionInfoModel> postList = positionInfoManager.GetModelList(" TypeName='" + cmb_CunsumeType.Text.Trim() + "'");
            if (postList != null && postList.Count > 0)
            {
                for (int i = 0; i < postList.Count; i++)
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Height = 35;
                    this.dataGridView1.Rows[index].DefaultCellStyle.Font = new Font("宋体", 12, FontStyle.Bold);
                    this.dataGridView1.Rows[index].Cells[0].Value = postList[i].Name;
                    this.dataGridView1.Rows[index].Cells[0].ToolTipText = postList[i].PState + "," + postList[i].Des + "," + postList[i].Price;
                }
                this.dataGridView1.Rows[0].Selected = false;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string PositionName = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                string TypeName = cmb_CunsumeType.Text.Trim();
                string DTime = CommTools.GetDateFormatStrot(Convert.ToDateTime(dtp_Statistics_Member_StartTime.Text.Trim()));
                for (int j = 1; j < dataGridView1.Columns.Count; j++)
                {
                    string HTime = (j + 8).ToString();
                    List<PositionReservationInfoModel> prmList = prm.GetModelList(" PositionName='" + PositionName + "' and TypeName='" + TypeName + "' and HTime='" + HTime + "' and DTime='" + DTime + "'");
                    if (prmList != null && prmList.Count > 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        if (!prmList[0].State.Equals("0"))
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.SteelBlue;
                        }
                        dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                        dataGridView1.Rows[i].Cells[j].ToolTipText = prmList[0].Name + "," + prmList[0].Phone + "," + (prmList[0].State.Equals("1")?"已签到":"未签到");
                    }
                }
            }
        }

        public void ClearText()
        {
            beforRowIndex = -2;
            dic_collesIndex.Clear();
            linkLabel1_LinkClicked(null, null);
            lbl_CusType.Text = cmb_CunsumeType.Text.Trim();
            lbl_Times.Text = "0";
            lbl_place.Text = "null";
            txt_CusMoney.Text = "";
            txt_Name.Text = "";
            txt_Peoples.Text = "";
            txt_Phone.Text = "";
            txt_RDesc.Text = "";
        }

        private ReservationInfoManager reservationInfoManager = new ReservationInfoManager();//预定单
        private PositionReservationInfoManager positionReservationInfoManager = new PositionReservationInfoManager();
        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();

            if (!AppConfig.ValidateName(this.txt_CusNum.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_CusNum, AppConfig.ContentError);
                return;
            }
            if (!AppConfig.ValidateAmount(this.txt_CusMoney.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_CusMoney, AppConfig.AmountRegexError);
                return;
            }

            if (!AppConfig.ValidateName(this.txt_Name.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_Name, AppConfig.ContentError);
                return;
            }
            if (!AppConfig.ValidatePhone(this.txt_Phone.Text))
            {
                this.errorProvider1.Clear();
                this.errorProvider1.SetError(this.txt_Phone, AppConfig.PhoneRegexError);
                return;
            }
            ReservationInfoModel reservationInfoModel = new ReservationInfoModel();
            reservationInfoModel.ID = reservationInfoManager.GetMaxId();
            reservationInfoModel.ReservationNum = txt_CusNum.Text.Trim();
            reservationInfoModel.TypeName = lbl_CusType.Text.Trim();
            reservationInfoModel.Position = lbl_place.Text.Trim();
            reservationInfoModel.Times = lbl_Times.Text.Trim();
            reservationInfoModel.Money = txt_CusMoney.Text.Trim();
            reservationInfoModel.Name = txt_Name.Text.Trim();
            reservationInfoModel.Phone = txt_Phone.Text.Trim();
            reservationInfoModel.Des = txt_RDesc.Text.Trim();
            reservationInfoModel.RState = "0";
            reservationInfoModel.Peoples = txt_Peoples.Text.Trim();
            reservationInfoModel.AddTime = CommTools.GetDateFormatStrot2(DateTime.Now);
            reservationInfoModel.AddUserName = MainForm.userName;
            reservationInfoModel.PriceAmount = label19.Text.Trim();
            string desc = reservationInfoModel.Des;
            foreach (var item in dic_collesIndex)
            {
                PositionReservationInfoModel positionReservationInfoModel = new PositionReservationInfoModel();
                Dictionary<string, string> dic_a = item.Value;
                string postionName = item.Key.ToString();
                foreach (var item2 in dic_a)
                {
                    string times = (Convert.ToInt32(item2.Key)+8).ToString();
                    desc += ","+times ;
                    positionReservationInfoModel.ID = positionReservationInfoManager.GetMaxId();
                    positionReservationInfoModel.PositionName = postionName;
                    positionReservationInfoModel.HTime = times;
                    positionReservationInfoModel.Name = txt_Name.Text.Trim();
                    positionReservationInfoModel.Phone = txt_Phone.Text.Trim();
                    positionReservationInfoModel.State = "0";
                    positionReservationInfoModel.ReservationNum = txt_CusNum.Text.Trim();
                    positionReservationInfoModel.TypeName = lbl_CusType.Text.Trim();
                    positionReservationInfoModel.DTime = CommTools.GetDateFormatStrot(Convert.ToDateTime(dtp_Statistics_Member_StartTime.Text.Trim()));
                    positionReservationInfoManager.Add(positionReservationInfoModel);
                }
            }
            reservationInfoModel.Des = desc;
            bool isadd= reservationInfoManager.Add(reservationInfoModel);
            if (!isadd)
            {
                return;
            }
            ReaservationCustForm rcf = new ReaservationCustForm(reservationInfoModel);
            rcf.Owner = this;
            rcf.ShowDialog();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_CusNum.Text = "000001";
            List<ReservationInfoModel> reservationInfoModelsList = reservationInfoManager.GetModelList(" 1=1");
            if (reservationInfoModelsList != null && reservationInfoModelsList.Count > 0)
            {
                int d = Convert.ToInt32(reservationInfoModelsList[reservationInfoModelsList.Count-1].ReservationNum) + 1;
                string a = "";
                if (d.ToString().Length < 6)
                {
                    for (int i = 0; i < 6 - d.ToString().Length; i++)
                    {
                        a += "0";
                    }
                }
                txt_CusNum.Text = a + d.ToString();
            }
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dtp_Reservation_StartTime.Text = DateTime.Now.AddDays(-1).ToString();
                GetReservationInfoManagerList();
            }
            if (tabControl1.SelectedIndex == 2)
            {
                List<CunsumeTypeModel> cardTypeInfoList = cunsumeTypeManager.GetModelList(" 1=1");
                if (cardTypeInfoList != null)
                {
                    CunsumeTypeModel model = new CunsumeTypeModel();
                    model.CusType = "全部";
                    model.Id = 0;
                    cardTypeInfoList.Add(model);
                    this.cmb_Position_Type.DataSource = cardTypeInfoList;
                    this.cmb_Position_Type.DisplayMember = "CusType";
                    this.cmb_Position_Type.ValueMember = "Id";
                    cmb_Position_Type.SelectedIndex = cardTypeInfoList.Count-1;
                    GetPositionInfoManagerList();
                }
                cmb_Position_State.SelectedIndex = 0;
            }
        }

        #region 签到
        private void btn_SignIN_Click(object sender, EventArgs e)
        {
            if (txt_CusNum.Text.Trim() != "")
            {
                string sql = "update PositionReservationInfo set State=1 where ReservationNum='"+txt_CusNum.Text.Trim()+"'";
                int count = positionReservationInfoManager.ExecuteSql(sql);
                MessageBox.Show("签到"+(count>0?"成功":"失败"));
                cmb_CunsumeType_SelectedIndexChanged(null,null);
            }
        }
        #endregion

        private void 撤单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = this.dgv_Reservation_Manager.SelectedCells[0].Value.ToString();
            RevokeForm rf = new RevokeForm(str, "Reservation");
            rf.Owner = this;
            rf.ShowDialog();
        }

        private void dgv_Reservation_Manager_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

    }
}
