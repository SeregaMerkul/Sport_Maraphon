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
    public partial class SponsorsForm : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;


        public bool IsAdmin_Test;
        public SponsorsForm(bool isAdmin)
        {
            InitializeComponent();
            IsAdmin_Test = isAdmin;
        }

        private void SponsorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet7.Sponsors_RU". При необходимости она может быть перемещена или удалена.
            this.sponsors_RUTableAdapter2.Fill(this.dataBase_Sport_MarathonDataSet7.Sponsors_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet18.Sponsors_RU". При необходимости она может быть перемещена или удалена.
            this.sponsors_RUTableAdapter1.Fill(this.kursovayaDataSet18.Sponsors_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet16.Sponsors_RU". При необходимости она может быть перемещена или удалена.
            this.sponsors_RUTableAdapter.Fill(this.kursovayaDataSet16.Sponsors_RU);
            if (IsAdmin_Test)
            {
                Get_List();  
            }
            else
            {
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = true;
            }
            Get_List();
        }
        void Get_List()
        {
            if (IsAdmin_Test)
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                da = new SqlDataAdapter("select * from Sponsors_RU", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Sponsors_RU");
                dataGridView1.DataSource = ds.Tables["Sponsors_RU"];
                con.Close();
            }
            else
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                da = new SqlDataAdapter("select * from Sponsors_RU where Занят = 0", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Sponsors_RU");
                dataGridView1.DataSource = ds.Tables["Sponsors_RU"];
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = ds.Tables["Sponsors_RU"];
            this.Validate();
            string keyword = textBox1.Text;
            binding.Filter = comboBox1.Text + " like" + "'" + keyword + "%" + "'";
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            if (IsAdmin_Test)
            {
                this.Hide();
                SponsorsMenu sponsorsMenu = new SponsorsMenu();
                sponsorsMenu.Show();
            }
            else
            {
                this.Hide();
                LogRunner logRunner = new LogRunner();
                logRunner.Show();
            }
        }

        private void test_Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu authMenu = new AuthMenu();
            authMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Выбрать"].Index && e.RowIndex >= 0)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand command = new SqlCommand("UPDATE Sponsors SET Busy = 1, Email_Runner = @email_runner WHERE Id= @id", con);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
                command.Parameters.AddWithValue("@email_runner", AuthUser.Login);
                con.Open();
                int rowsAffected = command.ExecuteNonQuery();
                con.Close();

                SqlCommand command1 = new SqlCommand("UPDATE Runners SET Busy = 1, Id_Sponsor = @Id_sponsor WHERE Email= @email", con);
                command1.Parameters.AddWithValue("@email", AuthUser.Login);
                command1.Parameters.AddWithValue("@id_sponsor", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                con.Open();
                int rowsAffected1 = command1.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Спасибо за выбор спонсора!");

                this.Hide();
                LogRunner logRunner = new LogRunner();
                logRunner.Show();

                Get_List();
            }
        }
    }
}
