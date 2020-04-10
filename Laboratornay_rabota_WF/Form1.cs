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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
        }

        void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = toolStripComboBox1.SelectedIndex;

            switch (n)
            {
                case 0:
                    {
                        Lab1 l1 = new Lab1();
                        l1.Show();
                        break;
                    }
                case 1:
                    {
                        Lab2 l2 = new Lab2();
                        l2.Show();
                        break;
                    }
                case 2:
                    {
                        Lab3 l3 = new Lab3();
                        l3.Show();
                        break;
                    }
                case 3:
                    {
                        Lab4 l4 = new Lab4();
                        l4.Show();
                        break;
                    }
                case 4:
                    {
                        Lab5 l5 = new Lab5();
                        l5.Show();
                        break;
                    }
                case 5:
                    {
                        Lab6 l6 = new Lab6();
                        l6.Show();
                        break;
                    }
            }
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
