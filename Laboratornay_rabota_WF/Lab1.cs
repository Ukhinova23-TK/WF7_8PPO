using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratornay_rabota_WF
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
            //Задание 1
            button1.Click += button1_click;
            button2.Click += button2_click;
            button3.Click += button3_click;
            //Задание 2
            button4.Click += button4_click;
            //Задание 3
            button5.Click += button5_click;
            //Задание 4
            button6.Click += button6_click;
        }

        private void button6_click(object sender, EventArgs e)
        {
            textBox13.Clear();
            double x = Convert.ToDouble(textBox8.Text);
            double h = Convert.ToDouble(textBox12.Text);
            if ((h <= 0) || (h >= 1))
            {
                textBox13.Text = "Некорректный шаг для У";
            }
            else
            {
                for (double y = 2; y < 3; y += h)
                {
                    textBox13.Text += "Угол между стеной и палкой равен " + Math.Acos(y / x) * (180 / Math.PI) + "\r\n";
                }
            }
        }

        private void button5_click(object sender, EventArgs e)
        {
            textBox14.Clear();
            int n = Convert.ToInt32(numericUpDown1.Text);
            int am = 1;
            for (int i = 3; i <= n; i += 3)
            {
                am *= 2;
                textBox14.Text += "Через " + i + " часа(ов) амеб стало " + am + "\r\n";
            }
        }

        private void button4_click(object sender, EventArgs e)
        {
            double km = Convert.ToDouble(textBox3.Text);
            double day = Convert.ToDouble(textBox6.Text);
            double sum = km;
            for (int i = 1; i < day; i++)
            {
                km *= 1.1;
                sum += km;
            }
            label14.Text += "В течении " + day + " дней спортсмен пробежал " + sum + " км";
        }

        private void button3_click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(textBox9.Text);
            double s2 = Convert.ToDouble(textBox10.Text);
            double s3 = Convert.ToDouble(textBox11.Text);
            double p = (s1 + s2 + s3) / 2;
            if ((p < s1) || (p < s2) || (p < s3))
                label15.Text = "Такого треугольника не существует";
            else
                label15.Text = "Площадь " + (Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3)));
        }

        private void button2_click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(textBox4.Text);
            double s2 = Convert.ToDouble(textBox5.Text);
            double ug = Convert.ToDouble(textBox7.Text);
            label15.Text = "Площадь " + (0.5 * (s1 * s2 * Math.Sin(ug * Math.PI / 180)));
        }

        private void button1_click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(textBox1.Text);
            double h = Convert.ToDouble(textBox2.Text);
            label15.Text = "Площадь " + (0.5 * s1 * h);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab1_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
