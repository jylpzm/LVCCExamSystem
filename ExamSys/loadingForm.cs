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
    public partial class loadingForm : Form
    {
        public loadingForm()
        {
            InitializeComponent();
        }

        private void loadingForm_Load(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if (panel2.Width == 70)
            {
                bunifuCustomLabel5.Visible = false;
                bunifuCustomLabel6.Visible = true;
            }
            else if (panel2.Width == 130)
            {
                bunifuCustomLabel6.Visible = false;
                bunifuCustomLabel7.Visible = true;
            }
            else if (panel2.Width == 200)
            {
                bunifuCustomLabel7.Visible = false;
                bunifuCustomLabel8.Visible = true;
            }
            else if (panel2.Width == 300)
            {
                bunifuCustomLabel8.Visible = false;
                bunifuCustomLabel9.Visible = true;
            }
            else if (panel2.Width >= 343)
            {
                timer1.Stop();
                this.Hide();
                mainMenu MainMenu = new mainMenu();
                MainMenu.Show();
            }
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
