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
using static kursovaya.kursovayaDataSet22;

namespace kursovaya
{
    public partial class ResultsForm : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        DataTable dt;

        public ResultsForm()
        {
            InitializeComponent();
            runners_RUTableAdapter1.Connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30";

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet6.Runners_RU". При необходимости она может быть перемещена или удалена.
            this.runners_RUTableAdapter3.Fill(this.dataBase_Sport_MarathonDataSet6.Runners_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet24.Runners_RU". При необходимости она может быть перемещена или удалена.
            this.runners_RUTableAdapter2.Fill(this.kursovayaDataSet24.Runners_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet23.Runners_RU". При необходимости она может быть перемещена или удалена.
            //this.runners_RUTableAdapter1.Fill(this.kursovayaDataSet23.Runners_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet22.Runners_RU". При необходимости она может быть перемещена или удалена.
            // this.runners_RUTableAdapter.Fill(this.kursovayaDataSet22.Runners_RU);
            Get_List();
        }



        void Get_List()
        {

            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("SELECT runners_ru.* FROM runners_ru LEFT JOIN Users ON runners_ru.Email = Users.Email WHERE runners_ru.#_пп NOT IN ( SELECT id_runner FROM results WHERE TRIM(name_marathon) = 'Marathon Skills' ) AND (Users.RegMarathon = 1) ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Runners_RU");
            dataGridView1.DataSource = ds.Tables["Runners_RU"];
            con.Close();

        }


      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = ds.Tables["Runners_RU"];
            this.Validate();
            string keyword = textBox1.Text;
            binding.Filter = comboBox1.Text + " like" + "'" + keyword + "%" + "'";
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogAdmin logAdmin = new LogAdmin();
            logAdmin.Show();
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

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name_runner = row.Cells[1].Value.ToString();
                string lastname_runner = row.Cells[2].Value.ToString();
                string email = row.Cells[3].Value.ToString();


                AddResultsForm addResultsForm = new AddResultsForm(name_runner, lastname_runner, email);
                DialogResult result = addResultsForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Get_List();
                }

                Get_List();
                row.Visible = false;
            }
        }
    }
}
