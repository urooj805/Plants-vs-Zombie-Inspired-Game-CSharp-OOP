using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Class-level declarations — available to all functions
        PictureBox[] enemies = new PictureBox[3];//want 3 enemies on screen
        int[] currentFrames = new int[3]; // To manage image switching (animation)
        Image[,] enemyImages = new Image[3, 2]; // Holds two images for each enemy (frame 1 and 2)
        List<Lazer> activeLazers = new List<Lazer>();


        int maxEnemiesOnScreen = 3;

        List<Enemy> enemyList = new List<Enemy>();
        Timer enemySpawnTimer;
        int[] enemyRows = { 100, 170, 240, 310, 380 };
        Image[,] allEnemyImages;
        Random rand = new Random();
        int enemyIndex = 0;

        Sun sun;
        Timer sunSpawnTimer;

        int score = 0;
        int targetScore = 2000; // or any number you want as a win goal








        bool canShoot = true;
        int shootCooldownMs = 250; // quarter second
        Timer shootTimer;


        private int playerHealth = 100;



        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;



        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            moveplayer();
            foreach (var enemy in enemyList)
                enemy.Move();

            Invalidate(); // trigger OnPaint


            HandleBulletCollisions();
            HandleEnemyEscapes();

            if (sun.CheckCollision(player))
            {
                if (healthBar.Value <= 90)
                    healthBar.Value += 10;
                else
                    healthBar.Value = 100;

                sun.Hide();
            }

        }




        private void moveplayer()
        {
            //here we have to check if any key is pressed  using eziinput predefined functions
            int moveSpeed = 15;

            // Define bounds (adjust as per your image layout)
            int lawnTop = 60;     // top boundary of green field
            int lawnBottom = 375; // bottom boundary of green field

            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                if (player.Top - moveSpeed >= lawnTop)
                {
                    //top and left are two properties of the picture box . We use .Left (- or +) to move picture box to left and right. and for moving up and down we use .Top similarly
                    player.Top -= 10;

                }
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {

                if (player.Top + moveSpeed <= lawnBottom)
                {

                    player.Top += 10;
                }
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                ShootLazer();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            allEnemyImages = new Image[3, 2]
{
    { Properties.Resources.enemy1a, Properties.Resources.enemy1b },
    { Properties.Resources.enemy2a, Properties.Resources.enemy2b },
    { Properties.Resources.enemy3a, Properties.Resources.enemy3b }
};

            enemySpawnTimer = new Timer();
            enemySpawnTimer.Interval = 15;
            enemySpawnTimer.Tick += EnemySpawnTimer_Tick;
            enemySpawnTimer.Start();

            // Initialize Sun first
            sun = new Sun(this, Properties.Resources.sun, 650, 60); // fixed location

            // Then set up timer separately
            sunSpawnTimer = new Timer();
            sunSpawnTimer.Interval = 10000;
            sunSpawnTimer.Tick += sunSpawnTimer_Tick;
            sunSpawnTimer.Start();



        }
        private void EnemySpawnTimer_Tick(object sender, EventArgs e)
        {
            if (enemyList.Count < 10)
            {
                int row = rand.Next(enemyRows.Length);
                int startY = enemyRows[row];
                int startX = -100 - rand.Next(50, 150);


                var enemy = new Enemy(
allEnemyImages[enemyIndex % 3, 0],
allEnemyImages[enemyIndex % 3, 1],
startX,
startY,
this // pass the form
);


                enemyList.Add(enemy);
                enemyIndex++;
            }
        }



        private void ShootLazer()
        {
            Lazer newlazer = new lazerBlue();
            newlazer.Lazerposleft = player.Left - 30;
            newlazer.Lazerpostop = player.Top + player.Height / 7;
            newlazer.CreateLazer(this);
            activeLazers.Add(newlazer); // Track the lazer
        }





        private void ReduceHealth(int damage)
        {


            healthBar.Value = healthBar.Value - 20;
            healthBar.Hide();
            healthBar.Show();

            if (healthBar.Value == 0)
            {
                GameOver();
            }

        }
        private void GameOver()
        {
            gameLoop.Stop(); // Or timer1.Stop()
            this.Hide();
            GameOverForm gameOverForm = new GameOverForm();
            gameOverForm.Show();

        }

        private void HandleBulletCollisions()
        {
            for (int i = enemyList.Count - 1; i >= 0; i--)
            {
                var enemy = enemyList[i];
                PictureBox enemyBox = enemy.EnemyBox;

                for (int j = activeLazers.Count - 1; j >= 0; j--)
                {
                    var lazer = activeLazers[j];
                    PictureBox lazerBox = lazer.CurrentLazer;

                    if (lazerBox.Bounds.IntersectsWith(enemyBox.Bounds))
                    {
                        lazer.LazerTimer.Stop();
                        activeLazers.RemoveAt(j);

                        enemyBox.Dispose();
                        enemyList.RemoveAt(i);
                        lazerBox.Dispose();


                        UpdateScore(10);
                        break;
                    }
                }
            }
        }
        private void HandleEnemyEscapes()
        {
            for (int i = enemyList.Count - 1; i >= 0; i--)
            {
                var enemy = enemyList[i];
                PictureBox enemyBox = enemy.EnemyBox;

                if (enemyBox.Left >= 700)
                {
                    enemyBox.Dispose();
                    enemyList.RemoveAt(i);

                    ReduceHealth(20);

                }
            }
        }


        private void UpdateScore(int points)
        {
            score += points;
            labelScore.Text = "Score: " + score;

            if (score >= targetScore)
            {
                GameWin();
            }
        }
        private void GameWin()
        {
            gameLoop.Stop(); // stop main game loop
            enemySpawnTimer.Stop(); // stop enemy spawns
            this.Hide();
            GameWinForm winForm = new GameWinForm();
            winForm.Show();

        }


        private void sunSpawnTimer_Tick(object sender, EventArgs e)
        {
            sun.Show();
        }

    }

}

