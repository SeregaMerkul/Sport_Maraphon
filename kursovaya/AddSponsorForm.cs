using kursovaya.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kursovaya
{
    public partial class AddSponsorForm : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;

        public string Email_Test;
        public string INN_Test;
        public int Id_Fond_Test;
        public int Id_User_Test;
        public int Id_Marathon_Test;
        public string name_Test;
        public string Password_Test;
        public int id_test;
        public int summa_test;

        public AddSponsorForm(int id, string emailt, string name, string INN, int Id_Fond, int summa)
        {
            InitializeComponent();
            id_test = id;
            labelEmail.Text = emailt;
            Email_Test = emailt;
            INN_Test = INN;
            Id_Fond_Test = Id_Fond;
            name_Test = name;
            summa_test = summa;
        }



        private void AddSponsorForm_Load(object sender, EventArgs e)
        {
            if (AuthUser.Finish_Marahon)
            {
                Id_Marathon_Test = 1;
            }
            else
            {
                Id_Marathon_Test = 2;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == passwordTextBox1.Text)
            {
                if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {

                    MessageBox.Show("Введите пароль");

                }
                else
                {
                    
                   Password_Test = passwordTextBox.Text;
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");                                   
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Sponsors (Name_Company, Email, INN, Id_Fond, Password, Busy) VALUES (@Name_Company, @Email, @INN, @Id_Fond, @Password, @Busy)", con);
                    command.Parameters.AddWithValue("@Name_Company", name_Test);
                    command.Parameters.AddWithValue("@Email", Email_Test);
                    command.Parameters.AddWithValue("@INN", INN_Test);
                    command.Parameters.AddWithValue("@Id_Fond", Id_Fond_Test);
                    command.Parameters.AddWithValue("@Password", Password_Test);
                    command.Parameters.AddWithValue("@Busy", 0);

                    command.ExecuteNonQuery();
                    con.Close();

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

                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand command3 = new SqlCommand("INSERT INTO Users (Email, Password, Role) VALUES (@Email, @Password, @Role)", con);

                    command3.Parameters.AddWithValue("@Email", Email_Test);
                    command3.Parameters.AddWithValue("@Password", Password_Test);
                    command3.Parameters.AddWithValue("@Role", "Sponsor");

                    command3.ExecuteNonQuery();
                    con.Close();


                    string query = "SELECT Balance FROM Fonds WHERE Id = @Id";
                    SqlCommand command1 = new SqlCommand(query, con);
                    command1.Parameters.AddWithValue("@Id", Id_Fond_Test);
                    con.Open();
                    int BalanceFond = (int)command1.ExecuteScalar();
                    Console.WriteLine(BalanceFond);
                    con.Close();

                    int TotalBalance = summa_test + BalanceFond;

                    SqlCommand command2 = new SqlCommand("UPDATE Fonds SET Balance = " + TotalBalance + " WHERE Id = @Id", con);
                    command2.Parameters.AddWithValue("@Id", Id_Fond_Test);
                    con.Open();
                    command2.ExecuteNonQuery();
                    con.Close();



                    ds = new DataSet();
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = " delete from Possible_Sponsors where Id= " + id_test;
                    cmd.ExecuteNonQuery();
                    con.Close();


                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    con.Open();
                    SqlCommand command4 = new SqlCommand("INSERT INTO Transactions (Name, Email, Id_Fond, Date, Sum, id_user, id_marathon) VALUES (@Name, @Email, @Id_Fond, @Date, @Sum, @Id_User, @Id_Marathon)", con);
                    command4.Parameters.AddWithValue("@Name", name_Test);
                    command4.Parameters.AddWithValue("@Email", Email_Test);
                    command4.Parameters.AddWithValue("@Id_Fond", Id_Fond_Test);
                    command4.Parameters.AddWithValue("@Date", DateTime.Now);
                    command4.Parameters.AddWithValue("@Sum", summa_test);
                    command4.Parameters.AddWithValue("@Id_User", Id_User_Test);
                    command4.Parameters.AddWithValue("@Id_Marathon", Id_Marathon_Test);
                    command4.ExecuteNonQuery();
                    con.Close();


                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
                
            
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    } 
}
    
