namespace PingPong
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.ball2 = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.time);
            this.gamePanel.Controls.Add(this.lScore);
            this.gamePanel.Controls.Add(this.ball2);
            this.gamePanel.Controls.Add(this.racket);
            this.gamePanel.Controls.Add(this.ball1);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(800, 450);
            this.gamePanel.TabIndex = 0;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(357, 24);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(12, 20);
            this.time.TabIndex = 5;
            this.time.Text = "l";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lScore.Location = new System.Drawing.Point(357, 0);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(15, 24);
            this.lScore.TabIndex = 3;
            this.lScore.Text = "l";
            this.lScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lScore.Visible = false;
            // 
            // ball2
            // 
            this.ball2.Image = global::PingPong.Properties.Resources.Ball02;
            this.ball2.Location = new System.Drawing.Point(515, 72);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(20, 20);
            this.ball2.TabIndex = 2;
            this.ball2.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket.Location = new System.Drawing.Point(314, 394);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(161, 17);
            this.racket.TabIndex = 1;
            this.racket.TabStop = false;
            // 
            // ball1
            // 
            this.ball1.BackColor = System.Drawing.SystemColors.Control;
            this.ball1.Image = global::PingPong.Properties.Resources.Ball01;
            this.ball1.Location = new System.Drawing.Point(314, 179);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(20, 20);
            this.ball1.TabIndex = 0;
            this.ball1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamePanel);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball2;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label time;
    }
}