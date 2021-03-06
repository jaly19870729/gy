﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Gymnasium_APP.ReportFrom
{
    public partial class PictureForm : Form
    {
        public PictureForm(Image img,object size)
        {
            InitializeComponent();
            if (size != null)
            {
                this.Size = (Size)size;
            }
            if (img != null)
            {
                this.pictureBox1.Image = img;
            }

        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog MyPrintDg = new PrintDialog();
            MyPrintDg.Document = printDocument1;
            if (MyPrintDg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch
                {   //停止打印
                    printDocument1.PrintController.OnEndPrint(printDocument1, new System.Drawing.Printing.PrintEventArgs());
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 20, 20);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
              saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PnG Image|*.png|Wmf  Image|*.wmf";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.FileName = "未命名";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("没有预览图片");
            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {

        }

        private void PictureForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PrintDialog MyPrintDg = new PrintDialog();
                MyPrintDg.Document = printDocument1;
                printDocument1.PrintController = new StandardPrintController();
                try
                {
                    printDocument1.Print();
                }
                catch
                {   //停止打印
                    printDocument1.PrintController.OnEndPrint(printDocument1, new System.Drawing.Printing.PrintEventArgs());
                }

            }
            this.Close();
        }
    }
}
