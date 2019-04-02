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
    public partial class loginForm : Form
    {
        MySqlConnection con;
        String sql = "";
        String sqlRefresh;



        public loginForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
          
            regCode regisCode = new regCode();
            regisCode.ShowDialog();

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            String Constring = "SERVER=localhost; USERNAME=root; PASSWORD=; DATABASE=entrance_exam";
            con = new MySqlConnection(Constring);
        }

        private void login()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Complete the form!");
                return;

            }
            else
                sql = "SELECT * FROM admin_user WHERE username=@username AND password =@password";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (dt.Rows.Count > 0)
                { 

                    formAdmin adminForm = new formAdmin();
                    this.Close();
                    adminForm.ShowDialog();
             }
              else
              {
                  txtPassword.Text = string.Empty;
                  MessageBox.Show("Incorrect Password or Username");
                  return;

              }

          }
          catch (MySqlException ex)
          {
              MessageBox.Show("Connection Error!");
          }
  
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
