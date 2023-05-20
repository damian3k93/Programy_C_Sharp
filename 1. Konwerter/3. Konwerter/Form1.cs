using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Konwerter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "D";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "E";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "F";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "A";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "B";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "C";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private static int MAX_BASE = 36;
        private static String pattern = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Convert number to given base
        /// </summary>
        /// <param name="n">number to convert</param>
        /// <param name="newBase">base of result</param>
        /// <returns>returns converted n or null if an error occurs</returns>
        public static String convertTo(int n, int newBase)
        {
            String result = "";

            //base is too big or too small
            if ((newBase > MAX_BASE) || (newBase < 2))
                return null;

            //n is equal to 0, do not process, return "0"
            if (n == 0)
                return "0";

            //process until n > 0
            while (n > 0)
            {
                result = pattern[n % newBase] + result;
                n /= newBase;
            }

            return result;
        }

        /// <summary>
        /// Returns value of character in a given base
        /// </summary>

        /// <returns>return value of x or -1 if an error occurs</returns>
        private static int valueOf(char x, int baseOfX)
        {
            for (int i = 0; i < baseOfX; i++)
            {
                if (x == pattern[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Convert n to decimal
        /// </summary>
        /// <param name="n">number to convert</param>
        /// <param name="baseOfN">base of a given n</param>
        /// <returns>returns converted n or 0 if an error occurs</returns>
        public static int convertFrom(String n, int baseOfN)
        {
            int i, x;
            int p = 1;
            int result = 0;

            //base is too big or too small
            if ((baseOfN > MAX_BASE) || (baseOfN < 2))
                return 0;

            n = n.ToUpper();

            for (i = n.Length - 1; i >= 0; i--)
            {
                x = valueOf(n[i], baseOfN);
                if (x < 0)
                {
                    return 0;
                }
                result += (x * p);
                p *= baseOfN;
            }

            return result;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = true;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked && int.Parse(textBox1.Text.Length.ToString()) > 0) //DEC
            {
                label3.Text = textBox1.Text.ToString();
                label4.Text = convertTo(int.Parse(textBox1.Text.ToString()), 16).ToString();
                label2.Text = convertTo(int.Parse(textBox1.Text.ToString()), 8).ToString();
                label1.Text = convertTo(int.Parse(textBox1.Text.ToString()), 2).ToString();
            }
            if (radioButton4.Checked && int.Parse(textBox1.Text.Length.ToString()) > 0) //HEX
            {
                label3.Text = (convertFrom(textBox1.Text.ToString(), 16)).ToString();
                label4.Text = textBox1.Text.ToString();
                label2.Text = convertTo(int.Parse(textBox1.Text.ToString()), 8).ToString();
                label1.Text = convertTo(convertFrom(textBox1.Text.ToString(), 16), 2).ToString();
            }
            if (radioButton2.Checked && int.Parse(textBox1.Text.Length.ToString()) > 0) //OCT
            {
                label3.Text = convertFrom(textBox1.Text.ToString(), 8).ToString();
                label4.Text = convertTo(convertFrom(textBox1.Text.ToString(), 8), 16).ToString();
                label2.Text = textBox1.Text.ToString();
                label1.Text = convertTo(convertFrom(textBox1.Text.ToString(), 8), 2).ToString();
            }
            if (radioButton1.Checked && int.Parse(textBox1.Text.Length.ToString()) > 0) //BIN
            {
                label3.Text = convertFrom(textBox1.Text.ToString(), 2).ToString();
                label4.Text = convertTo(convertFrom(textBox1.Text.ToString(), 2), 16).ToString();
                label2.Text = convertTo(convertFrom(textBox1.Text.ToString(), 2), 8).ToString();
                label1.Text = textBox1.Text.ToString();
            }

            if (int.Parse(textBox1.Text.Length.ToString()) == 0)
            {
                label1.Text = "0";
                label2.Text = "0";
                label3.Text = "0";
                label4.Text = "0";
            }
        }
    }
}
