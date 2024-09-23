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
    public partial class FondsForm : Form
    {
        public FondsForm()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = ds.Tables["Fonds_RU"];
            this.Validate();
            string keyword = textBox1.Text;
            binding.Filter = "Название_фонда like" + "'" + keyword + "%" + "'";
        }

        private void FondsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet1.Fonds_RU". При необходимости она может быть перемещена или удалена.
            this.fonds_RUTableAdapter1.Fill(this.dataBase_Sport_MarathonDataSet1.Fonds_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet9.Fonds_RU". При необходимости она может быть перемещена или удалена.
            this.fonds_RUTableAdapter.Fill(this.kursovayaDataSet9.Fonds_RU);

            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("select * from Fonds_RU", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Fonds_RU");
            dataGridView1.DataSource = ds.Tables["Fonds_RU"];
            con.Close();


        }

        private void test_Button6_Click(object sender, EventArgs e)
        {
           
        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoreInfoMenu moreInfoMenu = new MoreInfoMenu();
            moreInfoMenu.Show();
        }

        public string fond;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["View"].Index && e.RowIndex >= 0)
            {
                fond = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                Transactions transactions = new Transactions(fond);
                transactions.ShowDialog();

            }
            
        }
    }
}
