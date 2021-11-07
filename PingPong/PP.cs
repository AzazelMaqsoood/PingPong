using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPong
{

    public partial class PP : Form
    {
        public int speedLeft = 4;
        public int speedTop = 4;
        public int points = 0;

        public PP()
        {

            InitializeComponent();

            timer.Enabled = true;
            Cursor.Hide();      //Hide the cursor

            FormBorderStyle = FormBorderStyle.None;        //Remove any borders
            TopMost = true;         //Bring the form to the front
            Bounds = Screen.PrimaryScreen.Bounds;       //Make it fullscreen

            racket.Top = background.Bottom - (background.Bottom / 10);      //Set the position of the racket

            gameover_lbl.Left = (background.Width / 2) - (gameover_lbl.Width / 2);
            gameover_lbl.Top = (background.Height / 2) - (gameover_lbl.Height / 2);
            gameover_lbl.Visible = false;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                gameBall.Top = 50;
                gameBall.Left = 50;
                speedLeft = 4;
                speedTop = 4;
                points = 0;
                points_lbl.Text = "0";
                timer.Enabled = true;
                gameover_lbl.Visible = false;
                background.BackColor = Color.White;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            gameBall.Left += speedLeft;
            gameBall.Top += speedTop;

            if (gameBall.Bottom >= racket.Top && gameBall.Bottom <= racket.Bottom
                && gameBall.Left >= racket.Left && gameBall.Right <= racket.Right)
            {
                speedTop += 2;
                speedLeft += 2;
                speedTop = -speedTop;
                points += 1;
                points_lbl.Text = points.ToString();

                Random rand = new();
                background.BackColor = Color.FromArgb(rand.Next(150, 255), rand.Next(150, 255), rand.Next(150, 255));       //Randomize color of BG
            }


            if (gameBall.Left <= background.Left)
            {
                speedLeft = -speedLeft;
            }

            if (gameBall.Right >= background.Right)
            {
                speedLeft = -speedLeft;
            }

            if (gameBall.Top <= background.Top)
            {
                speedTop = -speedTop;
            }

            if (gameBall.Bottom >= background.Bottom)
            {
                timer.Enabled = false;
                gameover_lbl.Visible = true;
            }

        }
    }
}
