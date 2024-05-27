using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Leader : Player  
    {
        public Leader(string name) : base(name) 
        {

        }

        public static string DefineLeader(Game game)
        {
            Random random = new Random();
            int randomIndex = random.Next(game.Player.Count);
            Player randomPlayerName = game.Player[randomIndex];
            Leader leader = new Leader(randomPlayerName.Name);
            game.Player.Remove(randomPlayerName);
            game.Leader = leader;
            return game.Leader.Name;
        }
    }
}
