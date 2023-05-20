using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortowanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool los = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox3.Text == string.Empty))
            {
                MessageBox.Show("Podaj ile liczb wylosować!");
            }
            else
            {
                int d = int.Parse(textBox3.Text);
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                Random rand = new Random();
                int[] array = new int[d];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 1000);
                }
                foreach (int i in array)
                {
                    textBox1.Text = textBox1.Text + i.ToString() + " ";
                }
                los = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            los = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            string a = textBox1.Text.ToString();
            if (!(los) && (a == string.Empty))
            {
                MessageBox.Show("Nie podano liczb!");
            }
            else
            {
                if (los)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                }
                a = textBox1.Text.ToString();
                string[] words = a.Split(' ');
                int[] liczby = new int[words.Length];
                for (int b = 0; b < liczby.Length; b++)
                {
                    liczby[b] = int.Parse(words[b]);
                }
                int tmp, ip, ik, i;
                for (int j = liczby.Length - 2; j >= 0; j--)
                {
                    tmp = liczby[j];
                    ip = j;
                    ik = liczby.Length;
                    while (ik - ip > 1)
                    {
                        i = (ip + ik) / 2;
                        if (tmp <= liczby[i])
                        {
                            ik = i;
                        }
                        else
                        {
                            ip = i;
                        }
                    }
                    for (i = j; i < ip; i++)
                    {
                        liczby[i] = liczby[i + 1];
                    }
                    liczby[ip] = tmp;
                }
                foreach (int c in liczby)
                {
                    textBox2.Text = textBox2.Text + c.ToString() + " ";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            string a = textBox1.Text.ToString();
            if (!(los) && (a == string.Empty))
            {
                MessageBox.Show("Nie podano liczb!");
            }
            else
            {
                if (los)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                }
                a = textBox1.Text.ToString();
                string[] words = a.Split(' ');
                int[] liczby = new int[words.Length];
                for (int b = 0; b < liczby.Length; b++)
                {
                    liczby[b] = int.Parse(words[b]);
                }

                int n = liczby.Length;
                do
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        if (liczby[i] > liczby[i + 1])
                        {
                            int tmp = liczby[i];
                            liczby[i] = liczby[i + 1];
                            liczby[i + 1] = tmp;
                        }
                    }
                    n--;
                }
                while (n > 1);

                foreach (int c in liczby)
                {
                    textBox4.Text = textBox4.Text + c.ToString() + " ";
                }
            }
        }
    }
}
