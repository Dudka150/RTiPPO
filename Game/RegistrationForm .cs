using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game
{
    public partial class RegistrationForm : Form
    {
        private Game game; 

        public RegistrationForm(Game game)
        {
            InitializeComponent();
            this.game = game; 
        }

        private void end_Click(object sender, EventArgs e)
        {
            if (game.Player.Count < 1 )
            {
                MessageBox.Show("Для начала игры требуется как минимум два игрока.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string playerName = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(playerName))
            {
                if (Player.singUpGame(playerName, game.Player))
                {
                    LeaderForm leaderForm = new LeaderForm(game);
                    Hide();
                    leaderForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Такой ник уже существует! Пожалуйста, выберите другой ник.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (game.Player.Count > 1)
                {
                    LeaderForm leaderForm = new LeaderForm(game);
                    Hide();
                    leaderForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Для начала игры требуется как минимум два игрока.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
        }

        private void singUpGame_Click(object sender, EventArgs e)
        {
            string playerName = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(playerName))
            {
                if (Player.singUpGame(playerName, game.Player))
                {
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Такой ник уже существует! Пожалуйста, выберите другой ник.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите имя игрока.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
