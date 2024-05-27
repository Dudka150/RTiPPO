using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Game
{
    public partial class MainGame : Form
    {
        public string leaderName;
        public Game game;
        public CastDice castDice;

        public MainGame(Game game, string leaderName)
        {
            InitializeComponent();
            this.game = game;
            label1.Text = leaderName + ", сделайте бросок";
            InitializeLabels();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            List<string> diceRoll = CastDice.castDice(game);
            ShowDiceRoll(diceRoll);
            ShowBetsResults();
            ShowPlayersForSymbols();
        }

        public void ShowDiceRoll(List<string> diceRoll)
        {
            string result = "Выпавшие масти:\n";
            foreach (var diceFace in diceRoll)
            {
                result += diceFace + "\n";
            }
            MessageBox.Show(result, "Результат броска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayCards(diceRoll, panel1); 
        }

        private Image GetImageForSymbol(string symbol)
        {
            string resourceName = "";

            switch (symbol)
            {
                case "Корона":
                    resourceName = "korona";
                    break;
                case "Якорь":
                    resourceName = "yak";
                    break;
                case "Бубны":
                    resourceName = "bub";
                    break;
                case "Черви":
                    resourceName = "ser";
                    break;
                case "Пики":
                    resourceName = "piki";
                    break;
                case "Трефы":
                    resourceName = "tref";
                    break;
                default:
                    return null;
            }

            string filePath = Path.Combine(Application.StartupPath, "Resources", resourceName + ".jpg");
            if (File.Exists(filePath))
            {
                return Image.FromFile(filePath);
            }
            else
            {
                throw new Exception($"Resource '{resourceName}' not found at path '{filePath}'");
            }
        }

        private void DisplayCards(List<string> castResult, Panel panel)
        {
            panel.Controls.Clear();
            for (int i = 0; i < castResult.Count; i++)
            {
                var symbol = castResult[i];
                var pictureBox = new PictureBox
                {
                    Width = 71,
                    Height = 96,
                    Image = GetImageForSymbol(symbol),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(i * 90, 0)
                };
                panel.Controls.Add(pictureBox);
            }
        }

        public void ShowBetsResults()
        {
            listBox1.Items.Clear();
            foreach (var playerName in game.Player)
            {
                int matchesCount = CastDice.CountMatches(playerName.Name, game);

                string resultText = $"{playerName.Name}, ваш результат: {matchesCount}";

                listBox1.Items.Add(resultText);
            }
        }

        public void ShowPlayersForSymbols()
        {

            var symbolToLabel = new Dictionary<string, Label>
            {
                { "Бубны", label2 },
                { "Корона", label3 },
                { "Пики", label4 },
                { "Черви", label5 },
                { "Трефы", label6},
                { "Якорь", label7 }
            };

            foreach (var label in symbolToLabel.Values)
            {
                label.Text = string.Empty;
            }


            foreach (var bet in game.Bet)
            {
                foreach (var symbol in bet.Symbols)
                {
                    if (symbolToLabel.ContainsKey(symbol))
                    {
                        symbolToLabel[symbol].Text += bet.PlayerName.Name + "\n";
                    }
                }
            }
        }

        private void InitializeLabels()
        {
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            label7.Text = string.Empty;
        }



        public void label1_Click(object sender, EventArgs e) { }

        public void MainGame_Load(object sender, EventArgs e) { }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void MainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainGame_FormClosed(object sender, FormClosedEventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
