using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class MancalaGame : Game
    {
        public readonly BoardMancala board;
        
        public record CellPos(int row, int column, bool store = false, int player = -1);
        private readonly List<CellPos> route;

        public MancalaGame(List<Player> currentPlayers) : base(currentPlayers)
        {
            board = new BoardMancala(2, 7);
            route = BuildRoute();
            foreach (var p in route)
            {
                Debug.WriteLine($"row={p.row}, col={p.column}, store={p.store}");
            }
        }


        private List<CellPos> BuildRoute()
        {
            var list = new List<CellPos>();

            for (int col = 0; col < 6; col++)
                list.Add(new CellPos(0, col));

            list.Add(new CellPos(0, 6, true, 0));


            for (int col = 5; col >= 0; col--)
                list.Add(new CellPos(1, col));

            list.Add(new CellPos(1, 6, true, 1));


            return list;
        }


        public void MakeMove(int pit)
        {
            Debug.WriteLine($"START FROM row={currentPlayer} col={pit}");
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

            TryCapture(route[index]);


            // Переход хода если закончен не в доме
            var lastPit = route[index];
            if (!(lastPit.store && lastPit.player == currentPlayer))
            {
                currentPlayer = 1 - currentPlayer;
            }
        }


        private void TryCapture(CellPos lastPos)
        {
            if (!lastPos.store && lastPos.row == currentPlayer)
            {
                // При завершении в пустой яме, перехват камней противника
                int stones = board.GetValue(lastPos.row, lastPos.column);
                if (stones == 1)
                {
                    int captured = board.GetValue(1 - lastPos.row, lastPos.column);

                    if (captured > 0)
                    {
                        board.SetValue(1 - lastPos.row, lastPos.column, 0);
                        board.SetValue(lastPos.row, lastPos.column, 0);

                        board.StoreStones(currentPlayer, captured + stones);
                    }
                }
            }
        }

        override public bool IsGameFinished()
        {
            bool side0Empty = Enumerable.Range(0, 6).All(c => board.GetValue(0, c) == 0);
            bool side1Empty = Enumerable.Range(0, 6).All(c => board.GetValue(1, c) == 0);  

            return side0Empty || side1Empty;
        }

        public void CollectRemaining()
        {
            for (int row = 0; row < 2; row++)
            {
                int sum = 0;
                for (int col = 0; col < 6; col++)
                {
                    sum += board.GetValue(row, col);
                    board.SetValue(row, col, 0);
                }

                board.StoreStones(row, sum);
            }
        }

        override public int GetWinner()
        {
            int p0 = board.GetValue(0, 6);
            int p1 = board.GetValue(1, 6);

            if (p0 > p1) return 0;
            if (p1 > p0) return 1;
            return -1;
        }
    }
}
