using BoardGamesCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGamesWinForms
{
    public partial class Mancala : Form
    {
        private readonly GameManager controller;
        private Dictionary<(int row, int col), MancalaPit> pits = new Dictionary<(int row, int col), MancalaPit>();

        public Mancala(GameManager controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            InitializeBoard();
            CreatePits();
            buttonStart.Visible = false;
            controller.StartMancalaGame();
        }


        private void InitializeBoard()
        {
            Controls.Add(tableLayoutPanel);
        }

        private void CreatePits()
        {
            for (int col = 0; col < 6; col++)
            {
                var pit = new MancalaPit(1, col);
                pit.Stones = 4;

                pit.Click += Pit_Click;

                pits[(1, col)] = pit;
                tableLayoutPanel.Controls.Add(pit, col + 1, 0);
            }

            for (int col = 0; col < 6; col++)
            {
                var pit = new MancalaPit(0, col);
                pit.Stones = 4;

                pit.Click += Pit_Click;

                pits[(0, col)] = pit;
                tableLayoutPanel.Controls.Add(pit, col + 1, 2);
            }

            var store1 = new MancalaPit(1, 6, true);
            var store0 = new MancalaPit(0, 6, true);

            pits[(1, 6)] = store1;
            pits[(0, 6)] = store0;

            tableLayoutPanel.Controls.Add(store1, 0, 1);
            tableLayoutPanel.Controls.Add(store0, 7, 1);

            foreach (var kv in pits)
            {
                Debug.WriteLine(
                    $"PIT key: row={kv.Key.row}, col={kv.Key.col} | " +
                    $"control: Row={kv.Value.Row}, Col={kv.Value.Col}"
                );
            }
        }

        private void Pit_Click(object? sender, EventArgs e)
        {
            if (sender is not MancalaPit pit)
            {
                return;
            }
            
            var game = controller.currentGame as MancalaGame;

            if (pit.Row == game.currentPlayer && !pit.IsStore && pit.Stones > 0)
            {
                Debug.WriteLine($"CLICK row={pit.Row} col={pit.Col}");
                game.MakeMove(pit.Col);
                for (int r = 0; r < 2; r++)
                    for (int c = 0; c < 6; c++)
                        Debug.WriteLine($"BOARD[{r},{c}]={game.board.GetValue(r, c)}");
                RedrawBoard();
                for (int r = 0; r < 2; r++)
                    for (int c = 0; c < 6; c++)
                        Debug.WriteLine($"BOARD[{r},{c}]={game.board.GetValue(r, c)}");
                if (game.IsGameFinished())
                {
                    game.CollectRemaining();
                    RedrawBoard();
                   

                    int winner = game.GetWinner();
                    MessageBox.Show(winner == -1 ? "Ничья" : $"Победил игрок {winner + 1}");
                }
            }
            Debug.WriteLine($"Текущий игрок: {game.currentPlayer}");
        }

        private void RedrawBoard()
        {
            var game = controller.currentGame as MancalaGame;

            foreach (var i in pits)
            {
                int value = game.board.GetValue(i.Key.row, i.Key.col);
                i.Value.Stones = value;
            }
        }
    }
}
