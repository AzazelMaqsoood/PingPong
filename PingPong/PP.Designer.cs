
namespace PingPong
{
    partial class PP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.Panel();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gameBall = new System.Windows.Forms.PictureBox();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.WhiteSmoke;
            this.background.Controls.Add(this.gameBall);
            this.background.Controls.Add(this.gameover_lbl);
            this.background.Controls.Add(this.points_lbl);
            this.background.Controls.Add(this.score_lbl);
            this.background.Controls.Add(this.racket);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(828, 450);
            this.background.TabIndex = 0;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Tempus Sans ITC", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gameover_lbl.Location = new System.Drawing.Point(306, 56);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(213, 265);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "Game Over\r\n\r\nF1 - Restart\r\nESC - Exit\r\n\r\n";
            this.gameover_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameover_lbl.Visible = false;
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Tempus Sans ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.points_lbl.Location = new System.Drawing.Point(124, 9);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(50, 53);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Tempus Sans ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_lbl.Location = new System.Drawing.Point(12, 9);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(132, 53);
            this.score_lbl.TabIndex = 1;
            this.score_lbl.Text = "Score: ";
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(253, 418);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 2;
            this.racket.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gameBall
            // 
            this.gameBall.Image = global::PingPong.Properties.Resources.ping_pong_clipart_36279;
            this.gameBall.Location = new System.Drawing.Point(236, 88);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(50, 50);
            this.gameBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameBall.TabIndex = 5;
            this.gameBall.TabStop = false;
            // 
            // PP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.background);
            this.Name = "PP";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.PictureBox gameBall;
    }
}

