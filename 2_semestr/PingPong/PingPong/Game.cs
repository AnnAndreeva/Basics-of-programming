using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Game : Form
    {   
        public double speed1_left = 3, speed1_top = 3;
        public double speed2_left = 3, speed2_top = 3;
       


        public Game()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.TopMost = true;
            this.DoubleBuffered = true;

            racket.Top = gamePanel.Bottom - (gamePanel.Bottom / 10);
        }

        DateTime date1 = new DateTime(0, 0);
        private void Timer1_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddSeconds(1);
            time.Text = date1.ToString("mm:ss");

            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball1.Left += (int)speed1_left;
            ball1.Top += (int)speed1_top;


            if (racket.Bounds.IntersectsWith(ball1.Bounds) && ball1.Bottom >= racket.Top)
            {
                if ((ball1.Left < ((racket.Right - racket.Left)/2)))
                {
                    speed1_left = -speed1_left;
                }
                speed1_left += (racket.Left - ball1.Left) / 100;
                ball1.Top -= 5;
                speed1_top += (racket.Left - ball1.Left) / 140;

                speed1_top = -speed1_top;
                ball1.Refresh();
            }
                                 
            if (ball1.Left <= gamePanel.Left)
            {
                speed1_left = -speed1_left;
            }

            if (ball1.Right >= gamePanel.Right)
            {
                speed1_left = -speed1_left;
            }

            if (ball1.Top <= gamePanel.Top)
            {
                speed1_top = -speed1_top;
            }

            if ((ball1.Bottom >= gamePanel.Bottom) || ((ball1.Left == racket.Right|| ball1.Right == racket.Left) 
                && ball1.Top >= racket.Top ))
             
            {
                timer1.Enabled = false;
                Cursor.Show();
                DialogResult result = MessageBox.Show("Игра окончена!");


                if (result == DialogResult.OK)
                { this.Close(); }
            }

            ball2.Left -= (int)speed2_left;
            ball2.Top += (int)speed2_top;

            //ball2.Bottom >= racket.Top && ball2.Left >= racket.Left && ball2.Right <= racket.Right
            if (racket.Bounds.IntersectsWith(ball2.Bounds) && ball2.Bottom >= racket.Top)
            {
                if ((ball2.Left < ((racket.Right - racket.Left) / 2)))
                {
                    speed2_left = -speed2_left;
                }
                speed2_left += (racket.Left - ball2.Left) / 100;
                ball2.Top -= 5;
                speed2_top += (racket.Left - ball2.Left) / 140;

                speed2_top = -speed2_top;
                ball2.Refresh();

            }

            if (ball2.Left <= gamePanel.Left)
            {
                speed2_left = -speed2_left;
            }

            if (ball2.Right >= gamePanel.Right)
            {
                speed2_left = -speed2_left;
            }

            if (ball2.Top <= gamePanel.Top)
            {
                speed2_top = -speed2_top;
            }

            if ((ball2.Bottom >= gamePanel.Bottom) || ((ball2.Left == racket.Right || ball2.Right == racket.Left)
                && ball2.Top >= racket.Top ))
            {
                timer1.Enabled = false;
                Cursor.Show();
                DialogResult result = MessageBox.Show("Игра окончена!");

                if (result == DialogResult.OK)
                { this.Close(); }
            }

        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close();}
        }
    }
}
