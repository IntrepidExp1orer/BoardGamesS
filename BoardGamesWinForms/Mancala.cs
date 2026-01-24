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
            label1.Text = controller.players[0].name;
            label2.Text = controller.players[1].name;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            controller.StartMancalaGame();
            InitializeBoard();
            buttonStart.Visible = false;
        }


        private void InitializeBoard()
        {
            Controls.Add(tableLayoutPanel);
            CreatePits();
            UpdateHighlight();
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

            tableLayoutPanel.Controls.Add(store1, 0, 0);
            tableLayoutPanel.SetRowSpan(store1, 3);
            tableLayoutPanel.Controls.Add(store0, 7, 0);
            tableLayoutPanel.SetRowSpan(store0, 3);

            foreach (var kv in pits)
            {
                Debug.WriteLine(
                    $"PIT key: row={kv.Key.row}, col={kv.Key.col} | " +
                    $"control: Row={kv.Value.Row}, Col={kv.Value.Col}"
                );
            }
        }

        private async void Pit_Click(object? sender, EventArgs e)
        {
            if (sender is not MancalaPit pit)
            {
                return;
            }
            
            var game = controller.currentGame as MancalaGame;

            if (pit.Row == game.currentPlayer && !pit.IsStore && pit.Stones > 0)
            {
                foreach (var p in pits.Values) p.Enabled = false;


                //game.MakeMove(pit.Col);
                foreach (var step in game.MakeMoveSteps(pit.Col))
                {           
                    RedrawBoard();
                    await Task.Delay(300);
                }
                RedrawBoard();

                UpdateHighlight();

                if (game.IsGameFinished())
                {
                    game.CollectRemaining();
                    RedrawBoard();
                   
                    int winner = game.GetWinner();
                    MessageBox.Show(winner == -1 ? "Ничья" : $"Победил игрок {controller.players[winner].name}");
                }
            }
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


        private void UpdateHighlight()
        {
            var game = controller.currentGame as MancalaGame;

            foreach (var i in pits)
            {
                var pit = i.Value;

                if (pit.IsStore)
                {
                    pit.BackColor = pit.Row == game.currentPlayer? Color.DarkOliveGreen : Color.DarkKhaki;

                    continue;
                }

                bool active = pit.Row == game.currentPlayer;

                pit.Enabled = active;
                pit.BackColor = active ? Color.LightBlue : Color.Bisque;
            }
        }
    }
}
