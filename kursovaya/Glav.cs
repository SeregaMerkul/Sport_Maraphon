using kursovaya;
using kursovaya.Components;
using Microsoft.Office.Interop.Excel;
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
    public partial class Glav : ShadowedForm
    {

        private Timer timer;
        private DateTime startTime;
        private TimeSpan duration;

        public DateTime date_Test;
        public Glav()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WantRunner wantRunner = new WantRunner();
            wantRunner.Show();
        }

        private void test_Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }


        private void Glav_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
           
            SqlCommand command1 = new SqlCommand("SELECT EventDate FROM Marthon WHERE Id = @Id", connection);
            command1.Parameters.AddWithValue("@Id", 2);
            connection.Open();
            date_Test = Convert.ToDateTime(command1.ExecuteScalar());
            connection.Close();


            startTime = date_Test;

            duration = TimeSpan.FromSeconds(1);
            AuthUser.Finish_Marahon = false;
  
            timer.Start();
        }

        private void test_Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoreInfoMenu moreInfoMenu = new MoreInfoMenu();
            moreInfoMenu.Show();
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSponsorReg formSponsorReg = new FormSponsorReg();
            formSponsorReg.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
    
            TimeSpan elapsedTime = DateTime.Now - startTime;


            if (elapsedTime >= duration)
            {
                AuthUser.Finish_Marahon = true;
                timer.Stop(); 

            }

           
            labelTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");

            if (AuthUser.Finish_Marahon)
            {
                labelTime.Visible = false;
                label3.Location = new System.Drawing.Point(248, 674);

                label3.Text = "Марафон завершен! Спасибо за участие!";
            }
        }
    }
}
