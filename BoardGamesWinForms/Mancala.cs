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
    public partial class Mancala : Form
    {
        private readonly MancalaGame game;
        private Dictionary<(int row, int col), MancalaPit> pits = new Dictionary<(int row, int col), MancalaPit>();

        public Mancala(MancalaGame game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }


        private void Initializeboard()
        {
            Controls.Add(tableLayoutPanel);
        }

        private void CreatePits()
        {

        }
    }
}
