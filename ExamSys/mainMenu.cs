using MaterialSkin.Controls;
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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }


        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            welcomeDialog welDia = new welcomeDialog();
            welDia.ShowDialog();
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            loginForm loginF = new loginForm();
            loginF.ShowDialog();
        }
    }
}
