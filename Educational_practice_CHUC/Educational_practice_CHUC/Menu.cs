using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_practice_CHUC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Создаём кнопки для открытия новых форм с заданиями
        private void button1_Click(object sender, EventArgs e)
        {
            Zadaniye1 Zadaniye1 = new Zadaniye1();
            Zadaniye1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zadaniye2 Zadaniye2 = new Zadaniye2();
            Zadaniye2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadaniye3 Zadaniye3 = new Zadaniye3();
            Zadaniye3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zadaniye4 Zadaniye4 = new Zadaniye4();
            Zadaniye4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zadaniye5 Zadaniye5 = new Zadaniye5();
            Zadaniye5.ShowDialog();
        }
    }
}
