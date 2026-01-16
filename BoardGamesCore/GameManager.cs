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

        public bool AddPlayer(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || players.Any(p => p.name == name)) return false;
            players.Add(new Player(name));
            return true;
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
