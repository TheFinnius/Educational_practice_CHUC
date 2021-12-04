using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_practice_CHUC
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
    public class ConnectBDPRO
    {
        public static string ConnectBD()
        {
            string connString = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass";
            return connString;

        }
    }
}
