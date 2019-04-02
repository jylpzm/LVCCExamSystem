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
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            gradeForm formGrade = new gradeForm();
            formGrade.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            resultExam resultForm = new resultExam();
            resultForm.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            listForm formList = new listForm();
            formList.ShowDialog();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            questionForm FormQuest = new questionForm();
            FormQuest.Show();
            
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            backupForm formBackup = new backupForm();
            formBackup.ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            examDuration durationForm = new examDuration();
            durationForm.ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            courseForm formCors = new courseForm();
            formCors.ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            admin_acc adminAcc = new admin_acc();
            adminAcc.ShowDialog();
        }
    }
}
