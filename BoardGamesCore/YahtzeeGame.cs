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


        public enum YahtzeeHand
        {
            Ones,
            Twos,
            Threes,
            Fours,
            Fives,
            Sixes
        }

        public static readonly YahtzeeHand[] HandsOrder =
        {
            YahtzeeHand.Ones,
            YahtzeeHand.Twos,
            YahtzeeHand.Threes,
            YahtzeeHand.Fours,
            YahtzeeHand.Fives,
            YahtzeeHand.Sixes
        };



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



        // Игровой процесс
        

        public int CalculateScore(YahtzeeHand hand)
        {
            int face = (int)hand + 1;
            return dice.values.Where(val => val == face).Sum();
        }


        public Dictionary<int, int> GetAvailableScores()
        {
            var result = new Dictionary<int, int>();

            for (int i = 0; i < Hands; i++)
            {
                if (board.GetValue(i, currentPlayer) == 0)
                {
                    var hand = HandsOrder[i];
                    result[i] = CalculateScore(hand);
                }
            }

            return result;
        }

        public int ChooseHand(int row)
        {
            var hand = HandsOrder[row];
            int score = CalculateScore(hand);

            board.SetValue(row, currentPlayer, score);

            AdvanceTurn();
            return score;
        }
    }
}
