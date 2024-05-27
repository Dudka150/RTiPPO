using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
            game = new Game(new List<Player>());
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(game);
            Hide();
            registrationForm.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
