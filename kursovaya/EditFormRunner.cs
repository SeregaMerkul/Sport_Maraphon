using kursovaya.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kursovaya
{
    
    public partial class EditFormRunner : Form
    {

        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlConnection con;

        public EditFormRunner()
        {
            InitializeComponent();
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            LogRunner logRunner = new LogRunner();
            this.Hide();
            logRunner.Show();
        }

        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            LogRunner logRunner = new LogRunner();
            this.Hide();
            logRunner.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == passwordTextBox1.Text)
            {


                string updateQuery = "UPDATE Runners SET name_runner = @name, Gender = @gender, Birthday = @birthday, country = @country, lastname_runner = @lastname WHERE email = @email";
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@name", textBox2.Text);
                    command.Parameters.AddWithValue("@lastname", textBox3.Text);
                    command.Parameters.AddWithValue("@email", AuthUser.Login);
                    command.Parameters.AddWithValue("@gender", comboBox1.Text);
                    command.Parameters.AddWithValue("@country", comboBox2.Text);
                    command.Parameters.AddWithValue("@birthday", dateTimePicker1.Value.ToString("MM/dd/yyyy"));

                    command.ExecuteNonQuery();
                    connection.Close();

                    
                }
                string updatePass = "UPDATE Users SET password = @password WHERE email = @email";

                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(updatePass, connection);
                    command1.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    command1.Parameters.AddWithValue("@email", AuthUser.Login);

                    command1.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Профиль обновлён");
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }

        public string genderTest;
        public string countryTest;

        private void EditFormRunner_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT Name_Runner, LastName_Runner, Gender, Birthday, Country FROM Runners WHERE Email = @email", con);
            cmd.Parameters.AddWithValue("@email", AuthUser.Login);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader["Name_Runner"].ToString();
                textBox3.Text = reader["LastName_Runner"].ToString();
                genderTest = reader["Gender"].ToString();
                countryTest = reader["Country"].ToString();
            }

            int index = comboBox1.FindString(genderTest);
            int index_country = comboBox2.FindString(countryTest);

            if (index >= 0)
            {
                comboBox1.SelectedIndex = index;
            }
            if (index_country >= 0)
            {
                comboBox2.SelectedIndex = index_country;
            }
            con.Close();


            
          
            SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Email = @email", con);
            command1.Parameters.AddWithValue("@email", AuthUser.Login);
            con.Open();
            int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());

            con.Close();


            label11.Text = AuthUser.Login;
            label18.Text = AuthUser.Login;
            label17.Text = Balance.ToString();



        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
