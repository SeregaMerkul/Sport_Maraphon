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
    public partial class AddResultsForm : Form
    {

        public string name_runner_test;
        public string lastname_runner_test;
        public string email_test;
        public int id_runner_test;
        public AddResultsForm(string name_runner, string lastname_runner, string email)
        {
            InitializeComponent();
            name_runner_test = name_runner;
            lastname_runner_test = lastname_runner;
            email_test = email;
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
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


            con.Open();


            SqlCommand command2 = new SqlCommand("SELECT COUNT(*) FROM Results WHERE place_runner = @place_runner", con);
            command2.Parameters.AddWithValue("@place_runner", placeTextBox.Text);

            int rowCount = (int)command2.ExecuteScalar();
            if (rowCount > 0)
            {
                MessageBox.Show("Данное место уже занято");
                con.Close();
            }
            else
            {
                SqlCommand command3 = new SqlCommand("INSERT INTO Results (Id_runner, Name_Marathon, Finish_Time, Place_Runner) VALUES (@Id_runner, @Name_Marathon, @Finish_Time, @Place_Runner)", con);
                command3.Parameters.AddWithValue("@Id_Runner", id_runner_test);
                command3.Parameters.AddWithValue("@Email", email_test);
                command3.Parameters.AddWithValue("@Name_Marathon", "Marathon Skills");
                command3.Parameters.AddWithValue("@Finish_Time", timeMaskedTextBox.Text);
                command3.Parameters.AddWithValue("@Place_Runner", placeTextBox.Text);

                command3.ExecuteNonQuery();
                con.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

 



           

        }

        private void AddResultsForm_Load(object sender, EventArgs e)
        {
            labelEmail.Text = email_test;
            timeMaskedTextBox.PromptChar = ' ';

        }

        private void timeMaskedTextBox_Click(object sender, EventArgs e)
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

        private void timeMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;

            string[] timeParts = maskedTextBox.Text.Split(':');
            int hours, minutes, seconds;

            if (timeParts.Length != 3 || !int.TryParse(timeParts[0], out hours) || !int.TryParse(timeParts[1], out minutes) || !int.TryParse(timeParts[2], out seconds))
            {
                // Некорректный формат времени, разрешаем пользователю исправить ввод.
                e.Cancel = true;
                return;
            }

            if (hours > 23 || minutes > 59 || seconds > 59)
            {
                // Время превышает 24 часа, 60 минут или 60 секунд, отменяем изменения пользователя.
                e.Cancel = true;
                MessageBox.Show("Время не может превышать 24:00:00");
            }
        }
    }
}
