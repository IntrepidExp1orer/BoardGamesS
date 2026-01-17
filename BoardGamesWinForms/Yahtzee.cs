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
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            bool[] toRoll = new bool[5];
            var diceControls = new List<DiceElement> { diceElement1, diceElement2, diceElement3, diceElement4, diceElement5 };

            for (int i = 0; i < diceControls.Count; i++)
            {
                if (!diceControls[i].IsLocked) toRoll[i] = true;
            }

            var yahtzee = controller.currentGame as YahtzeeGame;
            yahtzee.RollDice(toRoll);
            int[] values = yahtzee.dice.values;

            for (int i = 0; i < diceControls.Count; i++)
            {
                diceControls[i].SetValue(values[i]);
            }
        }

    }
}
