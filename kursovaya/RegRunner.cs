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
using System.Globalization;

namespace kursovaya
{
    public partial class RegRunner : ShadowedForm
    {
        public static AuthUser CurrentUser;

        public RegRunner()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlConnection con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student307\source\repos\kursovayatest\kursovaya\bin\Debug\kursovaya.mdf;Integrated Security=True;Connect Timeout=30");

        private void RegRunner_Load(object sender, EventArgs e)
        {
            textBoxLogin.Text = "Введите e-mail";
            textBoxLogin.ForeColor = Color.Gray;

            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.Text = "Введите пароль";
            textBoxPassword.ForeColor = Color.Gray;

            textBox1.UseSystemPasswordChar = false;
            textBox1.Text = "Повторите пароль";
            textBox1.ForeColor = Color.Gray;

            textBox2.Text = "Имя";
            textBox2.ForeColor = Color.Gray;

            textBox3.Text = "Фамилия";
            textBox3.ForeColor = Color.Gray;

            comboBox1.Text = "Test";
            comboBox1.ForeColor = Color.Gray;
            

        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
        }

        private void test_Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "test")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                comboBox1.Text = "test";
                comboBox1.ForeColor = Color.Gray;
            }
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Повторите пароль")
            {

                textBox1.Clear();
                textBox1.UseSystemPasswordChar = true;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.UseSystemPasswordChar = false;
                textBox1.Text = "Повторите пароль";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Имя")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Имя";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Фамилия")
            {
                textBox3.Clear();
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "Фамилия";
                textBox3.ForeColor = Color.Gray;
            }
        }



        private void test_Button3_Click(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == textBox1.Text)
            {
                if (IsValidEmail(textBoxLogin.Text))
                {

                    AuthUser.Login = textBoxLogin.Text;



                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                    da = new SqlDataAdapter("select * from Runners", con);
                    ds = new DataSet();

                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Runners (Name_Runner, LastName_Runner, Gender, Birthday, Country, Email) VALUES (@Name_Runner, @LastName_Runner, @Gender, @Birthday, @Country, @Email)", con);
                    command.Parameters.AddWithValue("@Name_Runner", textBox2.Text);
                    command.Parameters.AddWithValue("@LastName_Runner", textBox3.Text);
                    command.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    command.Parameters.AddWithValue("@Birthday", dateTimePicker1.Value.ToString("MM/dd/yyyy"));
                    command.Parameters.AddWithValue("@Country", comboBox2.Text);
                    command.Parameters.AddWithValue("@Email", textBoxLogin.Text);

                    command.ExecuteNonQuery();
                    con.Close();


                    con.Open();
                    SqlCommand cmd = new SqlCommand("AddUserRunner", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name_User", textBox2.Text);
                    cmd.Parameters.AddWithValue("@LastName_User", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxLogin.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@role", "Runner");
                    cmd.ExecuteNonQuery();
                    con.Close();


                    this.Hide();
                    LogRunner logRunner = new LogRunner();
                    logRunner.Show();
                }
                else
                {
                    MessageBox.Show("E-mail введен некорректно");
                }
            }

            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
