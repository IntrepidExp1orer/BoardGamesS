using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class GameManager
    {
        public List<Player> players { get; } = new List<Player>();
        public Game currentGame { get; private set; }

        public bool AddPlayer(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || players.Any(p => p.name == name)) return false;
            players.Add(new Player(name));
            return true;
        }

        public void RemovePlayer(int player)
        {
            players.RemoveAt(player);
        }

        public void StartYahtzeeGame()
        {
            currentGame = new YahtzeeGame(players);
        }
    }
}
