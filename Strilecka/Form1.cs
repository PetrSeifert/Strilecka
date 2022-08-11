using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strilecka
{
    public partial class Form1 : Form
    {
        Button laser = new Button();
        Button target = new Button();
        Random random = new Random();
        private int score;
        private int lives;
        private int x;
        private const int y = 470;
        public Form1()
        {
            InitializeComponent();
            pnlPause.Visible = false;
        }

        private void GameStart()
        {
            BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            x = 250;
            score = 0;
            btnLive0.Visible = true;
            btnLive1.Visible = true;
            btnLive2.Visible = true;
            lives = 3;
            timerTarget.Interval = 5000;
            btnGun.Enabled = true;
            btnGun.Select();
            btnGun.Location = new Point(x, y);
            lblScore.Text = score.ToString();
            Target();
            timerTarget.Enabled = true;
        }

        private void GameOver()
        {
            timerTarget.Enabled = false;
            lblScore2.Text = String.Format("Score: {0}", score);
            pnlGameOver.Visible = true;
        }

        private void Laser()
        {
            laser.Visible = true;
            laser.Enabled = false;
            laser.FlatStyle = FlatStyle.Popup;
            laser.Location = new Point(x + 10, 0);
            laser.Size = new Size(10, 470);
            laser.BackColor = Color.DarkRed;
            laser.Parent = this;
        }

        private void Target()
        {
            target.Visible = true;
            target.Enabled = false;
            target.FlatStyle = FlatStyle.Popup;
            target.Location = new Point(random.Next(1, 46) * 10, random.Next(3, 40) * 10);
            target.Size = new Size(10, 10);
            target.BackColor = Color.DarkGreen;
            target.Parent = this;
        }

        private void BtnGun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timerTarget.Stop();
                btnGun.Enabled = false;
                pnlPause.Visible = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                timerLaser.Start();
                Laser();
                if (laser.Location.X == target.Location.X)
                {
                    this.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                    score++;
                    lblScore.Text = score.ToString();
                    timerTarget.Enabled = false;
                    if (timerTarget.Interval > 2700) 
                        timerTarget.Interval -= 100;
                    Target();
                    timerTarget.Enabled = true;
                }
            }

            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && x > 0)
            {
                laser.Visible = false;
                x -= 10;
            }

            if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && x < 470)
            {
                laser.Visible = false;
                x += 10;
            }
        }

        private void TimerFrame_Tick(object sender, EventArgs e)
        {
            btnGun.Location = new Point(x, y);
        }

        private void TimerTarget_Tick(object sender, EventArgs e)
        {
            lives--;
            if (lives == 2)
                btnLive0.Visible = false;
            else if (lives == 1)
                btnLive1.Visible = false;
            else
            {
                btnLive2.Visible = false;
                GameOver();
            }
            Target();
        }

        private void TimerLaser_Tick(Object sender, EventArgs e)
        {
            laser.Visible = false;
            timerLaser.Stop();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            pnlPause.Visible = false;
            btnGun.Enabled = true;
            btnGun.Select();
            timerTarget.Start();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            pnlPause.Visible = false;
            GameStart();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            GameStart();
        }

        private void BtnKonec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExitToMenu_Click(object sender, EventArgs e)
        {
            pnlPause.Visible = false;
            pnlMenu.Visible = true;
        }
         
        private void BtnRestart2_Click(object sender, EventArgs e)
        {
            pnlGameOver.Visible = false;
            GameStart();
        }

        private void BtnExitToMenu2_Click(object sender, EventArgs e)
        {
            pnlGameOver.Visible = false;
            pnlMenu.Visible = true;
        }
    }
}
