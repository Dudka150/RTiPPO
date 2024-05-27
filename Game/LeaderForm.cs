using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Game
{
    public partial class LeaderForm : Form
    {
        public Game game;

        public LeaderForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        public void Leader_Load(object sender, EventArgs e)
        {
            foreach (Player playerName in game.Player)
            {
                ListBox1.Items.Add(playerName.Name);
            }
            Leader.DefineLeader(game);
            ListBox2.Items.Add(game.Leader.Name);
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public ListBox ListBox1 
        {
            get { return listBox1; }
            set { listBox1 = value; }
        }

        public ListBox ListBox2 
        {
            get { return listBox2; }
            set { listBox2 = value; }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            BetForm betForm = new BetForm(game);
            Hide();
            betForm.ShowDialog();
        }

        private void LeaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void LeaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
