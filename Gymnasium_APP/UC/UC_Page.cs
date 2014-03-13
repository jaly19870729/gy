using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace Gymnasium_APP.UC
{
    public partial class UC_Page : UserControl
    {

        public event EventHandler OnPageChanged;
         
        public TurnPage tp;
        public UC_Page()
        {
            InitializeComponent();
            tp = new TurnPage();
        }
        public void HuiDiao()
        {
            if (OnPageChanged != null)
            {
                OnPageChanged(this,null);
            }
        }
        public void linkFirst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tp.CurrentPage = tp.FirstPage;
            HuiDiao();
        }

        public void linkBefore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tp.CurrentPage = tp.BeforePage;
            HuiDiao();
        }

        private void UC_Page_Load(object sender, EventArgs e)
        {

        }

        public void linkNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tp.CurrentPage = tp.NextPage;
            HuiDiao();

        }

        public void linkEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tp.CurrentPage = tp.EndPage;
            HuiDiao();
        }

        public void cmb_page_SelectedIndexChanged(object sender, EventArgs e)
        {
            tp.Count = Convert.ToInt32(cmb_page.Text);
            tp.CurrentPage = 1;
            HuiDiao();
        }

        private void cmb_page_TextChanged(object sender, EventArgs e)
        {
            tp.Count = Convert.ToInt32(cmb_page.Text);
            tp.CurrentPage = 1;
            HuiDiao();
        }
    }
}
