using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingpong
{
    public partial class Form1 : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None; 
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playGround.Bottom - (playGround.Bottom / 10); // ustawienie pozycji

            gameOver.Left = (playGround.Width / 2) - (gameOver.Width / 2);
            gameOver.Top = (playGround.Height / 2) - (gameOver.Height / 2);
            gameOver.Visible = false;
        

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if(ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right) // kolizje platformy
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points++;
                scoreCount.Text = points.ToString();
            }

            if(ball.Left <= playGround.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >= playGround.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playGround.Top)
            {
                speed_top = -speed_top;
            }

            if(ball.Bottom >= playGround.Bottom)
            {
                timer1.Enabled = false;
                gameOver.Visible = true;
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                scoreCount.Text = "0";
                timer1.Enabled = true;
                gameOver.Visible = false;
            }
        }

    }
}
