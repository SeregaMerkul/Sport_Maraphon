using kursovaya.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class MySponsor : Form
    {
        public MySponsor()
        {
            InitializeComponent();
        }

        public int Id_Sponsor_Test = 0;
        public int idFond = 0;
        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogRunner logRunner = new LogRunner();
            logRunner.Show();

        }

        private void MySponsor_Load(object sender, EventArgs e)
        {
            label19.Text = AuthUser.Login;



            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Email = @email", con);
            command1.Parameters.AddWithValue("@email", label19.Text);
            con.Open();
            int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());
            con.Close();

            label18.Text = Balance.ToString();


            SqlCommand command2 = new SqlCommand("SELECT Id_Sponsor FROM Runners WHERE Email = @email" , con);
            command2.Parameters.AddWithValue("@email", AuthUser.Login);
            con.Open();
            Id_Sponsor_Test = Convert.ToInt32(command2.ExecuteScalar().ToString());
            con.Close();

            con.Open();


            SqlCommand command = new SqlCommand("SELECT * FROM Sponsors WHERE Id = @id", con);
            command.Parameters.AddWithValue("@id", Id_Sponsor_Test);
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        label11.Text = reader["Email"].ToString().Trim();
                        label2.Text = reader["Name_Company"].ToString().Trim();
                        label6.Text = reader["INN"].ToString().Trim();

                        idFond = Convert.ToInt32(reader["Id_Fond"]);


                    }
                }
            }
            con.Close();


            SqlCommand command3 = new SqlCommand("SELECT Name FROM Fonds WHERE Id = @id", con);
            command3.Parameters.AddWithValue("@id", idFond);
            con.Open();
            label10.Text = command3.ExecuteScalar().ToString();
            con.Close();
        }




        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogRunner logRunner = new LogRunner();
            logRunner.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBalance addBalance = new AddBalance();
            addBalance.Show();
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.Font = new Font(label15.Font, FontStyle.Underline);
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.Font = new Font(label15.Font, FontStyle.Regular);
        }
    }
}
