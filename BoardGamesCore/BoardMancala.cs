using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class BoardMancala : Board
    {
        public int[] stores { get; } = new int[2];
        public BoardMancala(int row, int column) : base(row, column)
        {
            for (int r = 0; r < 2; r++)
                for (int c = 0; c < 6; c++)
                    SetValue(r, c, 4);
        }


        public void AddStone(int row, int column)
        {
            grid[row, column].value++;
        }

        public void StoreStones(int player, int amount)
        {
            grid[player, 6].value += amount;
        }
    }
}
