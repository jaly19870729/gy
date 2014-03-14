using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gymnasium_APP.ReservationFrom
{
    public partial class ReservationMainForm : Form
    {
        public ReservationMainForm()
        {
            InitializeComponent();
        }

        private void ReservationMainForm_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn acCode0 = new DataGridViewTextBoxColumn();
            acCode0.HeaderText = " ";
            acCode0.Width = 40;
            dataGridView1.Columns.Add(acCode0);
            for (int i = 0; i < 10; i++)
            {
                DataGridViewTextBoxColumn acCode = new DataGridViewTextBoxColumn();
                acCode.HeaderText = "A/C Code";
                dataGridView1.Columns.Add(acCode);
            }
            for (int i = 9; i < 24; i++)
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value =i;
            }
        }
    }
}
