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
    public partial class examCode : Form
    {
        public examCode()
        {
            InitializeComponent();
        }

        private void codeProc_Click(object sender, EventArgs e)
        {
            examForm examform = new examForm();
            this.Close();
            examform.ShowDialog();
        }
    }
}
