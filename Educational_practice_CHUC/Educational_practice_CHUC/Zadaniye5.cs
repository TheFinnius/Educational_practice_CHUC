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
    public partial class Zadaniye5 : Form
    {
        public Zadaniye5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConnectBDPRO.ConnectBD());
            string dateitimeStud = textBox2.Text;
            string fioStud = textBox1.Text;
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES ('{fioStud}','{dateitimeStud}');";
            int counter = 0;
            try
            {
                ConnectBDPRO.Open();
                MySqlCommand commanders = new MySqlCommand(sql, conn);
                counter = commanders.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Данные не были добавлены");
            }
            finally
            {
                object p = ConnectBDPRO.Close();
                if (counter != 0)
                {
                    MessageBox.Show("Данные были добавлены");
                }
            }
        }
    }
}
