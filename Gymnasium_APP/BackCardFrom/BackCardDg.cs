using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gymnasium_APP.BackCardFrom
{
    public partial class BackCardDg : Form
    {
        public BackCardDg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HasBackCardFrm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new NoBackCardCastFrm().Show();
        }
    }
}
