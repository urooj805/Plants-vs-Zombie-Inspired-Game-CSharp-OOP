using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            Timer delayTimer = new Timer();
            delayTimer.Interval = 2000; // 5 seconds
            delayTimer.Tick += (s, args) =>
            {
                delayTimer.Stop();

                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();

                this.Hide(); // just hide it, don't close
            };
            delayTimer.Start();
        }

    }
}
