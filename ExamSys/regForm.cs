using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExamSys
{
    public partial class regForm : Form
    {
        MySqlConnection con;
        String sql = "";
        String sqlRefresh;

        public regForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String Constring = "SERVER=localhost; USERNAME=root; PASSWORD=; DATABASE=entrance_exam";
            con = new MySqlConnection(Constring);

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to EXIT?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
               
            }
            else { this.Close(); }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void birthdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = birthdateTimePicker1.Value.ToShortDateString();
        }


        private void ageLabel_Click(object sender, EventArgs e)
        {




        }


       private void Register()
        {

            sql = "INSERT INTO user (name,username,password) " +
                "VALUES (@fname,@username,@password)";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                cmd.Prepare();
                var p = cmd.Parameters;

                p.AddWithValue("@firstname", txtFirstname.Text);
                p.AddWithValue("@midname", txtMidname.Text);
                p.AddWithValue("@lastname", txtLastname.Text);
                p.AddWithValue("@homeadd", txtHome.Text);
                p.AddWithValue("@provadd", txtProv.Text);
                p.AddWithValue("@emailadd", txtEmail.Text);
                p.AddWithValue("@contactnum", txtContact.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Complete Register!");
               

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        } 

        private void regButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Make sure that all information entered is correct, PROCEED?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {

            }
            else { this.Close(); }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
             {
                 foreach (Control control in controls)
                 {
                     if (control is TextBox)
                     {
                         (control as TextBox).Clear();
                     }
                     else
                     {
                         func(control.Controls);

                     };
                 }
             };
            func(Controls);



        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
