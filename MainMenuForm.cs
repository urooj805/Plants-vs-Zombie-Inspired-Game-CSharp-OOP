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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide the menu
            Form1 gameForm = new Form1();
            gameForm.FormClosed += (s, args) => this.Show();
            gameForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Confirm before exiting
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Closes the application
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            HelpForm help = new HelpForm();
            help.FormClosed += (s, args) => this.Show();


            help.Show();
        }
    }

}
