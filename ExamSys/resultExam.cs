using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSys
{
    public partial class resultExam : Form
    {
        public resultExam()
        {
            InitializeComponent();
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(materialSingleLineTextField1.Text,new Font("Time New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 100));
        }
    }
}
