using BoardGamesCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGamesWinForms
{
    public partial class Yahtzee : Form
    {
        private readonly GameManager controller;
        public Yahtzee(GameManager controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            controller.StartYahtzeeGame();
            buttonRoll.Enabled = true;
            InitializeScoreTable();
            buttonStart.Visible = false;
        }

        private void InitializeScoreTable()
        {
            dataGridViewScore.Rows.Clear();
            dataGridViewScore.Columns.Clear();

            dataGridViewScore.Columns.Add("Hands", "Hands");

            var game = controller.currentGame as YahtzeeGame;
            for (int i = 0; i < game.Players.Count; i++)
            {
                dataGridViewScore.Columns.Add($"Player{i}", game.Players[i].name);
            }

            foreach (var hand in YahtzeeGame.HandsOrder)
            {
                dataGridViewScore.Rows.Add(hand.ToString());
            }

            foreach (DataGridViewColumn column in dataGridViewScore.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void buttonRoll_Click(object sender, EventArgs e)
        {
            bool[] toRoll = new bool[5];
            var diceControls = new List<DiceElement> { diceElement1, diceElement2, diceElement3, diceElement4, diceElement5 };

            for (int i = 0; i < diceControls.Count; i++)
            {
                if (!diceControls[i].IsLocked) toRoll[i] = true;
                diceControls[i].Enabled = true;
            }

            var game = controller.currentGame as YahtzeeGame;
            game.RollDice(toRoll);
            int[] values = game.dice.values;

            for (int i = 0; i < diceControls.Count; i++)
            {
                diceControls[i].SetValue(values[i]);
            }

            buttonRoll.Text = $"Roll ({game.rolls}/3)";
        }


        public void dataGridViewScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var game = controller.currentGame as YahtzeeGame;

            // Временный функционал

            if (game.rolls < 3)
                if (e.RowIndex >= 0 && e.ColumnIndex > 0)
                    if (e.ColumnIndex == game.currentPlayer + 1)
                    {
                        int value = game.ChooseHand(e.RowIndex);
                        var cell = dataGridViewScore.Rows[e.RowIndex].Cells[e.ColumnIndex];

                        if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            cell.Value = value;
                            cell.ReadOnly = true;
                            cell.Style.BackColor = Color.ForestGreen;
                            buttonRoll.Text = "Roll (3/3)";

                            var diceControls = new List<DiceElement> { diceElement1, diceElement2, diceElement3, diceElement4, diceElement5 };
                            foreach (DiceElement dice in diceControls)
                            {
                                dice.Reset();
                            }
                        }
                    }
        }

    }
}
