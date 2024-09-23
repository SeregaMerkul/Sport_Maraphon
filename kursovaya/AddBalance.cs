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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursovaya
{
    public partial class AddBalance : Form
    {

        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlConnection con;
        public int id_user_test = 0;
        public AddBalance()
        {
            InitializeComponent();
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

        private void AddBalance_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlCommand command = new SqlCommand($"SELECT Id FROM users WHERE email = '{AuthUser.Login}'", con);
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_user_test = Convert.ToInt32(reader["Id"].ToString());

                    }
                }
            }
            con.Close();

            
            SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Id = @id", con);
            command1.Parameters.AddWithValue("@id", id_user_test);
            con.Open();
            int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());
            con.Close();

            label2.Text = Balance.ToString();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet3.Cards". При необходимости она может быть перемещена или удалена.
            this.cardsTableAdapter.Fill(this.kursovayaDataSet3.Cards);
            label1.Text = AuthUser.Login;
            maskedTextBox4.Culture = new CultureInfo("en-US");

            maskedTextBox4.Mask = "99\\\\99";
            maskedTextBox4.ValidatingType = typeof(int);
            maskedTextBox4.TypeValidationCompleted += new TypeValidationEventHandler(maskedTextBox4_TypeValidationCompleted);

            maskedTextBox2.Mask = ">LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            maskedTextBox3.Mask = ">LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            maskedTextBox5.Mask = "999";
            maskedTextBox1.Mask = "9999 9999 9999 9999";

            maskedTextBox1.HidePromptOnLeave = true;
            maskedTextBox2.HidePromptOnLeave = true;
            maskedTextBox3.HidePromptOnLeave = true;
            maskedTextBox4.HidePromptOnLeave = true;
            maskedTextBox5.HidePromptOnLeave = true;

            maskedTextBox1.PromptChar = ' ';
            maskedTextBox2.PromptChar = ' ';
            maskedTextBox3.PromptChar = ' ';
            maskedTextBox4.PromptChar = ' ';
            maskedTextBox5.PromptChar = ' ';



            maskedTextBox5.PasswordChar = '*';

            comboBox1.DisplayMember = "number_card";
            comboBox1.ValueMember = "number_card";

            


            string selectedEmail = AuthUser.Login;
            string query = "SELECT number_card, Id_User FROM cards WHERE Id_User = @id_user";
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand command3 = new SqlCommand(query, connection))
                {
                    command3.Parameters.AddWithValue("@id_user", id_user_test);

                    connection.Open();
                    SqlDataReader reader = command3.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBox1.DataSource = dataTable;
                }
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           

            string userInput = textBoxSum.Text.ToString();

            if (!Int32.TryParse(userInput, out int value) || value <= 0 || value >= 2147483647)
            {
                MessageBox.Show("Число отрицательное или превышает лимит. Введите другое");
            }
            else
            {
                if (checkBox1.Checked)
                {
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                    da = new SqlDataAdapter("select * from Cards", con);
                    ds = new DataSet();


                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cards WHERE Number_card=@number_card AND Id_User = @Id_User", con);
                    cmd.Parameters.AddWithValue("@number_card", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Id_User", id_user_test);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();

                    if (count > 0)
                    {
                        checkBox1.Checked = false;
                        SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Id = @Id", con);
                        command1.Parameters.AddWithValue("@Id", id_user_test);
                        con.Open();
                        int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());
                        con.Close();

                        Balance = Balance + Convert.ToInt32(textBoxSum.Text);

                        Console.WriteLine(Balance);

                        con.Open();
                        SqlCommand command2 = new SqlCommand("UPDATE Users SET Balance = " + Balance.ToString() + " WHERE Id = @Id", con); ;
                        command2.Parameters.AddWithValue("@Id", id_user_test);
                        command2.ExecuteNonQuery();
                        con.Close();

                        this.Close();
                        LogRunner logRunner = new LogRunner();
                        logRunner.Show();
                    }
                    else
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("AddCard1", con);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Number_card", maskedTextBox1.Text);
                        command.Parameters.AddWithValue("@Name", maskedTextBox2.Text);
                        command.Parameters.AddWithValue("@LastName", maskedTextBox3.Text);
                        command.Parameters.AddWithValue("@CardDate", maskedTextBox4.Text);
                        command.Parameters.AddWithValue("@CVV", maskedTextBox5.Text);
                        command.Parameters.AddWithValue("@SaveCard", checkBox1.Checked);
                        command.Parameters.AddWithValue("@Id_User", id_user_test);

                        command.ExecuteNonQuery();
                        con.Close();

                        SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Id = @Id", con);
                        command1.Parameters.AddWithValue("@Id", id_user_test);
                        con.Open();
                        int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());
                        con.Close();

                        Balance = Balance + Convert.ToInt32(textBoxSum.Text);

                        Console.WriteLine(Balance);

                        con.Open();
                        SqlCommand command2 = new SqlCommand("UPDATE Users SET Balance = " + Balance.ToString() + " WHERE Id = @Id", con); ;
                        command2.Parameters.AddWithValue("@Id", id_user_test);
                        command2.ExecuteNonQuery();
                        con.Close();

                        this.Close();
                        LogRunner logRunner = new LogRunner();
                        logRunner.Show();
                    }





                }
                else
                {
                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");

                    SqlCommand command1 = new SqlCommand("SELECT Balance FROM users WHERE Id = @Id", con);
                    command1.Parameters.AddWithValue("@Id", id_user_test);
                    con.Open();
                    int Balance = Convert.ToInt32(command1.ExecuteScalar().ToString());
                    con.Close();

                    Balance = Balance + Convert.ToInt32(textBoxSum.Text);

                    Console.WriteLine(Balance);

                    con.Open();
                    SqlCommand command2 = new SqlCommand("UPDATE Users SET Balance = " + Balance.ToString() + " WHERE Id = @Id", con); ;
                    command2.Parameters.AddWithValue("@Id", id_user_test);
                    command2.ExecuteNonQuery();
                    con.Close();

                    this.Close();
                    LogRunner logRunner = new LogRunner();
                    logRunner.Show();
                }
            }
        }
        private void test_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogRunner logRunner = new LogRunner();
            logRunner.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = comboBox1.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string selectedNumberCard = selectedRow.Row.Field<string>("number_card");
                int selectedEmail = selectedRow.Row.Field<int>("Id_user");

            }

            string query = "SELECT name, lastname, CardDate, CVV FROM cards WHERE number_card = @cardNumber AND Id_User = @Id_user";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cardNumber", comboBox1.Text);
                    command.Parameters.AddWithValue("@Id_User", id_user_test);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        maskedTextBox1.Text = comboBox1.Text;
                        maskedTextBox2.Text = reader["name"].ToString();
                        maskedTextBox3.Text = reader["lastname"].ToString();
                        maskedTextBox4.Text = reader["CardDate"].ToString();
                        maskedTextBox5.Text = reader["CVV"].ToString();
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        

        private void maskedTextBox4_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                
            }
            else
            {
                int value = Convert.ToInt32(maskedTextBox4.Text.Split('/')[0]);
                if (value > 12)
                {
                    MessageBox.Show("Месяц срока действия карты введен некорректно!");
                    maskedTextBox4.Text = "";
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            int clickPosition = maskedTextBox.SelectionStart;
            int midPoint = maskedTextBox.Text.Length / 2;

            if (clickPosition == midPoint)
            {
                maskedTextBox.SelectionStart = 0;
                maskedTextBox.SelectionLength = 0;
            }
            else
            {
                maskedTextBox.SelectionStart = 0;
                maskedTextBox.SelectionLength = 0;
            }
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || !char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
