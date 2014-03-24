using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.ReportFrom;
using System.Drawing.Printing;
using Gymnasium_APP.BLL;

namespace Gymnasium_APP
{
    public partial class PrintForm : Form
    {
        public PrintForm(string cumNum,string itemName, string itemSum, string itemPrice, string itemMoney, string itemPeoples, string sum, string payMoney, string changPrice,string payType)
        {
            string sizeForm=AppConfigTools.GetAppValue("PrintFontSize").Trim();
            if ( sizeForm!= "")
            {
                string[] sizeForms=sizeForm.Split(',');
                if (sizeForms.Length == 2)
                {
                    this.Size = new Size(Convert.ToInt32(sizeForms[0]), Convert.ToInt32(sizeForms[1]));
                }
            }
            this.Hide();
            InitializeComponent();
            lbl_Title.Text = MainForm.PrintTitle;
            lbl_Phone.Text = "电话：" + MainForm.PrintPhone;
            lbl_DateTime.Text = "日期："+DateTime.Now.ToShortDateString();
            lbl_Address.Text = "地址:"+MainForm.PrintAddress;
            lbl_End.Text = MainForm.PrintEnd;
            lbl_ItemName.Text = itemName;
            lbl_item_Sum.Text = itemSum;
            lbl_ItemMoney.Text = itemMoney;
            lbl_ItemPrice.Text = itemPrice;
            lbl_Peoples.Text = "人数："+itemPeoples;
            lbl_Sum.Text = "合计："+sum;
            lbl_PayMoney.Text = "付款：" + payType +"   "+ payMoney;
            lbl_ChangPrice.Text = "找零："+changPrice;
            lbl_CusNum.Text = "单号："+cumNum;
            timer1.Enabled = true;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {

        }

        private void PrintForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    PrintDialog MyPrintDg = new PrintDialog();
            //    MyPrintDg.Document = printDocument1;
            //    printDocument1.PrintController = new StandardPrintController();
            //    //if (MyPrintDg.ShowDialog() == DialogResult.OK)
            //    //{
            //        try
            //        {
            //            printDocument1.Print();
                        
            //        }
            //        catch
            //        {   //停止打印
            //            printDocument1.PrintController.OnEndPrint(printDocument1, new System.Drawing.Printing.PrintEventArgs());
            //        }
            //        this.Close();
            //    //}
            //}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Image img = GetFromPicture.GetWindowCapture(this.tableLayoutPanel1.Handle);

            //if (img != null)
            //{
            //    new PictureForm(img,this.Size).Show();
            //   // e.Graphics.DrawImage(img, 5, 5);
            //   //e.Graphics.(img, 5, 5);
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image img = GetFromPicture.GetWindowCapture(this.tableLayoutPanel1.Handle);

            if (img != null)
            {
                new PictureForm(img, this.Size).Show();
                // e.Graphics.DrawImage(img, 5, 5);
                //e.Graphics.(img, 5, 5);
                this.Close(); 

            }
            timer1.Enabled = false;
        }
    }
}
