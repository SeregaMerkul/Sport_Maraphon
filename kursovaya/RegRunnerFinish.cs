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
    public partial class RegRunnerFinish : Form
    {

        public int sum = 0;
        public int totalTest = 0;
        public int Id_User_Test = 0;
        public int Id_Marathon_Test;

        public string Name_Test;
        public RegRunnerFinish()
        {
            InitializeComponent();
        }

        private void RegRunnerFinish_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet5.Fonds". При необходимости она может быть перемещена или удалена.
            this.fondsTableAdapter1.Fill(this.dataBase_Sport_MarathonDataSet5.Fonds);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet29.Fonds". При необходимости она может быть перемещена или удалена.
            this.fondsTableAdapter.Fill(this.kursovayaDataSet29.Fonds);
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Email = @email", con);
            command1.Parameters.AddWithValue("@email", AuthUser.Login);
            con.Open();
            int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());
            con.Close();


            if (AuthUser.Finish_Marahon)
            {
                Id_Marathon_Test = 1;
            }
            else
            {
                Id_Marathon_Test = 2;
            }

            label11.Text = Balance.ToString();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            label12.Text = AuthUser.Login;
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

        private void test_Button2_Click(object sender, EventArgs e)
        {
            string userInput = textBox2.Text.ToString();

            if (!Int32.TryParse(userInput, out int value) || value <= 0 || value >= 2147483647)
            {
                MessageBox.Show("Число отрицательное или превышает лимит. Введите другое");
            }
            else
            {

                int Balance = Convert.ToInt32(label11.Text);

                totalTest = Convert.ToInt32(textBox2.Text.ToString());

                if (Balance >= totalTest)
                {

                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");

                    con.Open();
                    SqlCommand commanduser = new SqlCommand($"SELECT Id FROM users WHERE email = '{AuthUser.Login}'", con);
                    {
                        using (SqlDataReader reader = commanduser.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Id_User_Test = Convert.ToInt32(reader["Id"].ToString());

                            }
                        }
                    }
                    con.Close();
                    string query = "SELECT Balance FROM Fonds WHERE Id = @Id";
                    SqlCommand command1 = new SqlCommand(query, con);
                    command1.Parameters.AddWithValue("@Id", comboBox1.SelectedValue);
                    con.Open();

                    int BalanceFond = (int)command1.ExecuteScalar();
                    Console.WriteLine(BalanceFond);

                    con.Close();

                    int TotalBalance = totalTest + BalanceFond;

                    SqlCommand command2 = new SqlCommand("UPDATE Fonds SET Balance = " + TotalBalance + " WHERE Id = @Id", con);
                    command2.Parameters.AddWithValue("@Id", comboBox1.SelectedValue);
                    con.Open();

                    command2.ExecuteNonQuery();

                    con.Close();


                    Balance = Balance - totalTest;

                    con.Open();
                    SqlCommand command3 = new SqlCommand("UPDATE Users SET Balance = " + Balance.ToString() + " WHERE Email = @email", con); ;
                    command3.Parameters.AddWithValue("@email", AuthUser.Login);
                    command3.ExecuteNonQuery();
                    con.Close();

                    SqlCommand cmd = new SqlCommand("SELECT LastName_Runner FROM Runners WHERE Email = @Email", con);
                    cmd.Parameters.AddWithValue("@email", AuthUser.Login);
                    con.Open();

                    Name_Test = (string)cmd.ExecuteScalar();

                    con.Close();



                    con.Open();
                    SqlCommand command4 = new SqlCommand("INSERT INTO Transactions (Name, Email, Id_Fond, Date, Sum, id_user, id_marathon) VALUES (@Name, @Email, @Id_Fond, @Date, @Sum, @Id_User, @Id_Marathon)", con);
                    command4.Parameters.AddWithValue("@Name", Name_Test);
                    command4.Parameters.AddWithValue("@Email", AuthUser.Login);
                    command4.Parameters.AddWithValue("@Id_Fond", comboBox1.SelectedValue);
                    command4.Parameters.AddWithValue("@Date", DateTime.Now);
                    command4.Parameters.AddWithValue("@Sum", textBox2.Text);
                    command4.Parameters.AddWithValue("@Id_User", Id_User_Test);
                    command4.Parameters.AddWithValue("@Id_Marathon", Id_Marathon_Test);
                    command4.ExecuteNonQuery();
                    con.Close();

                    this.Hide();
                    LogRunner logRunner = new LogRunner();
                    logRunner.Show();
                }

                else
                {
                    MessageBox.Show("Недостаточно средств. Пополните баланс");
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBalance addBalance = new AddBalance();
            addBalance.Show();

        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            LogRunner logRunner = new LogRunner();

            this.Hide();
            logRunner.Show();
        }
    }
}
