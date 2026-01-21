using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class MancalaGame : Game
    {
        private readonly BoardMancala board;
        
        public MancalaGame(List<Player> currentPlayers) : base(currentPlayers)
        {
            board = new BoardMancala(2, 7);
        }


        public void MakeMove(int currentPlayer, int pit)
        {
            int stones = board.GetValue(currentPlayer, pit);
            board.SetValue(currentPlayer, pit, 0);

            for (int i = 0; i < stones; i++)
            {

            }
        }
    }
}
