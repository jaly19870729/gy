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

namespace Gymnasium_APP.ReservationFrom
{
    public partial class ReservationMainForm : Form
    {
        public ReservationMainForm()
        {
            InitializeComponent();
            uC_Page_Position.OnPageChanged += new EventHandler(uC_Page_Position_OnPageChanged);
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

        private CunsumeTypeManager cunsumeTypeManager = new CunsumeTypeManager();
        private void ReservationMainForm_Load(object sender, EventArgs e)
        {
            label2.Text= System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            this.dataGridView1.MultiSelect = false;
            
            this.cmb_CunsumeType.DataSource = this.cunsumeTypeManager.GetModelList("1=1");
            this.cmb_CunsumeType.DisplayMember = "CusType";
            this.cmb_CunsumeType.ValueMember = "Id";
            dtp_Statistics_Member_StartTime.MinDate = DateTime.Now;
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
                }
            }
           
        }

        private void dtp_Statistics_Member_StartTime_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(Convert.ToDateTime(dtp_Statistics_Member_StartTime.Text).DayOfWeek);
            cmb_CunsumeType_SelectedIndexChanged(null,null);
        }
        private PositionReservationInfoManager prm = new PositionReservationInfoManager();

        private void cmb_CunsumeType_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void btn_OK_Click(object sender, EventArgs e)
        {
            ReaservationCustForm rcf = new ReaservationCustForm();
            rcf.ShowDialog();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            beforRowIndex =-1;
            dic_collesIndex.Clear();
            txt_CusMoney.Text = "";
            txt_Peoples.Text = "";
            txt_CusNum.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_CusNum.Text = "00001";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        
    }
}
