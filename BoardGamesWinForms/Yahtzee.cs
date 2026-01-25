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
using System.Xml.Serialization;
using static System.Formats.Asn1.AsnWriter;

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
            UpdateActiveColumn();
            buttonRules.Visible = true;
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

            dataGridViewScore.Rows.Add("Total");
            for (int i = 0; i < game.Players.Count; i++)
            {
                dataGridViewScore.Rows[YahtzeeGame.Hands].Cells[i + 1].Style.BackColor = Color.ForestGreen;
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
            ScorePreview();
        }


        public void dataGridViewScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var game = controller.currentGame as YahtzeeGame;

            // Временный функционал

            if (game.rolls < 3)
                if (e.RowIndex >= 0 && e.ColumnIndex > 0)
                    if (e.ColumnIndex == game.currentPlayer + 1)
                    {

                        if (game.IsHandAvailable(e.RowIndex, game.currentPlayer))
                        {
                            ClearPreview();
                            int value = game.ChooseHand(e.RowIndex);
                            var cell = dataGridViewScore.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            UpdateActiveColumn();

                            cell.Value = value;
                            cell.ReadOnly = true;
                            cell.Style.BackColor = Color.ForestGreen;
                            buttonRoll.Text = "Roll (3/3)";

                            dataGridViewScore.Rows[YahtzeeGame.Hands].Cells[e.ColumnIndex].Value = game.GetSum(e.ColumnIndex - 1);

                            var diceControls = new List<DiceElement> { diceElement1, diceElement2, diceElement3, diceElement4, diceElement5 };
                            foreach (DiceElement dice in diceControls)
                            {
                                dice.Reset();
                            }


                            if (game.IsGameFinished())
                            {
                                int winner = game.GetWinner();

                                MessageBox.Show($"Победил {game.Players[winner].name}!", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                buttonRoll.Enabled = false;
                            }
                        }
                    }
        }

        // Отображение возможных очков в таблице
        private void ScorePreview()
        {
            var game = controller.currentGame as YahtzeeGame;
            var scores = game.GetAvailableScores();

            foreach (var pair in scores)
            {
                int row = pair.Key;
                var score = pair.Value;

                var cell = dataGridViewScore.Rows[row].Cells[game.currentPlayer + 1];

                if (!cell.ReadOnly)
                {
                    cell.Value = score;
                }
            }
        }

        private void ClearPreview()
        {
            var game = controller.currentGame as YahtzeeGame;

            for (int i = 0; i < YahtzeeGame.Hands; i++)
            {
                var cell = dataGridViewScore.Rows[i].Cells[game.currentPlayer + 1];

                if (!cell.ReadOnly)
                {
                    cell.Value = null;
                }
            }
        }

        private void UpdateActiveColumn()
        {
            var game = controller.currentGame as YahtzeeGame;

            for (int c = 1; c < dataGridViewScore.Columns.Count; c++)
            {
                bool active = (c == game.currentPlayer + 1);

                dataGridViewScore.Columns[c].DefaultCellStyle.BackColor =
                    active ? Color.LightYellow : Color.LightGray;
            }
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            var game = controller.currentGame;
            var rules = game.rules;

            MessageBox.Show(
                rules.Rules,
                rules.Name,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
