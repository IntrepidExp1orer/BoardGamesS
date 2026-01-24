using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public abstract class Game
    {
        protected string currentGame;
        protected List<Player> players;
        public int currentPlayer { get; protected set; } = 0;

        public string winner { get; protected set; }
        public int winPoints { get; protected set; }

        public IReadOnlyList<Player> Players => players;

        public Game(List<Player> currentPlayers)
        {
            this.players = currentPlayers;
            this.currentGame = "Unnamed Game";
        }

        //public abstract void Start();
        public abstract bool IsGameFinished();
        public abstract int GetWinner();

        public List<Player> GetPlayerList()
        {
            return players;
        }


        public string GetGameName()
        {
            return currentGame;
        }

    }
}
