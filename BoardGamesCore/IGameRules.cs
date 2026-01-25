using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public interface IGameRules
    {
        string Name { get; }
        string Rules { get; }
    }
}
