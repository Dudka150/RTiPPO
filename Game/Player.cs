using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public static bool singUpGame(string playerName, List<Player> playerNames)
        {
            if (playerNames.Count(i => i.Name == playerName) > 0)
            {
                return false;
            }

            playerNames.Add(new Player(playerName));
            return true;
        }
    }
}
