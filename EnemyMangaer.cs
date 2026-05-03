using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Enemy
    {
        public PictureBox EnemyBox { get; private set; }
        private Image frame1;
        private Image frame2;
        private Timer animationTimer;
        private int currentFrame = 0;

        public Enemy(Image frame1, Image frame2, int x, int y, Form form)
        {
            this.frame1 = frame1;
            this.frame2 = frame2;

            EnemyBox = new PictureBox();
            EnemyBox.Size = new Size(70, 70);
            EnemyBox.Location = new Point(x, y);
            EnemyBox.SizeMode = PictureBoxSizeMode.StretchImage;
            EnemyBox.BackColor = Color.Transparent;
            EnemyBox.BackgroundImageLayout = ImageLayout.Stretch;
            EnemyBox.BackgroundImage = frame1; // Use background image

            form.Controls.Add(EnemyBox);

            animationTimer = new Timer();
            animationTimer.Interval = 250; // Switch frames every 250ms
            animationTimer.Tick += Animate;
            animationTimer.Start();
        }

        private void Animate(object sender, EventArgs e)
        {
            currentFrame = 1 - currentFrame; // toggle 0 ↔ 1
            EnemyBox.BackgroundImage = currentFrame == 0 ? frame1 : frame2;
        }

        public void Move()
        {
            if (EnemyBox != null)
            {
                EnemyBox.Left += 3; // Move rightwards
            }
        }

        public void Dispose()
        {
            if (EnemyBox != null)
            {
                animationTimer?.Stop();
                EnemyBox.Dispose();
            }
        }
    }
}
