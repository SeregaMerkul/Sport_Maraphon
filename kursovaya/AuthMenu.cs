using kursovaya.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursovaya
{
    public partial class AuthMenu : ShadowedForm
    {
        public static AuthUser CurrentUser;
        public AuthMenu()
        {
            InitializeComponent();

        }

        private void AuthMenu_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = "Введите e-mail";
            textBoxLogin.ForeColor = Color.Gray;

            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.Text = "Введите пароль";
            textBoxPassword.ForeColor = Color.Gray;
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WantRunner wantRunner = new WantRunner();
            wantRunner.Show();
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
        }

        private void test_Button4_Click(object sender, EventArgs e)
        {

            AuthUser.Login = textBoxLogin.Text;




            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");

            string Sql = "Select * from Users where Email='" + textBoxLogin.Text.Trim() + "'" +
                " and Password='" + textBoxPassword.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(Sql, conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            DataTable usersTable = ds.Tables["Users"];
            sda.Fill(dt);

            if (dt.Rows.Count == 1) 
            {
                

                string role = dt.Rows[0]["Role"].ToString();
                AuthUser.Balance = dt.Rows[0]["Balance"].ToString();
                if (role == "Runner")
                {

                    this.Hide();
                    LogRunner logRunner = new LogRunner();
                    logRunner.Show();
                }
                else if (role == "Admin")
                {
                    this.Hide();
                    LogAdmin logAdmin = new LogAdmin();
                    logAdmin.Show();
                }
                else if (role == "Sponsor")
                {
                    this.Hide();
                    LogSponsor logSponsor = new LogSponsor();
                    logSponsor.Show();
                }

                


            }
            else { MessageBox.Show("Введите правильно логин и пароль."); }

            

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Введите e-mail")
            {
                textBoxLogin.Clear();
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                textBoxLogin.Text = "Введите e-mail";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }



        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Введите пароль")
            {
                textBoxPassword.Clear();
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "Введите пароль";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
