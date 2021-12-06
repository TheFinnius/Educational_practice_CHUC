using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // Добавлено для работы некоторых элементов

namespace Educational_practice_CHUC
{
    public partial class Zadaniye1 : Form
    {
        public Zadaniye1()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        abstract class Komplektuyushie<T> // Создание абстрактного класс
        {
            public T artikul;
            public int date;
            public int cena;

            public Komplektuyushie(T ar, int dt, int cn)
            {
                artikul = ar;
                date = dt;
                cena = cn;
            }

            public abstract void DisplayInfo(ListBox lb);

        }

        class CPU<T> : Komplektuyushie<T> // Наследование класса от "Комплектующие"
        {
            public int chastotaCPU;
            public int core;
            public int potoki;

            int Частота_CPU { get { return chastotaCPU; } set { chastotaCPU = value; } }
            int Ядра { get { return core; } set { core = value; } }
            int Потоки { get { return potoki; } set { potoki = value; } }

            public CPU(T ar, int dt, int cn, int chstCPU, int c, int pt)
              : base(ar, dt, cn)
            {
                chastotaCPU = chstCPU;
                core = c;
                potoki = pt;
            }

            public override void DisplayInfo(ListBox lb) // Вывод информации в лист бокс
            {
                lb.Items.Add($"Артикул:{artikul}, Год выпуска:{date}, Цена:{cena}руб, Частота процессора:{chastotaCPU}GHz, Количество ядер:{core}, Количество потоков:{potoki}");
            }


        }
        class GPU<T> : Komplektuyushie<T> // Наследование класса от "Комплектующие"
        {
            public int chastotaGPU;
            public int dataGDDR;
            public string proizvoditel;
            

            public int Частота_GPU { get { return chastotaGPU; } set { chastotaGPU = value; } }
            public int Объём_памяти { get { return dataGDDR; } set { dataGDDR = value; } }
            public string Производитель { get { return proizvoditel; } set { proizvoditel = value; } }
            

            public GPU(T ar, int dt, int PR, int chstGPU, string cn, int dataGDR)
              : base(ar, dt, PR)
            {
                chastotaGPU = chstGPU;
                proizvoditel = cn;
                dataGDDR = dataGDR;
            }

            public override void DisplayInfo(ListBox lb) // Вывод информации в лист бокс
            {
                lb.Items.Add($"Артикул:{artikul}, Год выпуска:{date}, Цена:{cena}руб, Частота GPU:{chastotaGPU}MHz, Объём памяти:{dataGDDR}GB, Производитель:{proizvoditel}");

            }


        }
        CPU<int> cpu; // Наименование для CPU
        GPU<int> gpu; // Наименование для GPU
        private void button1_Click(object sender, EventArgs e) // Создание кнопки 1 CPU
        {
            int artikul = Convert.ToInt32(textBox1.Text); // Сбор инфомации из текст боксов
            int date = Convert.ToInt32(textBox2.Text);
            int cena = Convert.ToInt32(textBox3.Text);
            int chastotaCPU = Convert.ToInt32(textBox4.Text);
            int core = Convert.ToInt32(textBox5.Text);
            int potoki = Convert.ToInt32(textBox6.Text);
            cpu = new CPU<int>(artikul, date, cena, chastotaCPU, core, potoki);
            cpu.DisplayInfo(listBox1); // Вывод в лист бокс 1
        }

        private void button2_Click(object sender, EventArgs e) // Создание кнопки 2 GPU
        {
            int artikul = Convert.ToInt32(textBox7.Text); // Сбор информации из текст боксов
            int date = Convert.ToInt32(textBox8.Text);
            int cena = Convert.ToInt32(textBox9.Text);
            int chastotaGPU = Convert.ToInt32(textBox10.Text);
            int dataGDDR = Convert.ToInt32(textBox11.Text);
            string proizvoditel = textBox12.Text;
            gpu = new GPU<int>(artikul, date, cena, chastotaGPU, proizvoditel, dataGDDR);
            gpu.DisplayInfo(listBox2); // Вывод в лист бокс 2
        }
    }
}
