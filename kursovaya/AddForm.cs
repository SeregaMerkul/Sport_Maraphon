using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class AddForm : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(textBoxEmail.Text))
            {
                if (passwordTextBox.Text == passwordTextBox1.Text)
                {
                    if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                    {

                        MessageBox.Show("Введите пароль");

                    }
                    else
                    {
                        con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                        da = new SqlDataAdapter("select * from Users", con);
                        ds = new DataSet();

                        con.Open();
                        cmd = new SqlCommand("INSERT INTO Users (Name_User, LastName_User, Email, Password, Role) VALUES (@Name_User, @LastName_User, @Email, @password, @role)", con);

                        cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@Name_User", textBox2.Text);
                        cmd.Parameters.AddWithValue("@LastName_User", textBox3.Text);
                        cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                        cmd.Parameters.AddWithValue("@Role", comboBox1.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();




                        MessageBox.Show("Пользователь " + textBoxEmail.Text.Trim() + " успешно добавлен");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
            else
            {
                MessageBox.Show("E-mail введен некорректно");
            }
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

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}