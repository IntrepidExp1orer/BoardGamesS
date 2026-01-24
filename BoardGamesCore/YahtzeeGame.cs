using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class YahtzeeGame : Game
    {
        public const int Hands = 13;
        private int currentHand = 0;
        private bool[] bonuses;
        private bool[] yahtzees;
        public int rolls { get; private set; } = 3;

        private readonly BoardYahtzee board;
        public Dice dice { get; } = new Dice();

        

        public enum YahtzeeHand
        {
            Aces,
            Twos,
            Threes,
            Fours,
            Fives,
            Sixes,

            ThreeOfKind,
            FourOfKind,
            FullHouse,
            SmallStraight,
            LargeStraight,
            Yahtzee,
            Chance
        }

        public static readonly YahtzeeHand[] HandsOrder =
        {
            YahtzeeHand.Aces,
            YahtzeeHand.Twos,
            YahtzeeHand.Threes,
            YahtzeeHand.Fours,
            YahtzeeHand.Fives,
            YahtzeeHand.Sixes,

            YahtzeeHand.ThreeOfKind,
            YahtzeeHand.FourOfKind,
            YahtzeeHand.FullHouse,
            YahtzeeHand.SmallStraight,
            YahtzeeHand.LargeStraight,
            YahtzeeHand.Yahtzee,
            YahtzeeHand.Chance
        };



        public YahtzeeGame(List<Player> players) : base(players)
        {
            board = new BoardYahtzee(Hands + 1, players.Count);
            bonuses = new bool[players.Count];
            yahtzees = new bool[players.Count];
        }

        public void RollDice(bool[] hold)
        {
            if (rolls > 0)
            { 
                dice.RollSelected(hold);
                rolls--;
            }
        }

        public Dictionary<int, int> GroupValues()
        {
            return dice.values.GroupBy(v => v).ToDictionary(g => g.Key, g => g.Count());
        }

        private void AdvanceTurn()
        {
            currentPlayer = (currentPlayer + 1) % players.Count;
            rolls = 3;
            dice.RollAll();
        }

        private bool StraightScore(int length)
        {
            int[] sortedDice = dice.values.Distinct().Order().ToArray();
            int sequence = 1;

            for (int i = 1; i < sortedDice.Length; i++)
            {
                if (sortedDice[i] == sortedDice[i - 1] + 1)
                {
                    sequence++;
                    if (sequence >= length) return true;
                }
                else sequence = 1;
            }

            return false;
        }



        public int CalculateScore(YahtzeeHand hand)
        {
            var groups = GroupValues();

            switch(hand)
            {
                case YahtzeeHand.Aces:
                case YahtzeeHand.Twos:
                case YahtzeeHand.Threes:
                case YahtzeeHand.Fours:
                case YahtzeeHand.Fives:
                case YahtzeeHand.Sixes:
                    int face = (int)hand + 1;                   
                    return dice.values.Where(val => val == face).Sum();
                case YahtzeeHand.ThreeOfKind:
                    if (groups.Any(c => c.Value >= 3)) return dice.values.Sum();
                    else return 0;
                case YahtzeeHand.FourOfKind:
                    if (groups.Any(c => c.Value >= 4)) return dice.values.Sum();
                    else return 0;
                case YahtzeeHand.FullHouse:
                    if (groups.Any(c => c.Value == 3) && groups.Any(c => c.Value == 2)) return 25;
                    else return 0;
                case YahtzeeHand.SmallStraight:
                    if (StraightScore(4)) return 30;
                    else return 0;
                case YahtzeeHand.LargeStraight:
                    if (StraightScore(5)) return 40;
                    else return 0;
                case YahtzeeHand.Yahtzee:
                    if (groups.Any(c => c.Value == 5)) 
                    {
                        yahtzees[currentPlayer] = true;
                        return 50; 
                    }
                    else return 0;
                case YahtzeeHand.Chance:
                    return dice.values.Sum();
                default:
                    return 0;
            }
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

            // Бонусные очки
            if (!bonuses[currentPlayer] && board.YahtzeeBonus(currentPlayer) >= 63)
            {
                bonuses[currentPlayer] = true;
                board.AddTotal(currentPlayer, 35);
            }

            if (dice.values.All(v => v == dice.values[0]) && yahtzees[currentPlayer])
            {
                board.AddTotal(currentPlayer, 100);
            }


            if (!IsGameFinished())
            { 
                AdvanceTurn(); 
            }
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


        override public bool IsGameFinished()
        {
            for (int p = 0; p < players.Count; p++)
            {
                for (int h = 0; h < Hands; h++)
                {
                    if (board.IsEmpty(h, p))
                        return false;
                }
            }
            return true;
        }


        override public int GetWinner()
        {
            int max = -1;
            int winner = -1;

            for (int p = 0; p < players.Count; p++)
            {
                int score = board.GetValue(Hands, p);
                if (score > max)
                {
                    max = score;
                    winner = p;
                }
            }

            players[winner].AddWin();

            return winner;
        }

    }
}
