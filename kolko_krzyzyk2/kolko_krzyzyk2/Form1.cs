using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko_krzyzyk2
{
    public partial class Form1 : Form
    {
        bool tura = true;
        int liczbaTur = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gra Kółko i krzyżyk", "Kółko i krzyżyk About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (tura)
                b.Text = "X";
            else
                b.Text = "O";

            tura = !tura;
            b.Enabled = false;
            liczbaTur++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool zwyciezca = false;

                if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
                    zwyciezca = true;
                else if ((A4.Text == A5.Text) && (A5.Text == A6.Text) && (!A4.Enabled))
                    zwyciezca = true;
                else if ((A7.Text == A8.Text) && (A8.Text == A9.Text) && (!A7.Enabled))
                    zwyciezca = true;

                else if ((A1.Text == A4.Text) && (A4.Text == A7.Text) && (!A1.Enabled))
                    zwyciezca = true;
                else if ((A2.Text == A5.Text) && (A5.Text == A8.Text) && (!A2.Enabled))
                    zwyciezca = true;
                else if ((A3.Text == A6.Text) && (A6.Text == A9.Text) && (!A3.Enabled))
                    zwyciezca = true;

                else if ((A1.Text == A5.Text) && (A5.Text == A9.Text) && (!A1.Enabled))
                    zwyciezca = true;
                else if ((A3.Text == A5.Text) && (A5.Text == A7.Text) && (!A7.Enabled))
                    zwyciezca = true;

            if (zwyciezca)
                {
                    disableButtons();

                    String winner = "";
                    if (tura)
                        winner = "O";
                    else
                        winner = "X";

                    MessageBox.Show(winner + " wygrał!!!", "Wynik");
                }
                else
                {
                    if(liczbaTur == 9)
                          MessageBox.Show("Remis!!!", "Wynik");
                }
            }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tura = true;
            liczbaTur = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }

        }
    }
}

