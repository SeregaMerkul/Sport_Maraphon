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
    public partial class AddFonds : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public AddFonds()
        {
            InitializeComponent();
        }

        private void AddFonds_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet.Fonds_RU". При необходимости она может быть перемещена или удалена.
            this.fonds_RUTableAdapter1.Fill(this.dataBase_Sport_MarathonDataSet.Fonds_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet8.Fonds_RU". При необходимости она может быть перемещена или удалена.
            this.fonds_RUTableAdapter.Fill(this.kursovayaDataSet8.Fonds_RU);

            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("select * from Fonds_RU", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Fonds_RU");
            dataGridView1.DataSource = ds.Tables["Fonds_RU"];
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = ds.Tables["Fonds_RU"];
            this.Validate();
            string keyword = textBox1.Text;
            binding.Filter = "Название_фонда like" + "'" + keyword + "%" + "'";
        }

        private void test_Button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("select * from Fonds", con);
            ds = new DataSet();

            con.Open();
            cmd = new SqlCommand("INSERT INTO Fonds (Name, Balance) VALUES (@Name, @Balance)", con);

            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Balance", 0);

            cmd.ExecuteNonQuery();
            con.Close();

            Get_List();
            test_Button1.Visible = true;

        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            test_Button1.Visible = false;
        }

        void Get_List()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("select * from Fonds_RU", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Fonds_RU");
            dataGridView1.DataSource = ds.Tables["Fonds_RU"];
            con.Close();
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
    }
}
