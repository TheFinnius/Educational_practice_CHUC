using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Educational_practice_CHUC
{
    public partial class Zadaniye3 : Form
    {
        public Zadaniye3()
        {
            InitializeComponent();
        }
        private void Zadaniye3_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConnectBDPRO.ConnectBD());
            string sql = $"SELECT id, fio, theme_kurs FROM t_stud";
            try
            {
                conn.Open();
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, conn);
                DataSet dataset = new DataSet();
                IDataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            finally
            {
                conn.Close();
            }
        }
        string id_rows = "0";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentRow.Selected = true;
            string index_rows;
            index_rows = dataGridView1.SelectedCells[0].RowIndex.ToString();
            id_rows = dataGridView1.Rows[Convert.ToInt32(index_rows)].Cells[1].Value.ToString();
            MessageBox.Show(id_rows);
        }
    }
}
