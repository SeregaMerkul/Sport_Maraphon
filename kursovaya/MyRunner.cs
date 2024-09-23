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
    public partial class MyRunner : Form
    {
        public MyRunner()
        {
            InitializeComponent();
        }

        public string Email_Runner_Test;

        private void MyRunner_Load(object sender, EventArgs e)
        {
            label18.Text = AuthUser.Login;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");

            SqlCommand command2 = new SqlCommand("SELECT Email_Runner FROM Sponsors WHERE Email = @email", con);
            command2.Parameters.AddWithValue("@email", AuthUser.Login);
            con.Open();
            Email_Runner_Test = command2.ExecuteScalar().ToString();
            con.Close();

            con.Open();


            SqlCommand command = new SqlCommand($"SELECT * FROM Runners WHERE email = '{Email_Runner_Test}'", con);
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        label11.Text = reader["Email"].ToString();
                        label2.Text = reader["Name_Runner"].ToString();
                        label6.Text = reader["LastName_Runner"].ToString();
                        label14.Text = reader["Gender"].ToString();
                        label13.Text = reader["Birthday"].ToString();
                        label10.Text = reader["Country"].ToString();
                    }
                }
            }

            con.Close();

        }


        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogSponsor logSponsor = new LogSponsor();
            logSponsor.Show();
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogSponsor logSponsor = new LogSponsor();
            logSponsor.Show();
        }

        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }
    }
}


