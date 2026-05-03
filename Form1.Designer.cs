namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.labelShield = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 1;
            this.gameLoop.Tag = "";
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(430, 21);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(322, 31);
            this.healthBar.TabIndex = 6;
            this.healthBar.Value = 100;
            // 
            // labelShield
            // 
            this.labelShield.AutoSize = true;
            this.labelShield.BackColor = System.Drawing.Color.Transparent;
            this.labelShield.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShield.Location = new System.Drawing.Point(325, 21);
            this.labelShield.Name = "labelShield";
            this.labelShield.Size = new System.Drawing.Size(99, 31);
            this.labelShield.TabIndex = 5;
            this.labelShield.Text = "Health";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(44, 21);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(131, 31);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score : 0";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.player;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(618, 142);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(52, 67);
            this.player.TabIndex = 7;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.labelShield);
            this.Controls.Add(this.labelScore);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label labelShield;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox player;
    }
}

