using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class CastDice
    {
        public static readonly List<string> nameSymbols = new List<string>
        {
            "Корона",
            "Якорь",
            "Бубны",
            "Черви",
            "Пики",
            "Трефы"
        };

        public static List<string> castDice(Game game)
        {
            Random random = new Random();
            List<string> result = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                int randomIndex = random.Next(nameSymbols.Count);
                result.Add(nameSymbols[randomIndex]);
            }

            game.CastResult = result;
            return result;
        }

        public static int CountMatches(string playerName, Game game)
        {
            int matchesCount = 0;
            Bet playerBet = game.Bet.Find(bet => bet.PlayerName.Name == playerName);
            if (playerBet != null)
            {
                List<string> betSymbols = new List<string>(playerBet.Symbols); 
                List<string> castSymbols = new List<string>(game.CastResult); 

                foreach (var symbol in playerBet.Symbols)
                {
                    int countInCast = castSymbols.Count(s => s == symbol); 
                    if (countInCast > 0)
                    {
                        matchesCount += countInCast; 
                        castSymbols.RemoveAll(s => s == symbol);
                    }
                    else
                    {
                        matchesCount--;
                    }
                }
            }
            return matchesCount;
        }
    }
}
