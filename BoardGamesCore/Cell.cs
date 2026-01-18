using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class Cell
    {
        public int value { get; set; }
        public bool empty { get; set; } = true;

        public Cell(int value = 0)
        {
            this.value = value;
        }
    }
}
