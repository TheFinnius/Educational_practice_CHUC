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
    public partial class Zadaniye2 : Form
    {
        public Zadaniye2()
        {
            InitializeComponent();
        }

        class Connection_Proverka
        {
            public string ConnectBDPRO = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";

            public void ConnectionInfo()
            {
                MessageBox.Show(ConnectBDPRO);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection_Proverka con = new Connection_Proverka();
            MySqlConnection conn = new MySqlConnection(con.ConnectBDPRO);
            bool result = true;
            try
            {
                conn.Open();
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (result == true)
                {
                    MessageBox.Show("Подключение работает без неполадков");
                }
                else
                {
                    MessageBox.Show("При подключении возникли неполадки");
                }
            }
        }
    }
}
