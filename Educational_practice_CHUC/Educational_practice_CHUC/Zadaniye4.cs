using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Добавлено для некоторых элементов кода

namespace Educational_practice_CHUC
{
    public partial class Zadaniye4 : Form
    {
        public Zadaniye4()
        {
            InitializeComponent();
        }

        private void Zadaniye4_Load(object sender, EventArgs e) // Создание метода для подключения
        {
            MySqlConnection conn = new MySqlConnection(ConnectBDPRO.ConnectBD());
            string sql = $"SELECT idStud, fioStud, drStud FROM t_datetime"; // Выбор столбцов из базы
            try
            {
                conn.Open(); // Подключение открыто
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, conn);
                DataSet dataset = new DataSet();
                IDataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            finally
            {
                conn.Close(); // Подключение закрыто
            }
        }
        string id = "0";
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { // Добавление условий в dataGridView1
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true; // При выборе будет выводится диал. окно
                string index_rows5;
                index_rows5 = dataGridView1.SelectedCells[0].RowIndex.ToString();
                id = dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString();
                DateTime x = DateTime.Today;
                DateTime y = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString());
                string resultDays = (x - y).ToString();
                MessageBox.Show("Прошло " + resultDays.Substring(0, resultDays.Length - 9) + " дней(я) со дня рождения!");
            } // Вывод информации в диалоговое окно
        }
    }
}
