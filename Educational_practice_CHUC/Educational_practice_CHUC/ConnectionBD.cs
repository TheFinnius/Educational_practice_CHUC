using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_practice_CHUC
{
    internal class ConnectionBD
    {
        public string ConnectBDPRO = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";

        public void ConnectionInfo()
        {
            MessageBox.Show(ConnectBDPRO);
        }
    }
}
