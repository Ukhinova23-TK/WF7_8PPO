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
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
            button1.Click += button1_click;
            button2.Click += button2_click;
			button3.Click += button3_click;
			button4.Click += button4_click;
        }

		private void button4_click(object sender, EventArgs e)
		{
			textBox9.Clear();
			int n = Convert.ToInt32(textBox8.Text);
			Random p = new Random();
			bool f = true;
			int[] a = new int[n];
			for (int i = 0; i < n; i++)
			{
				a[i] = p.Next(-100, 100);
				textBox9.Text += a[i] + " ";
			}
			for (int i=0; i<n; i++)
			{
				if (a[i] == 0) continue;
				if (a[i] < 0)
				{
					f = false;
					break;
				}
				else
				{
					f = true;
					break;
				}
			}
			if (f) textBox9.Text += "\r\nПервый встретившийся элемент - положительный";
			else textBox9.Text += "\r\nПервый встретившийся элемент - отрицательный";
		}

		private void button3_click(object sender, EventArgs e)
		{
			textBox7.Clear();
			int n = Convert.ToInt32(textBox6.Text);
			bool f = true;
			Random p = new Random();
			uint[] a = new uint[n];
			for (int i = 0; i < n; i++)
			{
				a[i] =(uint)p.Next(1, 100);
				textBox7.Text += a[i] + " ";
			}
			for (int i=0; i<n-1; i++)
			{
				if (a[i] < a[i + 1]) continue;
				else f = false;
			}
			if (f) textBox7.Text += "\r\nПоследовательность возрастающая";
			else textBox7.Text += "\r\nПоследовательность не возрастающая";
		}

		private void button2_click(object sender, EventArgs e)
        {
			textBox5.Clear();
			int n = Convert.ToInt32(textBox4.Text);
            uint sum = 0;
            Random p = new Random();
            uint[] a = new uint[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = (uint)p.Next(1, 100);
				textBox5.Text += a[i] + " ";
				if ((a[i] % 2) == 0) sum += a[i];
			}
            if (sum == 0) textBox5.Text += "\r\nВ последовательности нет четных элементов";
            else textBox5.Text += "\r\nСумма четных элементов последовательности: " + sum;
        }

        private void button1_click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int n = Convert.ToInt32(textBox3.Text);
            int k = Convert.ToInt32(textBox1.Text);
            uint sum = 0;
            uint[] A = new uint[n];
            Random p = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = (uint)p.Next(1, 100);
				textBox2.Text += A[i] + " ";
				if ((A[i] % k) == 0)
					sum += A[i];
			}
            textBox2.Text += "\r\nСумма: " + sum;
        }

		private void Lab2_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
