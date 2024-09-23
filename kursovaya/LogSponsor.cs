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

namespace kursovaya
{
    public partial class LogSponsor : Form
    {
        public bool Busy_Test;
        public LogSponsor()
        {
            InitializeComponent();
        }

        private void LogSponsor_Load(object sender, EventArgs e)
        {
            label1.Text = AuthUser.Login;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command1 = new SqlCommand("SELECT Busy FROM Sponsors WHERE Email = @email", con);
            command1.Parameters.AddWithValue("@email", AuthUser.Login);
            con.Open();
            Busy_Test = Convert.ToBoolean(command1.ExecuteScalar());
            con.Close();

        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
        }

        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            if (Busy_Test)
            {
                this.Hide();
                MyRunner myRunner = new MyRunner();
                myRunner.Show();
            }
            else
            {
                this.Hide();
                ThanksSponsors thanksSponsors = new ThanksSponsors();
                thanksSponsors.Show();
            }
        }
    }
}
