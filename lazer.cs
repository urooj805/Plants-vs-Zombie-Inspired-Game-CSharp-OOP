using System.Drawing;
using System.Windows.Forms;
using System;

public abstract class Lazer
{
    private int lazerposleft;
    private int lazerpostop;
    private int speed = 10;
    private PictureBox lazer = new PictureBox();
    private Timer lazerTimer = new Timer();

    public int Lazerposleft { get => lazerposleft; set => lazerposleft = value; }
    public int Lazerpostop { get => lazerpostop; set => lazerpostop = value; }
    public int Speed { get => speed; set => speed = value; }
    public PictureBox CurrentLazer { get => lazer; set => lazer = value; }
    public Timer LazerTimer { get => lazerTimer; set => lazerTimer = value; }

    public virtual void CreateLazer(Form form)
    {
        lazer.BackColor = Color.Transparent;
        lazer.Left = lazerposleft;
        lazer.Top = lazerpostop;
        lazer.BringToFront();
        lazer.Size = new Size(40, 30);
        lazer.SizeMode = PictureBoxSizeMode.StretchImage;
        lazer.Tag = "playerLazer"; // Tag should be here always
        form.Controls.Add(lazer);

        LazerTimer.Interval = 15;
        LazerTimer.Tick += LazerTick;
        LazerTimer.Start();
    }

    private void LazerTick(object sender, EventArgs e)
    {
        lazer.Left -= speed;

        if (lazer.Right < 0)
        {
            LazerTimer.Stop();
            LazerTimer.Tick -= LazerTick;

            lazer.Dispose();
            LazerTimer.Dispose();
        }
    }
}
