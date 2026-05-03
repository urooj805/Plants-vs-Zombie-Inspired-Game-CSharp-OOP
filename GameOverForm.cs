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
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newGame = new Form1(); // create a new instance of Form1
            newGame.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm menu = new MainMenuForm(); // assuming your main menu form is called this
            menu.Show();
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // hide the menu
            Form1 gameForm = new Form1();
            gameForm.FormClosed += (s, args) => this.Show();
            gameForm.Show();
        }
    }
}
