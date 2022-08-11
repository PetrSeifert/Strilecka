namespace Strilecka
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGun = new System.Windows.Forms.Button();
            this.timerFrame = new System.Windows.Forms.Timer(this.components);
            this.timerTarget = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.timerLaser = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLive0 = new System.Windows.Forms.Button();
            this.btnLive1 = new System.Windows.Forms.Button();
            this.btnLive2 = new System.Windows.Forms.Button();
            this.pnlPause = new System.Windows.Forms.Panel();
            this.btnExitToMenu = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.lblPaused = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pnlGameOver = new System.Windows.Forms.Panel();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnExitToMenu2 = new System.Windows.Forms.Button();
            this.btnRestart2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlPause.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGun
            // 
            this.btnGun.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGun.Location = new System.Drawing.Point(220, 468);
            this.btnGun.Margin = new System.Windows.Forms.Padding(1);
            this.btnGun.Name = "btnGun";
            this.btnGun.Size = new System.Drawing.Size(30, 30);
            this.btnGun.TabIndex = 0;
            this.btnGun.UseVisualStyleBackColor = false;
            this.btnGun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnGun_KeyDown);
            // 
            // timerFrame
            // 
            this.timerFrame.Enabled = true;
            this.timerFrame.Interval = 1;
            this.timerFrame.Tick += new System.EventHandler(this.TimerFrame_Tick);
            // 
            // timerTarget
            // 
            this.timerTarget.Interval = 5000;
            this.timerTarget.Tick += new System.EventHandler(this.TimerTarget_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(460, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // timerLaser
            // 
            this.timerLaser.Interval = 300;
            this.timerLaser.Tick += new System.EventHandler(this.TimerLaser_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.btnLive0);
            this.panel1.Controls.Add(this.btnLive1);
            this.panel1.Controls.Add(this.btnLive2);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 30);
            this.panel1.TabIndex = 2;
            // 
            // btnLive0
            // 
            this.btnLive0.BackColor = System.Drawing.Color.Red;
            this.btnLive0.Enabled = false;
            this.btnLive0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLive0.Location = new System.Drawing.Point(45, 8);
            this.btnLive0.Name = "btnLive0";
            this.btnLive0.Size = new System.Drawing.Size(15, 15);
            this.btnLive0.TabIndex = 3;
            this.btnLive0.UseVisualStyleBackColor = false;
            // 
            // btnLive1
            // 
            this.btnLive1.BackColor = System.Drawing.Color.Red;
            this.btnLive1.Enabled = false;
            this.btnLive1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLive1.Location = new System.Drawing.Point(24, 8);
            this.btnLive1.Name = "btnLive1";
            this.btnLive1.Size = new System.Drawing.Size(15, 15);
            this.btnLive1.TabIndex = 3;
            this.btnLive1.UseVisualStyleBackColor = false;
            // 
            // btnLive2
            // 
            this.btnLive2.BackColor = System.Drawing.Color.Red;
            this.btnLive2.Enabled = false;
            this.btnLive2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLive2.Location = new System.Drawing.Point(3, 8);
            this.btnLive2.Name = "btnLive2";
            this.btnLive2.Size = new System.Drawing.Size(15, 15);
            this.btnLive2.TabIndex = 2;
            this.btnLive2.UseVisualStyleBackColor = false;
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlPause.Controls.Add(this.btnExitToMenu);
            this.pnlPause.Controls.Add(this.btnRestart);
            this.pnlPause.Controls.Add(this.btnResume);
            this.pnlPause.Controls.Add(this.lblPaused);
            this.pnlPause.Location = new System.Drawing.Point(105, 105);
            this.pnlPause.Margin = new System.Windows.Forms.Padding(96);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(290, 290);
            this.pnlPause.TabIndex = 3;
            // 
            // btnExitToMenu
            // 
            this.btnExitToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExitToMenu.Location = new System.Drawing.Point(70, 215);
            this.btnExitToMenu.Margin = new System.Windows.Forms.Padding(70, 3, 70, 3);
            this.btnExitToMenu.Name = "btnExitToMenu";
            this.btnExitToMenu.Size = new System.Drawing.Size(150, 50);
            this.btnExitToMenu.TabIndex = 1;
            this.btnExitToMenu.TabStop = false;
            this.btnExitToMenu.Text = "EXIT TO MENU";
            this.btnExitToMenu.UseVisualStyleBackColor = true;
            this.btnExitToMenu.Click += new System.EventHandler(this.BtnExitToMenu_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRestart.Location = new System.Drawing.Point(70, 145);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(70, 3, 70, 3);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 50);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.TabStop = false;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResume.Location = new System.Drawing.Point(70, 74);
            this.btnResume.Margin = new System.Windows.Forms.Padding(70, 3, 70, 3);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(150, 50);
            this.btnResume.TabIndex = 0;
            this.btnResume.TabStop = false;
            this.btnResume.Text = "RESUME";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // lblPaused
            // 
            this.lblPaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPaused.Location = new System.Drawing.Point(0, 0);
            this.lblPaused.Name = "lblPaused";
            this.lblPaused.Size = new System.Drawing.Size(290, 56);
            this.lblPaused.TabIndex = 0;
            this.lblPaused.Text = "PAUSED";
            this.lblPaused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMenu.Controls.Add(this.lblName);
            this.pnlMenu.Controls.Add(this.btnEnd);
            this.pnlMenu.Controls.Add(this.btnHighScores);
            this.pnlMenu.Controls.Add(this.btnStartGame);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(500, 500);
            this.pnlMenu.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(500, 61);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "LASER";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnd.Location = new System.Drawing.Point(175, 250);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(150, 50);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.TabStop = false;
            this.btnEnd.Text = "END";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.BtnKonec_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHighScores.Location = new System.Drawing.Point(175, 164);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(150, 50);
            this.btnHighScores.TabIndex = 1;
            this.btnHighScores.TabStop = false;
            this.btnHighScores.Text = "HIGH SCORES";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartGame.Location = new System.Drawing.Point(175, 79);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(150, 50);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.TabStop = false;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // pnlGameOver
            // 
            this.pnlGameOver.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlGameOver.Controls.Add(this.lblScore2);
            this.pnlGameOver.Controls.Add(this.lblGameOver);
            this.pnlGameOver.Controls.Add(this.btnExitToMenu2);
            this.pnlGameOver.Controls.Add(this.btnRestart2);
            this.pnlGameOver.Location = new System.Drawing.Point(0, 0);
            this.pnlGameOver.Name = "pnlGameOver";
            this.pnlGameOver.Size = new System.Drawing.Size(500, 500);
            this.pnlGameOver.TabIndex = 5;
            this.pnlGameOver.Visible = false;
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore2.Location = new System.Drawing.Point(189, 61);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(61, 20);
            this.lblScore2.TabIndex = 2;
            this.lblScore2.Text = "Score:";
            // 
            // lblGameOver
            // 
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(0, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(500, 61);
            this.lblGameOver.TabIndex = 1;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitToMenu2
            // 
            this.btnExitToMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExitToMenu2.Location = new System.Drawing.Point(175, 225);
            this.btnExitToMenu2.Name = "btnExitToMenu2";
            this.btnExitToMenu2.Size = new System.Drawing.Size(150, 50);
            this.btnExitToMenu2.TabIndex = 1;
            this.btnExitToMenu2.TabStop = false;
            this.btnExitToMenu2.Text = "EXIT TO MENU";
            this.btnExitToMenu2.UseVisualStyleBackColor = true;
            this.btnExitToMenu2.Click += new System.EventHandler(this.BtnExitToMenu2_Click);
            // 
            // btnRestart2
            // 
            this.btnRestart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRestart2.Location = new System.Drawing.Point(172, 135);
            this.btnRestart2.Name = "btnRestart2";
            this.btnRestart2.Size = new System.Drawing.Size(150, 50);
            this.btnRestart2.TabIndex = 1;
            this.btnRestart2.TabStop = false;
            this.btnRestart2.Text = "RESTART";
            this.btnRestart2.UseVisualStyleBackColor = true;
            this.btnRestart2.Click += new System.EventHandler(this.BtnRestart2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlGameOver);
            this.Controls.Add(this.pnlPause);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strilecka";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPause.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlGameOver.ResumeLayout(false);
            this.pnlGameOver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGun;
        private System.Windows.Forms.Timer timerFrame;
        private System.Windows.Forms.Timer timerTarget;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timerLaser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLive2;
        private System.Windows.Forms.Button btnLive0;
        private System.Windows.Forms.Button btnLive1;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Button btnExitToMenu;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label lblPaused;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Panel pnlGameOver;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button btnExitToMenu2;
        private System.Windows.Forms.Button btnRestart2;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Button btnHighScores;
    }
}

