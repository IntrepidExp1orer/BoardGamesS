using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class MancalaGame : Game
    {
        private readonly BoardMancala board;
        
        public record CellPos(int row, int column, bool store = false, int player = -1);
        private readonly List<CellPos> route;

        public MancalaGame(List<Player> currentPlayers) : base(currentPlayers)
        {
            board = new BoardMancala(2, 6);
        }


        private List<CellPos> BuildRoute()
        {
            var list = new List<CellPos>();

            for (int col = 0; col < 6; col++)
                list.Add(new CellPos(0, col));

            list.Add(new CellPos(0, 6, true, 0));


            for (int col = 6 - 1; col >= 0; col--)
                list.Add(new CellPos(1, col));

            list.Add(new CellPos(1, 6, true, 1));

            return list;
        }


        public void MakeMove(int currentPlayer, int pit)
        {
            int stones = board.GetValue(currentPlayer, pit);
            board.SetValue(currentPlayer, pit, 0);

            int index = route.FindIndex(p => p.row == currentPlayer && p.column == pit);

            while (stones > 0)
            {
                index = (index + 1) % route.Count;
                var pos = route[index];

                board.AddStone(pos.row, pos.column);

                stones--;
            }
        }
    }
}
