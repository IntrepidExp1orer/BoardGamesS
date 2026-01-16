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
    public partial class Stats : Form
    {
        private readonly StatsManager manager;

        public Stats(StatsManager manager, List<Player> currentPlayers)
        {
            InitializeComponent();
            this.manager = manager;
            LoadStats(currentPlayers);
            this.manager.SaveStats(currentPlayers);
        }

        private void LoadStats(List<Player> currentPlayers)
        {
            List<Player> allPlayers = manager.LoadStats(currentPlayers);

            dataGridViewStats.DataSource = null;
            dataGridViewStats.DataSource = allPlayers.Select(s => new
            {
                name = s.name, totalWins = s.winCount
            }).ToList();
        }
    }
}
