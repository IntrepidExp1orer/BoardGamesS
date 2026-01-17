using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class YahtzeeGame : Game
    {
        public const int Hands = 6;
        private int currentHand = 0;
        private int currentPlayer = 0;

        private readonly Board board;
        public Dice dice { get; } = new Dice();

        public YahtzeeGame(List<Player> players) : base(players)
        {
            board = new Board(Hands + 1, players.Count);
        }

        public void RollDice(bool[] hold)
        {
            dice.RollSelected(hold);
        }

        public void ScoreHand()
        {

        }

        private void AdvanceTurn()
        {
         currentPlayer = (currentPlayer + 1) % players.Count;   
        }
    }
}
