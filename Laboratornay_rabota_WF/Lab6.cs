using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratornay_rabota_WF
{
    public partial class Lab6 : Form
    {
        private string[] text_file;
        private string[] str;
        private string[] str1;
        public Lab6()
        {
            InitializeComponent();
            button1.Click += button1_click;
        }

        private void button1_click(object sender, EventArgs e)
        {
            text_file = File.ReadAllText(@"D:\Колледж\Прикладное прогаммирование\6_laboratornaya_rabota\laboratornaya_rabota_6\bin\Debug\Долг.txt", Encoding.Default).Split('\n');
            out_file(text_file);
            out_window(text_file);
        }
        private void out_window(string[] t) 
        {
            for (int i = 0; i < text_file.Length - 1; i++)
            {
                str = text_file[i].Split(';');
                str1 = str[2].Split('.');
                if ((str[1].Trim() == "м") && (str[4].Trim() == "Да"))
                {
                    if (Convert.ToInt32(str1[2]) < 2002)
                    {
                        dataGridView2.RowCount++;
                        for (int j = 0; j < 5; j++)
                        {
                            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[j].Value = str[j];
                            continue;
                        }
                    }
                    if (Convert.ToInt32(str1[2]) == 2002)
                    {
                        if(Convert.ToInt32(str1[1]) < DateTime.Today.Month)
                        {
                            dataGridView2.RowCount++;
                            for (int j = 0; j < 5; j++)
                            {
                                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[j].Value = str[j];
                                continue;
                            }
                        }
                        if(Convert.ToInt32(str1[1]) == DateTime.Today.Month)
                        {
                            if(Convert.ToInt32(str1[0]) >= DateTime.Today.Day)
                            {
                                dataGridView2.RowCount++;
                                for (int j = 0; j < 5; j++)
                                {
                                    dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[j].Value = str[j];
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void out_file(string[] t)
        {
            dataGridView1.RowCount = text_file.Length - 1;
            for (int i = 0; i < text_file.Length - 1; i++)
            {
                str = text_file[i].Split(';');
                for (int j = 0; j < str.Length; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                }
            }
        }
    }
}
