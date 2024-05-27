using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Game
{
    public class Game
    {
        public List<Bet> Bet { get; private set; }
        public List<Player> Player { get; private set; }
        public Leader Leader { get; set; }
        public List<string> CastResult { get; set; }
        public List<string> Win {  get; private set; }

        public Game(List<Player> playerNames)
        {
            Player = playerNames;
            Bet = new List<Bet>();
            Win = new List<string>();
        }
    }
}

