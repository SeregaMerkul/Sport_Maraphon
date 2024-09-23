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
    public partial class MyResults : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        public int id_runner_test;
        public string email_test;
        public MyResults()
        {
            InitializeComponent();
            email_test = AuthUser.Login;
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogRunner logRunner = new LogRunner();
            logRunner.Show();
        }

        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu(); 
            authMenu.Show();
        }

        private void MyResults_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet3.Results_RU". При необходимости она может быть перемещена или удалена.
            this.results_RUTableAdapter3.Fill(this.dataBase_Sport_MarathonDataSet3.Results_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet27.Results_RU". При необходимости она может быть перемещена или удалена.
            this.results_RUTableAdapter2.Fill(this.kursovayaDataSet27.Results_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet26.Results_RU". При необходимости она может быть перемещена или удалена.
            //this.results_RUTableAdapter1.Fill(this.kursovayaDataSet26.Results_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet25.Results_RU". При необходимости она может быть перемещена или удалена.
           // this.results_RUTableAdapter.Fill(this.kursovayaDataSet25.Results_RU);

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlCommand command = new SqlCommand($"SELECT Id FROM Runners WHERE email = '{email_test}'", con);
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_runner_test = Convert.ToInt32(reader["Id"].ToString());

                    }
                }
            }
            con.Close();
            Get_List();

            label19.Text = AuthUser.Login;

            SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Email = @email", con);
            command1.Parameters.AddWithValue("@email", label19.Text);
            con.Open();
            int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());
            con.Close();

            label18.Text = Balance.ToString();

        }


        void Get_List()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("select * from Results_RU WHERE ID_Бегуна = " + id_runner_test, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Results_RU");
            dataGridView1.DataSource = ds.Tables["Results_RU"];
            con.Close();
        }
    }
}
