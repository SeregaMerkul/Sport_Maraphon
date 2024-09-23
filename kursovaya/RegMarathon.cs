using kursovaya.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kursovaya
{
    public partial class RegMarathon : ShadowedForm
    {
        public RegMarathon()
        {
            InitializeComponent();

            fonds_RUTableAdapter.Connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30";
            fondsTableAdapter1.Connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
                 LogRunner logRunner = new LogRunner();
                 this.Hide();
                 logRunner.Show();
        }

        public string Name_Test;
        public int Id_User_Test;
        public int Id_Marathon_Test;

        private void test_Button3_Click(object sender, EventArgs e)
        {
            string userInput = textBox2.Text.ToString();

            if (!Int32.TryParse(userInput, out int value) || value <= 0 || value >= 2147483647)
            {
                MessageBox.Show("Число отрицательное или превышает лимит. Введите другое");
            }
            else
            {

                int Balance = Convert.ToInt32(label11.Text);
                if ((radioButton4.Checked == false) && (radioButton5.Checked == false) && (radioButton6.Checked == false))
                {
                    MessageBox.Show("Выберите вид марафона");
                }
                else
                {
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
                        string query = "SELECT Balance FROM Fonds WHERE Name = @name";
                        SqlCommand command1 = new SqlCommand(query, con);
                        command1.Parameters.AddWithValue("@name", comboBox1.Text);
                        con.Open();

                        int BalanceFond = (int)command1.ExecuteScalar();
                        Console.WriteLine(BalanceFond);

                        con.Close();

                        int TotalBalance = totalFondtest + BalanceFond;

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


                        // SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                        SqlCommand command = new SqlCommand("UPDATE users SET RegMarathon = 1 WHERE Email = @email", con);
                        command.Parameters.AddWithValue("@email", label12.Text);
                        con.Open();
                        int rowsAffected = command.ExecuteNonQuery();
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
                        command4.Parameters.AddWithValue("@Sum", totalFondtest);
                        command4.Parameters.AddWithValue("@Id_User", Id_User_Test);
                        command4.Parameters.AddWithValue("@Id_Marathon", Id_Marathon_Test);
                        command4.ExecuteNonQuery();
                        con.Close();


                        this.Hide();
                        Thanks thanks = new Thanks();
                        thanks.Show();

                    }
                    else
                    {
                        MessageBox.Show("Недостаточно средств. Пополните баланс");
                    }
                }
            }
        }
        private void test_Button2_Click(object sender, EventArgs e)
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

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label16.Font = new Font(label16.Font, FontStyle.Underline);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label16.Font = new Font(label16.Font, FontStyle.Regular);
        }

        private void RegMarathon_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet4.Fonds". При необходимости она может быть перемещена или удалена.
            this.fondsTableAdapter2.Fill(this.dataBase_Sport_MarathonDataSet4.Fonds);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet21.Fonds_RU". При необходимости она может быть перемещена или удалена.
            //this.fonds_RUTableAdapter.Fill(this.kursovayaDataSet21.Fonds_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet20.Fonds". При необходимости она может быть перемещена или удалена.
            this.fondsTableAdapter1.Fill(this.kursovayaDataSet20.Fonds);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet4.Fonds". При необходимости она может быть перемещена или удалена.
           // this.fondsTableAdapter.Fill(this.kursovayaDataSet4.Fonds);
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;


            if (AuthUser.Finish_Marahon)
            {
                Id_Marathon_Test = 1;
            }
            else
            {
                Id_Marathon_Test = 2;
            }

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Email = @email", con);
            command1.Parameters.AddWithValue("@email", AuthUser.Login);
            con.Open();
            int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());
            con.Close();

            label11.Text = Balance.ToString();

            textBox2.Text = "0";
            label12.Text = AuthUser.Login;

            comboBox1.DataSource = fondsBindingSource1;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            comboBox1.BindingContext = new BindingContext();
            comboBox1.Refresh();
            comboBox1.ResetBindings();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public int sum = 0;
        public int totalTest = 0;
        public int totalFondtest = 0;
        private void test_Button1_Click(object sender, EventArgs e)
        {          
       
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            int total = 0;
            int totalFond = 0;

            if (radioButton6.Checked)
            {
                total += 1450;
                totalFond += 1450;
            }

            if (radioButton5.Checked)
            {
                total += 750;
                totalFond += 750;
            }

            if (radioButton4.Checked)
            {
                total += 200;
                totalFond +=  200;
            }


            if (radioButton2.Checked)
            {
                total += 200;
                totalFond = total - 200;
            }

            if (radioButton3.Checked)
            {
                total += 450;
                totalFond = total - 450;
            }

            int value;
            if (int.TryParse(textBox2.Text, out value))
            {
                total += value;
                totalFond += value;

            }

            label6.Text = total.ToString("C0");

            label14.Text = totalFond.ToString("C0");

            totalTest = Convert.ToInt32(total.ToString());
            totalFondtest = Convert.ToInt32(totalFond.ToString());


        }
        
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBalance addBalance = new AddBalance();
            addBalance.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
