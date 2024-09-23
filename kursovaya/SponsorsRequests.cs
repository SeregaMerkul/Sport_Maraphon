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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursovaya
{
    public partial class SponsorsRequests : Form
    {
        public SponsorsRequests()
        {
            InitializeComponent();
        }


        public string emailt;
        public string name;
        public string INN;
        public int Id_Fond = 0;
        public int summa = 0;
        public int id = 0;

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;

        private void SponsorsRequests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet8.PossibleSponsors_RU". При необходимости она может быть перемещена или удалена.
            this.possibleSponsors_RUTableAdapter5.Fill(this.dataBase_Sport_MarathonDataSet8.PossibleSponsors_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet15.PossibleSponsors_RU". При необходимости она может быть перемещена или удалена.
            this.possibleSponsors_RUTableAdapter4.Fill(this.kursovayaDataSet15.PossibleSponsors_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet14.PossibleSponsors_RU". При необходимости она может быть перемещена или удалена.
            this.possibleSponsors_RUTableAdapter3.Fill(this.kursovayaDataSet14.PossibleSponsors_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet13.PossibleSponsors_RU". При необходимости она может быть перемещена или удалена.
            //this.possibleSponsors_RUTableAdapter2.Fill(this.kursovayaDataSet13.PossibleSponsors_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet12.PossibleSponsors_RU". При необходимости она может быть перемещена или удалена.
            //this.possibleSponsors_RUTableAdapter1.Fill(this.kursovayaDataSet12.PossibleSponsors_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet11.PossibleSponsors_RU". При необходимости она может быть перемещена или удалена.
            //this.possibleSponsors_RUTableAdapter.Fill(this.kursovayaDataSet11.PossibleSponsors_RU);

            Get_List();

        }


        void Get_List()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("select * from PossibleSponsors_RU", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "PossibleSponsors_RU");
            dataGridView1.DataSource = ds.Tables["PossibleSponsors_RU"];
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Cancel"].Index && e.RowIndex >= 0)
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                ds = new DataSet();

                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = " delete from Possible_Sponsors where Id = " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

                    DialogResult rezalt = MessageBox.Show("удалить запись? ", "    УДАЛЕНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rezalt == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    Get_List();
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["Add"].Index && e.RowIndex >= 0)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Possible_Sponsors WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (reader.Read())
                {

                     id = Convert.ToInt32(row.Cells["nomer_p_p"].Value.ToString());
                     emailt = reader["Email"].ToString();
                     name = reader["Name_company"].ToString();
                     INN = reader["INN"].ToString();
                     Id_Fond = Convert.ToInt32(reader["Id_Fond"].ToString());
                     summa = Convert.ToInt32(row.Cells["суммаDataGridViewTextBoxColumn"].Value.ToString());

                }

                

                AddSponsorForm addSponsorForm = new AddSponsorForm(id, emailt, name, INN, Id_Fond, summa);
                DialogResult result = addSponsorForm.ShowDialog();

                if (result == DialogResult.OK)
                {                    
                    Get_List();
                }
                else
                {                    
                    Get_List();
                }
                
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
            binding.DataSource = ds.Tables["PossibleSponsors_RU"];
            this.Validate();
            string keyword = textBox1.Text;
            binding.Filter = comboBox1.Text + " like" + "'" + keyword + "%" + "'";
        }
    }
}
