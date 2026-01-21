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
        }


        public void AddStone(int row, int column)
        {
            grid[row, column].value++;
        }
    }
}
