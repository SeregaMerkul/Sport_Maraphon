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
    public partial class LogRunner : ShadowedForm
    {
        private AuthUser _user;

        public LogRunner()
        {
            InitializeComponent();
        }

        public bool IsBusy;

        public bool IsAdmin;

        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("SELECT RegMarathon FROM users WHERE Email = @email", con);
            command.Parameters.AddWithValue("@email", label1.Text);
            con.Open();
            string regMarathon1 = command.ExecuteScalar().ToString();
            con.Close();

            if (AuthUser.Finish_Marahon)
            {
                this.Hide();
                RegRunnerFinish regRunnerFinish = new RegRunnerFinish();
                regRunnerFinish.Show();
            }
            else
            {
                if (regMarathon1 == "True")
                {
                    this.Hide();
                    Thanks thanks = new Thanks();
                    thanks.Show();
                }
                else
                {
                    this.Hide();
                    RegMarathon regMarathon = new RegMarathon();
                    regMarathon.Show();
                }
            }
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Underline);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
        }
        private void LogRunner_Load(object sender, EventArgs e)
        {
            label1.Text = AuthUser.Login;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Email = @email", con);
            command1.Parameters.AddWithValue("@email", label1.Text);
            con.Open();
            int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());
            con.Close();

            label2.Text = Balance.ToString();


            SqlCommand command2 = new SqlCommand("SELECT Busy FROM Runners WHERE Email = @email", con);
            command2.Parameters.AddWithValue("@email", AuthUser.Login);
            con.Open();
            IsBusy = Convert.ToBoolean(command2.ExecuteScalar());
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBalance addBalance = new AddBalance();
            addBalance.Show();

        }

        private void test_Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditFormRunner editFormRunner= new EditFormRunner();
            editFormRunner.Show();
        }

        private void test_Button7_Click(object sender, EventArgs e)
        {
           
        }

        private void test_Button4_Click(object sender, EventArgs e)
        {
            if (IsBusy == false)
            {
                IsAdmin = false;
                this.Hide();
                SponsorsForm sponsorsForm = new SponsorsForm(IsAdmin);
                sponsorsForm.Show();
            }
            else
            {
                this.Hide();
                MySponsor mySponsor = new MySponsor();
                mySponsor.Show();
            }
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyResults myResults = new MyResults();
            myResults.Show();
        }
    }
}
