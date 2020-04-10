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
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
			button1.Click += button1_click;
        }
        public void Print()
        {
            textBox4.Text += "Первая сторона треугольника: ";
            textBox4.Text += "Вторая сторона треугольника: ";
            textBox4.Text += "Третья сторона треугольника: ";
            textBox4.Text += "Угол между первой и второй сторонами треугольника: ";
            textBox4.Text += "Угол между второй и третьей сторонами треугольника: ";
            textBox4.Text += "Угол между первой и третьей сторонами треугольника: ";
            textBox4.Text += "Периметр треугольника: ";
            textBox4.Text += "Площадь треугольника: ";
        }
		private void button1_click(object sender, EventArgs e)
		{
            textBox4.Clear();
            Tri A = new Tri();
            double a = Convert.ToInt32(textBox1.Text);
            A._S1 = a;
            double b = Convert.ToInt32(textBox2.Text);
            A._S2 = b;
            double ab = Convert.ToInt32(textBox3.Text);
            A._Ug1 = ab;
            A.S3();
            A.Ug2();
            A.Ug3();
            A.Perimetr();
            A.Square();
            textBox4.Text += "Первая сторона треугольника: " + A._S1;
            textBox4.Text += "\r\nВторая сторона треугольника: " + A._S2;
            textBox4.Text += "\r\nТретья сторона треугольника: " + A._S3;
            textBox4.Text += "\r\nУгол между первой и второй сторонами треугольника: " + A._Ug1;
            textBox4.Text += "\r\nУгол между второй и третьей сторонами треугольника: " + A._Ug2;
            textBox4.Text += "\r\nУгол между первой и третьей сторонами треугольника: " + A._Ug3;
            textBox4.Text += "\r\nПериметр треугольника: " + A._Per;
            textBox4.Text += "\r\nПлощадь треугольника: " + A._Squ;
        }
        
	}
}
