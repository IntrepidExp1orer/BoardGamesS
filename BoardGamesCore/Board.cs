using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BoardGamesCore
{
    public class Board
    {
        private int rows;
        private int columns;
        private readonly Cell[,] grid;

        public Board(int row, int column)
        {
            rows = row;
            columns = column;
            grid = new Cell[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    grid[r, c] = new Cell();
                }
            }
        }


        public int GetValue(int row, int column)
        {
            if (row < 0 || row >= rows) return 0;
            else if (column < 0 || column >= columns) return 0;
            else return grid[row, column].value;
        }

        public void SetValue(int row, int column, int score)
        {
            if (row >= 0 || row < rows)
                if (column >= 0 || column < columns)
                {
                    grid[row, column].value = score;
                    grid[row, column].empty = false;
                }
            
        }

        public bool IsEmpty(int row, int column)
        {
            return grid[row, column].empty;
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
    }
}
