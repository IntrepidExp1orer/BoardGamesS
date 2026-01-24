using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class BoardYahtzee : Board
    {
        public BoardYahtzee(int row, int column) : base(row, column)
        {
        }


        public int CoulumnSum(int column)
        {
            int sum = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                sum += grid[row, column].value;
            }

            grid[rows - 1, column].value = sum;
            return sum;
        }

        public int YahtzeeBonus(int column)
        {
            int sum = 0;
            for (int row = 0; row < 6; row++)
            {
                sum += grid[row, column].value;
            }

            return sum;
        }

        public void AddTotal(int column, int value)
        {
            grid[rows - 1, column].value += value;
        }
    }
}
