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
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
			button1.Click += button1_click;
			button2.Click += button2_click;
			button3.Click += button3_click;
			button4.Click += button4_click;
        }

		private void button4_click(object sender, EventArgs e)
		{
            textBox8.Clear();
			string str = textBox6.Text;
			str = str.Trim();
            for (int i = 50; i >= 2; --i)
            {
                string space = new string(' ', i);
                str = str.Replace(space, " ");
            }
            bool p = true;
            string ln = "";
            string fn = "";
            string mn = "";
            string[] parts = str.Trim().Split(' ');
            ln = parts[0];
            textBox8.Text += ln;
            if (parts.Length > 1)
            {
                fn = parts[1][0].ToString().ToUpper();
                textBox8.Text += " " + fn + ".";
            }
            if (parts.Length > 2)
            {
                mn = parts[2][0].ToString().ToUpper();
                textBox8.Text += " " + mn + ".";
            }
            if (parts.Length > 2) if ((parts[2][parts[2].Length - 1]) == 'а') p = false;
                else if ((parts[0][parts[0].Length - 1]) == 'а') p = false;
            if (p) textBox8.Text += " пол: мужской";
            else textBox8.Text += " пол:  женский";
		}

		private void button3_click(object sender, EventArgs e)
		{
			textBox7.Clear();
			string str = textBox5.Text;
			char[] ch_str;
			ch_str = str.ToCharArray();
			for (int i = 0; i < ch_str.Length; i++)
			{
				if (ch_str[i] == 'П' || ch_str[i] == 'п') ch_str[i] = ' ';
				if (ch_str[i] == 'К' || ch_str[i] == 'к') ch_str[i] = '.';
				if (ch_str[i] == 'С' || ch_str[i] == 'с') ch_str[i] = '-';
			}
			str = string.Join("", ch_str);
			textBox7.Text = "Строка: " + str;
		}

		private void button2_click(object sender, EventArgs e)
		{
			textBox4.Clear();
			string str = textBox3.Text;
            str.Trim();
			for (int i = 50; i >= 2; --i)
			{
				string space = new string(' ', i);
				str = str.Replace(space, " ");
			}
			string[] words = str.Split(' ');
			char[] word;
			for (int i = 0; i < words.Length; i++)
			{
				word = words[i].ToCharArray();
				word[0] = char.ToUpper(word[0]);
				words[i] = string.Join("", word);
			}
			str = string.Join(" ", words);
			textBox4.Text = "Строка: " + str;
		}

		private void button1_click(object sender, EventArgs e)
		{
			textBox2.Clear();
			bool f = true;
			string str = textBox1.Text;
			str = str.ToLower().Trim();
			for (int i = 0, n = 0, k = 0; i < str.Length / 2; i++)
			{
				if (str[i + n] == ' ') n++;
				if (str[str.Length - i - k - 1] == ' ') k++;
				if (str[i + n] != str[str.Length - i - k - 1])
				{
					f = false;
					break;
				}
			}
			if (f)
				textBox2.Text = "Данная строка является палиндромом";
			else
				textBox2.Text = "Данная строка не является палиндромом";		}

		
	}
}
