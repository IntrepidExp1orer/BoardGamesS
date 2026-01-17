using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class Dice
    {
        public int[] values { get; } = new int[5];
        private const int Faces = 6;

        private static Random random = new Random();

        public Dice()
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = 1;
            }
        }


        public void RollAll()
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(1, Faces + 1);
            }
        }

        public void RollSelected(bool[] indices)
        {
            for (int i = 0; i < values.Length; i++) 
            {
                if (indices[i])
                {
                    values[i] = random.Next(1, Faces + 1);
                }
            }
        }


        public int Sum()
        {
            return values.Sum();
        }
    }
}
