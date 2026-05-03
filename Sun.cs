using System;
using System.Drawing;
using System.Windows.Forms;

public class Sun
{
    public PictureBox SunBox { get; private set; }
    private Timer despawnTimer;
    public bool IsVisible => SunBox.Visible;

    public Sun(Form form, Image sunImage, int x, int y)
    {
        SunBox = new PictureBox();
        SunBox.Image = sunImage;
        SunBox.Size = new Size(40, 40);
        SunBox.SizeMode = PictureBoxSizeMode.StretchImage;
        SunBox.BackColor = Color.Transparent;
        SunBox.Left = x;
        SunBox.Top = y;
        SunBox.Visible = false;
        form.Controls.Add(SunBox);

        // Auto hide after 5 seconds if not collected
        despawnTimer = new Timer();
        despawnTimer.Interval = 5000;
        despawnTimer.Tick += (s, e) => Hide();
    }

    public void Show()
    {
        SunBox.Visible = true;
        despawnTimer.Start();
    }

    public void Hide()
    {
        SunBox.Visible = false;
        despawnTimer.Stop();
    }

    public bool CheckCollision(PictureBox playerBox)
    {
        return SunBox.Visible && playerBox.Bounds.IntersectsWith(SunBox.Bounds);
    }
}
