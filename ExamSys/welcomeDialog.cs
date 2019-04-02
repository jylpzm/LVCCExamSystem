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
    public partial class welcomeDialog : Form
    {
        public welcomeDialog()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            regCode regForm = new regCode();
            regForm.ShowDialog();
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            examCode examcode = new examCode();
            examcode.ShowDialog();
         
        }
    }
}
