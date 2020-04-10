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
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += checkBox1_checkedchanged;
            checkBox2.CheckedChanged += checkBox2_checkedchanged;
            checkBox3.CheckedChanged += checkBox3_checkedchanged;
            button1.Click += button1_click;
        }

        private void button1_click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Parallelogram Par = new Parallelogram();
                Par._S1 = Convert.ToDouble(textBox1.Text);
                Par._S2 = Convert.ToDouble(textBox2.Text);
                Par._Ug1 = Convert.ToDouble(textBox3.Text);
                textBox4.Text = "" + Par.Square();
                textBox5.Text = "" + Par.Perimetr();
            }
            if (checkBox1.Checked)
            {
                Triangle Tri = new Triangle();
                Tri._S1 = Convert.ToDouble(textBox11.Text);
                Tri._S2 = Convert.ToDouble(textBox10.Text);
                Tri._Ug1 = Convert.ToDouble(textBox9.Text);
                textBox8.Text = "" + Tri._S3;
                textBox7.Text = "" + Tri.Square();
                textBox6.Text = "" + Tri.Perimetr();
            }
            if (checkBox3.Checked)
            {
                Circle Cir = new Circle();
                Cir._S1 = Convert.ToDouble(textBox13.Text);
                textBox12.Text = "" + Cir.Run_Circle();
            }
        }

        private void checkBox3_checkedchanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox11.Clear();
                textBox10.Clear();
                textBox9.Clear();
                textBox8.Clear();
                textBox7.Clear();
                textBox6.Clear();
                textBox13.ReadOnly = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else
            {
                textBox13.ReadOnly = true;
            }
        }

        private void checkBox2_checkedchanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox13.Clear();
                textBox12.Clear();
                textBox11.Clear();
                textBox10.Clear();
                textBox9.Clear();
                textBox8.Clear();
                textBox7.Clear();
                textBox6.Clear();
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                textBox13.Clear();
                textBox12.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
            }
        }

        private void checkBox1_checkedchanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox11.ReadOnly = false;
                textBox10.ReadOnly = false;
                textBox9.ReadOnly = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                textBox11.ReadOnly = true;
                textBox10.ReadOnly = true;
                textBox9.ReadOnly = true;
            }
        }
    }
}
