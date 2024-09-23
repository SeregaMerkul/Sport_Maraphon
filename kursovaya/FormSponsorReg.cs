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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursovaya
{
    public partial class FormSponsorReg : Form
    {


        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public FormSponsorReg()
        {
            InitializeComponent();
            fondsTableAdapter.Connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30";

        }

        private void FormSponsorReg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet2.Fonds". При необходимости она может быть перемещена или удалена.
            this.fondsTableAdapter1.Fill(this.dataBase_Sport_MarathonDataSet2.Fonds);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet10.Fonds". При необходимости она может быть перемещена или удалена.
            this.fondsTableAdapter.Fill(this.kursovayaDataSet10.Fonds);

            maskedTextBox1.Mask = "9999-99999-9";
            maskedTextBox1.PromptChar = ' ';

        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox3.Text.ToString();

            if (!Int32.TryParse(userInput, out int value) || value <= 0 || value >= 2147483647)
            {
                MessageBox.Show("Число отрицательное или превышает лимит. Введите другое");
            }
            else
            {
                if (IsValidEmail(textBoxLogin.Text))
                {




                    con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                    ds = new DataSet();

                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Possible_Sponsors (Name_Company, Email, INN, Id_Fond, Summa) VALUES (@Name_Company, @Email, @INN, @Id_Fond, @Summa)", con);
                    command.Parameters.AddWithValue("@Name_Company", textBox1.Text);
                    command.Parameters.AddWithValue("@Email", textBoxLogin.Text);
                    command.Parameters.AddWithValue("@INN", maskedTextBox1.Text);
                    command.Parameters.AddWithValue("@Id_Fond", comboBox1.SelectedValue);
                    command.Parameters.AddWithValue("@Summa", textBox3.Text);

                    command.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Заявка подана");

                }
                else
                {
                    MessageBox.Show("E-mail введен некорректно");
                }
            }


            bool IsValidEmail(string email)
            {
                try
                {
                    var mail = new System.Net.Mail.MailAddress(email);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav glav = new Glav();
            glav.Show();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
