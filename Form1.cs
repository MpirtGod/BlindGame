using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Game_2._0
{
    public partial class Form1 : Form
    {
        int stepsInterval;
        Player player;
        Enemy enemy;
        PictureBox playerSteps;
        PictureBox enemyImage;
        public int Loud ;

        WindowsMediaPlayer Step;
        WindowsMediaPlayer Die;
        WindowsMediaPlayer Music;
        WindowsMediaPlayer Clicks;


        LastMove lastMove = LastMove.Right;
        
        enum LastMove
        {
            Left,
            Right,
            Up,
            Down
        }

        public Form1()
        {
            DoubleBuffered = true;
            BackColor = Color.Black;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stepsInterval = 300;
            Loud = SoundControl.Volume * 2;

            Step = new WindowsMediaPlayer
            {
                URL = "Sounds\\Steps.mp3"
            };
            if (Loud != 0) Step.settings.volume = Loud + 1;
            else Step.settings.volume = 0;
            Step.controls.stop();

            Clicks = new WindowsMediaPlayer
            {
                URL = "Sounds\\Click.mp3"
            };
            Clicks.settings.volume = Loud;
            Clicks.controls.stop();


            Music = new WindowsMediaPlayer
            {
                URL = "Sounds\\Music.mp3"
            };
            Music.settings.setMode("loop", true);
            Music.settings.volume = Loud;

            Die = new WindowsMediaPlayer
            {
                URL = "Sounds\\Die.mp3"
            };
            Die.settings.volume = Loud;
            Die.controls.stop();

            player = new Player(220, 220);
            playerSteps = new PictureBox
            {
                Image = player.playerSteps,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = player.x,
                Top = player.y,
                ClientSize = new Size(player.sizeX, player.sizeY)
            };
            this.Controls.Add(playerSteps);
            
            enemy = new Enemy(1000, 10);
            enemyImage = new PictureBox
            {
                Image = enemy.enemyPNG,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = enemy.x,
                Top = enemy.y,
                ClientSize = new Size(enemy.sizeX, enemy.sizeY),
                Visible = false
            };
            this.Controls.Add(enemyImage);
            Music.controls.play();

            EnemyMoveTimer.Start();
        }

        private void VisibleTrueTimer_Tick(object sender, EventArgs e)
        {
            enemyImage.Visible = false;
            VisibleTrueTimer.Stop();
        }

        private void EnemyMove_Tick(object sender, EventArgs e)
        {
            EnemyMoveTimer.Interval = 500;

            var angle = GetPlayerSinAndCos(new Point(enemyImage.Left, enemyImage.Top), new Point(playerSteps.Left, playerSteps.Top));

            enemyImage.Left += playerSteps.Left <= enemyImage.Left ? (int) (-enemy.speed * angle[1]) : (int) (enemy.speed * angle[1]);
            enemyImage.Top += playerSteps.Top >= enemyImage.Top ? (int) (enemy.speed* angle[0]) : (int)(-enemy.speed * angle[0]) ;
            Intersect();
        }

        private void MoveLeftTimer_Tick(object sender, EventArgs e)
        {
            MoveLeftTimer.Interval = stepsInterval;
            if (GameOver.Visible != true) Step.controls.play();
            if (playerSteps.Left > player.sizeX)
                playerSteps.Left -= player.speed;

            playerSteps.Image = lastMove == LastMove.Right ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), 180f)
                : lastMove == LastMove.Up ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), -90f)
                : lastMove == LastMove.Down ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), 90f) : playerSteps.Image;
            playerSteps.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            lastMove = LastMove.Left;
            enemyImage.Visible = true;
            VisibleTrueTimer.Start();
        }

        private void MoveRightTimer_Tick(object sender, EventArgs e)
        {
            MoveRightTimer.Interval = stepsInterval;
            if (GameOver.Visible != true) Step.controls.play();
            if (playerSteps.Left < (Width-2*player.sizeX))
                playerSteps.Left += player.speed;

            playerSteps.Image = lastMove == LastMove.Left ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), 180f)
               : lastMove == LastMove.Up ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), 90f)
               : lastMove == LastMove.Down ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), -90f) : playerSteps.Image;
            playerSteps.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            lastMove = LastMove.Right;
            enemyImage.Visible = true;
            VisibleTrueTimer.Start();
        }

        private void MoveUpTimer_Tick(object sender, EventArgs e)
        {
            MoveUpTimer.Interval = stepsInterval;
            if (GameOver.Visible != true) Step.controls.play();
            if (playerSteps.Top > player.sizeY)
                playerSteps.Top -= player.speed;

            playerSteps.Image = lastMove == LastMove.Right ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), -90f)
               : lastMove == LastMove.Down ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), 180f)
               : lastMove == LastMove.Left ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), 90f) : playerSteps.Image;
            playerSteps.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            lastMove = LastMove.Up;
            enemyImage.Visible = true;
            VisibleTrueTimer.Start();
        }

        private void MoveDownTimer_Tick(object sender, EventArgs e)
        {
            MoveDownTimer.Interval = stepsInterval;
            if (GameOver.Visible != true) Step.controls.play();
            if (playerSteps.Top < Height - 3 * player.sizeY)
                playerSteps.Top += player.speed;

            playerSteps.Image = lastMove == LastMove.Right ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), 90f)
               : lastMove == LastMove.Up ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), 180f)
               : lastMove == LastMove.Left ? RotateImage(playerSteps.Image, new PointF(playerSteps.Image.Width / 2, playerSteps.Image.Height / 2), -90f) : playerSteps.Image;
            playerSteps.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            lastMove = LastMove.Down;
            enemyImage.Visible = true;
            VisibleTrueTimer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MoveLeftTimer.Interval = stepsInterval;
            MoveRightTimer.Interval = stepsInterval;
            MoveDownTimer.Interval = stepsInterval;
            MoveUpTimer.Interval = stepsInterval;
            if (e.KeyCode == Keys.A)
                MoveLeftTimer.Start();
            if (e.KeyCode == Keys.D)
                MoveRightTimer.Start();
            if (e.KeyCode == Keys.W)
                MoveUpTimer.Start();
            if (e.KeyCode == Keys.S)
                MoveDownTimer.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MoveDownTimer.Stop();
            MoveUpTimer.Stop();
            MoveLeftTimer.Stop();
            MoveRightTimer.Stop();

            Control.Visible = false;
        }

        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("No Image");
            Bitmap rotatedBmp = new(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);
            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        public static double[] GetPlayerSinAndCos(Point enemy, Point player)
        {
            var a = Math.Sqrt((player.X - enemy.X) * (player.X - enemy.X) + (player.Y - enemy.Y) * (player.Y - enemy.Y));
            var b = Math.Sqrt((player.Y - enemy.Y) * (player.Y - enemy.Y));
            var c = Math.Sqrt((player.X - enemy.X) * (player.X - enemy.X));
            return (a >= 0 && b >= 0 && c >= 0) ? new double[] { b / a , c/a } : new double[2];
        }

        private void Intersect()
        {
            if (enemyImage.Bounds.IntersectsWith(playerSteps.Bounds))
            {
                playerSteps.Visible = false;
                Step.controls.next();

                GameOverLabel("Game over");
            }
        }

        private void GameOverLabel (string str)
        {
            GameOver.Text = str;
            GameOver.Location = new Point(430, 250);
            GameOver.Visible = true;

            Retry.Text = "Retry";
            Retry.Location = new Point(575, 330);
            Retry.Visible = true;

            Music.controls.stop();
            EnemyMoveTimer.Stop();
            Die.controls.play();
        }

        private void Retry_Click(object sender, EventArgs e)
        {
            Clicks.controls.play();
            GameOver.Visible = false;
            Retry.Visible = false;
            Control.Visible = true;
            playerSteps.Visible = true;

            playerSteps.Left = player.x;
            playerSteps.Top = player.y;
            enemyImage.Left = enemy.x;
            enemyImage.Top = enemy.y;

            Die.controls.stop();
            EnemyMoveTimer.Start();
            Music.controls.play();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Clicks.controls.play();
            Sure.Visible = Sure.Visible == false ? true : false;
        }

        private void Sure_Click(object sender, EventArgs e)
        {
            Clicks.controls.play();
            Menu menu = new Menu();
            Hide();
            Music.controls.stop();
            EnemyMoveTimer.Stop();
            menu.ShowDialog();
            Close();
        }
    }
}