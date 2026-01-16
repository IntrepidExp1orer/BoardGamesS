using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class GameManager
    {
        private readonly List<Player> players = new List<Player>();
        public IReadOnlyList<Player> Players => players;

        public void AddPlayer(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return;
            players.Add(new Player(name));
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }

        public void StartGame()
        {

        }
    }
}
