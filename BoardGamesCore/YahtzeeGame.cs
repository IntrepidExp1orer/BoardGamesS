using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class YahtzeeGame : Game
    {
        public const int Hands = 6;
        private int currentHand = 0;
        public int rolls { get; private set; } = 3;
        public int currentPlayer { get; private set; } = 0;

        private readonly Board board;
        public Dice dice { get; } = new Dice();


        public enum YahtzeeHand
        {
            Aces,
            Twos,
            Threes,
            Fours,
            Fives,
            Sixes
        }

        public static readonly YahtzeeHand[] HandsOrder =
        {
            YahtzeeHand.Aces,
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
            if (rolls > 0)
            { 
                dice.RollSelected(hold);
                rolls--;
            }
        }

        public void ScoreHand()
        {

        }

        private void AdvanceTurn()
        {
            currentPlayer = (currentPlayer + 1) % players.Count;
            rolls = 3;
            dice.RollAll();
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
                if (board.IsEmpty(i, currentPlayer))
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
            board.CoulumnSum(currentPlayer);

            AdvanceTurn();
            return score;
        }

        public bool IsHandAvailable(int h, int player)
        {
            return board.IsEmpty(h, player);
        }

        public int GetSum(int c)
        {
            return board.CoulumnSum(c);
        }
    }
}
