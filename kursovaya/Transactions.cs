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
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class Transactions : Form
    {
        public Transactions(string fond)
        {
            InitializeComponent();
            Fond_Test = fond;
        }

        public string Fond_Test;

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void Transactions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet13.Transactions_RU". При необходимости она может быть перемещена или удалена.
            this.transactions_RUTableAdapter3.Fill(this.dataBase_Sport_MarathonDataSet13.Transactions_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet12.Transactions_RU". При необходимости она может быть перемещена или удалена.
            this.transactions_RUTableAdapter2.Fill(this.dataBase_Sport_MarathonDataSet12.Transactions_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBase_Sport_MarathonDataSet10.Transactions_RU". При необходимости она может быть перемещена или удалена.
            this.transactions_RUTableAdapter1.Fill(this.dataBase_Sport_MarathonDataSet10.Transactions_RU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet19.Transactions_RU". При необходимости она может быть перемещена или удалена.
            this.transactions_RUTableAdapter.Fill(this.kursovayaDataSet19.Transactions_RU);

            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataBase_Sport_Marathon.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("select * from Transactions_RU where Фонд = @Fond ", con);
            da.SelectCommand.Parameters.AddWithValue("@Fond", Fond_Test);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Transactions_RU");
            dataGridView1.DataSource = ds.Tables["Transactions_RU"];
            con.Close();

            label6.Text = "История транзакций " + Fond_Test;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void test_Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void test_Button1_Click(object sender, EventArgs e)
        {
            // Создаем новый объект Excel
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            // Создаем новую рабочую книгу и получаем активный лист
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Объединяем ячейки и записываем заголовок
            Excel.Range headerRange = worksheet.Range["A1:E1"]; // Определяем диапазон объединения ячеек
            headerRange.Merge(); // Объединяем ячейки
            headerRange.Value = label6.Text; // Задаем значение заголовка
            headerRange.Font.Bold = true; // Задаем жирный шрифт
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // Выравнивание по центру

            // Записываем заголовки столбцов из DataGridView
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[2, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Записываем данные из DataGridView в Excel
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 3, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 3, j + 1] = string.Empty; // или можно заменить на любое другое значение по умолчанию
                    }
                }
            }

            // Находим последнюю строку с данными
            int lastRowIndex = dataGridView1.Rows.Count + 1; // +2, так как данные начинаются со 3-й строки

            // Добавляем строку "ИТОГО:" и объединяем ячейки от A до D
            Excel.Range totalRange = worksheet.Range[$"A{lastRowIndex + 1}:D{lastRowIndex + 1}"];
            totalRange.Merge();
            totalRange.Value = "ИТОГО:";
            totalRange.Font.Bold = true;
            totalRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight; // Выравнивание по правому краю

            // Рассчитываем сумму в столбце E
            Excel.Range sumRange = worksheet.Range[$"E3:E{lastRowIndex}"];
            Excel.Range totalSumRange = worksheet.Range[$"E{lastRowIndex + 1}"];
            totalSumRange.Formula = $"=SUM({sumRange.Address})";
            totalSumRange.Font.Bold = true;

            // Открываем диалоговое окно сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Выберите файл для сохранения";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Сохраняем файл Excel
                workbook.SaveAs(filePath);
                MessageBox.Show("Файл успешно сохранен.");
            }
            else
            {
                MessageBox.Show("Отменено сохранение файла.");
            }

            // Освобождаем ресурсы
            workbook.Close();
            excelApp.Quit();
        }
    }
}
