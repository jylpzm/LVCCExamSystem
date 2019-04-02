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
    public partial class regCode : Form
    {
        public static bool disableForm = true;

        public regCode()
        {
            InitializeComponent();
        }

        private void regCode_Load(object sender, EventArgs e)
        {
        
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

          
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
            regForm regF = new regForm();
            this.Close();
            regF.ShowDialog();
        }
    }
}
