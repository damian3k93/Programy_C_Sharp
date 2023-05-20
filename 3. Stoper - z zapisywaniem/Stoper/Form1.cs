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

namespace Stoper
{
    public partial class Form1 : Form
    {
        String urldata = "stoper.txt";
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(urldata))
            {
                string[] lines = File.ReadAllLines(urldata, Encoding.UTF8);
                listBox1.Items.AddRange(lines);
            }
            else
                File.Create(urldata);
            StartElements();
        }

         int hour, min, sec, ms = 0;




        private void StartElements()
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
        }
        private void StartTime()
        {
            hours.Text = hour.ToString("00");
            minutes.Text = min.ToString("00");
            seconds.Text = sec.ToString("00");
            miliseconds.Text = ms.ToString("0");
        }

        private void AddMilisecond()
        {
            if(ms == 9)
            {
                ms = 0;
                AddSecond();
            }
            else
            {
                ms++;
            }
        }

        private void AddSecond()
        {
            if(sec == 59)
            {
                sec = 0;
                AddMinute();
            }
            else
            {
                sec++;
            }
        }

        private void AddMinute()
        {
            if(min == 59)
            {
                min = 0;
                AddHour();
            }
            else
            {
                min++;
            }
        }

        private void AddHour()
        {
            hour++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            if (listBox1.Items.Count > 0)
            {
                button5.Enabled = true;
                button6.Enabled = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(hours.Text+":"+minutes.Text+ ":" + seconds.Text + ":" + miliseconds.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            if (listBox1.Items.Count == 0)
            {
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            object[] a = new object[listBox1.Items.Count];
            listBox1.Items.CopyTo(a, 0);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(a[i]);
                comboBox2.Items.Add(a[i]);
            }
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            button10.Enabled = true;
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string p1 = comboBox1.SelectedItem.ToString();
            string[] x = p1.Split(new char[] {':'});

            int hourP1 = Int32.Parse(x[0]);
            int minP1 = Int32.Parse(x[1]);
            int secP1 = Int32.Parse(x[2]);
            int msP1 = Int32.Parse(x[3]);
            int msTime1 = (hourP1 * 60 * 60 * 1000) + (minP1 * 60 * 1000) + (secP1 * 1000) + msP1*100;

            textBox1.Text = msTime1.ToString();

            string p2 = comboBox2.SelectedItem.ToString();
            string[] y = p2.Split(new char[] { ':' });

            int hourP2 = Int32.Parse(y[0]);
            int minP2 = Int32.Parse(y[1]);
            int secP2 = Int32.Parse(y[2]);
            int msP2 = Int32.Parse(y[3]);
            int msTime2 = (hourP2 * 60 * 60 * 1000) + (minP2 * 60 * 1000) + (secP2 * 1000) + msP2*100;

            textBox2.Text = msTime2.ToString();

            button8.Enabled = true;
            button9.Enabled = true;
            button12.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int pom1 = Int32.Parse(textBox1.Text);
            int pom2 = Int32.Parse(textBox2.Text);
            int roznica = Math.Abs(pom2-pom1);

            textBox3.Text = roznica.ToString();

            button12.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int pom1 = Int32.Parse(textBox1.Text);
            int pom2 = Int32.Parse(textBox2.Text);
            int suma = Math.Abs(pom2 + pom1);

            textBox3.Text = suma.ToString();

            button12.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int ms = Int32.Parse(textBox3.Text);

            int wynik = ms / 1000;
            int reszta = ms % 1000;

            textBox4.Text = wynik.ToString();
            textBox5.Text = reszta.ToString();
        }

        private void button11_Click(object sender, EventArgs e)

        {
            string tekst = "";

            foreach (string li in listBox1.Items)
            {
                tekst += li + Environment.NewLine;
            }

            File.WriteAllText(urldata, tekst);
            MessageBox.Show("Zapisano");
        }


        //{
        //    FileStream f = new FileStream("c:\\nowy.txt", FileMode.Create, FileAccess.Write);
        //    StreamWriter plik = new StreamWriter(f);
        //
        //    foreach (object a in listBox1.Items)
        //      {
        //        plik.WriteLine(a.ToString());
        //    }
        //   plik.Close();
        // }

        private void button3_Click(object sender, EventArgs e)
        {
         
            hour = 0;
            min = 0;
            sec = 0;
            ms = 0;
            StartTime();
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AddMilisecond();
            StartTime();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
            button4.Enabled = true;
        }


    }
}
