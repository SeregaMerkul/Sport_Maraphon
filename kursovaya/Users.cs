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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursovaya
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }


        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet11.Users_RU". При необходимости она может быть перемещена или удалена.
            this.users_RUTableAdapter3.Fill(this.dataBase_Sport_MarathonDataSet11.Users_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet7.Users_RU". При необходимости она может быть перемещена или удалена.
            this.users_RUTableAdapter2.Fill(this.kursovayaDataSet7.Users_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet6.Users_RU". При необходимости она может быть перемещена или удалена.
            //this.users_RUTableAdapter1.Fill(this.kursovayaDataSet6.Users_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet5.Users_RU". При необходимости она может быть перемещена или удалена.
           // this.users_RUTableAdapter.Fill(this.kursovayaDataSet5.Users_RU);

            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("select * from Users_RU", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Users_RU");
            dataGridView1.DataSource = ds.Tables["Users_RU"];
            con.Close();

            Get_List();


        }

        void Get_List()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("select * from Users_RU", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Users_RU");
            dataGridView1.DataSource = ds.Tables["Users_RU"];
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void test_Button3_Click(object sender, EventArgs e)
        {
            Get_List();
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            DialogResult result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Get_List();
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = ds.Tables["Users_RU"];
            this.Validate();
            string keyword = textBox1.Text;
            binding.Filter = comboBox1.Text + " like" + "'" + keyword + "%" + "'";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name = row.Cells["Имя"].Value.ToString();
                string lastname = row.Cells["Фамилия"].Value.ToString();
                string password = row.Cells["Пароль"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string role = row.Cells["Роль"].Value.ToString();

                EditForm editForm = new EditForm(name, lastname, email, password, role);
                DialogResult result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Get_List();
                }
            }
        }
    }
}
