using System;
using System.Collections.Generic;

namespace Game
{
    public class Bet
    {
        public Player PlayerName { get; set; }
        public List<string> Symbols { get; set; } 

        public Bet(Player playerName, List<string> symbols)
        {
            PlayerName = playerName;
            Symbols = symbols;
        }

        public void makeBet(Bet bet, Game game)
        {
            game.Bet.Add(bet);
        }
    }
}
