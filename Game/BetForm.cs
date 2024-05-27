using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game
{
    public partial class BetForm : Form
    {
        public Game game;
        public Bet bet;
        public int currentPlayerIndex = 0;

        public BetForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            label1_Click(null, null);
        }

        public void label1_Click(object sender, EventArgs e)
        {
            labelPlayerName.Text = "Ход игрока: " + game.Player[currentPlayerIndex].Name;
        }

        public bool IsLeader(string playerName)
        {
            return playerName == game.Leader.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> symbols = new List<string>();

            if (checkBox1.Checked)
                symbols.Add("Корона");
            if (checkBox2.Checked)
                symbols.Add("Якорь");
            if (checkBox3.Checked)
                symbols.Add("Бубны");
            if (checkBox4.Checked)
                symbols.Add("Черви");
            if (checkBox5.Checked)
                symbols.Add("Пики");
            if (checkBox6.Checked)
                symbols.Add("Трефы");

            Bet bet = new Bet(game.Player[currentPlayerIndex], symbols);
            bet.makeBet(bet, game);
            ResetCheckBoxes();

            currentPlayerIndex++;

            if (currentPlayerIndex >= game.Player.Count) 
            {
                string message = "Ставки игроков:\n";
                foreach (var currentBet in game.Bet)
                {
                    message += $"{currentBet.PlayerName.Name}: {string.Join(", ", currentBet.Symbols)}\n";
                }

                MessageBox.Show(message, "Информация о ставках", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainGame mainGameForm = new MainGame(game, game.Leader.Name);
                Hide();
                mainGameForm.Show();

                
            }
            else
            {
                UpdatePlayerLabel();
            }
        }

        public void UpdatePlayerLabel()
        {
            if (currentPlayerIndex >= 0 && currentPlayerIndex < game.Player.Count)
            {
                if (IsLeader(game.Player[currentPlayerIndex].Name))
                {
                    currentPlayerIndex++;
                    UpdatePlayerLabel(); 
                    return;
                }
                else
                {
                    labelPlayerName.Text = "Ход игрока: " + game.Player[currentPlayerIndex].Name;
                }
            }
        }

        public void ResetCheckBoxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void BetForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BetForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BetForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}