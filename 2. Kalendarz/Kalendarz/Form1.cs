using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendarz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = comboBox1.Text;
            string o = textBox1.Text;
            string h1 = comboBox2.Text;
            string m1 = comboBox3.Text;
            string h2 = comboBox4.Text;
            string m2 = comboBox5.Text;

            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();



            listBox1.Items.Add(monthCalendar1.SelectionEnd.ToShortDateString() + "  "+h1 + ":" + m1 + "-" + h2 + ":" + m2 + "  " + r + ": " + o);


            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
            textBox1.ResetText();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            textBox4.Text = monthCalendar1.SelectionEnd.ToShortDateString();

            var nazwa = monthCalendar1.SelectionEnd.ToShortDateString();
            if (File.Exists(("C:\\daty\\" + nazwa + ".txt")))
            {

                FileStream f = new FileStream("C:\\daty\\" + nazwa + ".txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader plik = new StreamReader(f);

                foreach (string line in File.ReadLines("C:\\daty\\" + nazwa + ".txt"))
                {
                    if (line != String.Empty) listBox2.Items.Add(plik.ReadLine());
                }

                plik.Close();
            }
            else listBox2.Items.Add("Brak wydarzeń");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var nazwa = monthCalendar1.SelectionEnd.ToShortDateString();

            FileStream f = new FileStream("C:\\daty\\"+nazwa+".txt",FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter plik = new StreamWriter(f);

            foreach(object a in listBox1.Items)
            {
                plik.WriteLine(a.ToString());
            }
            plik.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }


    }
}
