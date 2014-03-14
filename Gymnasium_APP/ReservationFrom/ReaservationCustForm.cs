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
    public partial class ReaservationCustForm : Form
    {
        public ReaservationCustForm()
        {
            InitializeComponent();
        }

        private void txt_PaymentAmount_TextChanged(object sender, EventArgs e)
        {
            double payAmount = 0;
            if (!String.IsNullOrEmpty(this.txt_PaymentAmount.Text) &&
                double.TryParse(this.txt_PaymentAmount.Text, out payAmount))
            {
                this.txt_ChangeAmount.Text =
                    Convert.ToString(Convert.ToDecimal(this.txt_PaymentAmount.Text) - Convert.ToDecimal(this.txt_PriceAmount.Text));
            }
        }

        private void ReaservationCustForm_Load(object sender, EventArgs e)
        {
            cmb_PayType.SelectedIndex = 0;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("消费成功！");
        }
    }
}
