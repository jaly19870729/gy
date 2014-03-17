using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.BLL;

namespace Gymnasium_APP.ReservationFrom
{
    public partial class ReservationMainForm : Form
    {
        public ReservationMainForm()
        {
            InitializeComponent();
        }
        private CunsumeTypeManager cunsumeTypeManager = new CunsumeTypeManager();
        private void ReservationMainForm_Load(object sender, EventArgs e)
        {
            label2.Text= System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            this.dataGridView1.MultiSelect = false;
            
            this.cmb_CunsumeType.DataSource = this.cunsumeTypeManager.GetModelList("1=1");
            this.cmb_CunsumeType.DisplayMember = "CusType";
            this.cmb_CunsumeType.ValueMember = "Id";
            dtp_Statistics_Member_StartTime.MinDate = DateTime.Now;
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
            for (int i = 0; i < 10; i++)
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Height = 35;
                this.dataGridView1.Rows[index].DefaultCellStyle.Font = new Font("宋体", 12, FontStyle.Bold);
                this.dataGridView1.Rows[index].Cells[0].Value = "场地" + i;
            }
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
            if (beforRowIndex == -2 || beforRowIndex == e.RowIndex)
            {
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.BurlyWood;
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.BurlyWood)
                {
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
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
                    //MessageBox.Show(e.ColumnIndex.ToString() + "," + e.RowIndex.ToString());
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
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
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
                }
            }
           
        }

        private void dtp_Statistics_Member_StartTime_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(Convert.ToDateTime(dtp_Statistics_Member_StartTime.Text).DayOfWeek);
        }

        private void cmb_CunsumeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_CusType.Text = cmb_CunsumeType.Text.Trim();
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
    }
}
