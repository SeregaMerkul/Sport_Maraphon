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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kursovaya
{
    public partial class EditForm : Form
    {
        private int userId;
        public string EmailTest;
        public string PassTest;


        public string name { get; set; }

        public string lastname { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        public EditForm( string name, string lastname, string email, string password, string role)
        {
            InitializeComponent();

            Console.WriteLine(email);

            label11.Text = email;
            textBox2.Text = name;
            textBox3.Text = lastname;
            comboBox1.Text = role;
            EmailTest = email;
            PassTest = password;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {



            Console.WriteLine(EmailTest);

            
        }
        


        private void saveButton_Click(object sender, EventArgs e)
        {



            if (passwordTextBox.Text == passwordTextBox1.Text)
                {
                    if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                    {
                        passwordTextBox.Text = PassTest;
                        passwordTextBox1.Text = PassTest;
                    string updateQuery = "UPDATE Users SET password = @password, name_user = @name, lastname_user = @lastname, role = @role WHERE email = @email";
                    SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@password", passwordTextBox.Text);
                        command.Parameters.AddWithValue("@name", textBox2.Text);
                        command.Parameters.AddWithValue("@lastname", textBox3.Text);
                        command.Parameters.AddWithValue("@email", EmailTest);
                        command.Parameters.AddWithValue("@role", comboBox1.Text);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }


                    

                    MessageBox.Show(EmailTest.Trim() + " успешно обновлен");

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                    else
                    {
                        string updateQuery = "UPDATE Users SET password = @password, name_user = @name, lastname_user = @lastname, role = @role WHERE email = @email";
                        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(updateQuery, connection);
                            command.Parameters.AddWithValue("@password", passwordTextBox.Text);
                            command.Parameters.AddWithValue("@name", textBox2.Text);
                            command.Parameters.AddWithValue("@lastname", textBox3.Text);
                            command.Parameters.AddWithValue("@email", EmailTest);
                            command.Parameters.AddWithValue("@role", comboBox1.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        MessageBox.Show(EmailTest.Trim() + " успешно обновлен");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }




            }


        private void textBoxPassword_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            
        }
    }
}
