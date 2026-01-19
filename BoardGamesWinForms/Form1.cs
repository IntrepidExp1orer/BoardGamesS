using BoardGamesCore;

namespace BoardGamesWinForms
{
    public partial class Form1 : Form
    {
        private readonly GameManager controller = new GameManager();
        private readonly StatsManager manager = new StatsManager("gamestats.txt");
        public Form1()
        {
            InitializeComponent();
            manager.LoadStats(controller.players);
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAddPlayer.Text))
            {
                if (controller.AddPlayer(textBoxAddPlayer.Text))
                {
                    textBoxAddPlayer.Clear();
                    RefreshPlayers();
                }
            }
        }

        private void RefreshPlayers()
        {
            dataGridViewPlayers.DataSource = null;
            dataGridViewPlayers.DataSource = controller.players.Select(p => new { name = p.name, winCount = p.winCount }).ToList();

            manager.LoadStats(controller.players);
            manager.SaveStats(controller.players);
        }

        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.SelectedRows.Count != 0)
            {
                controller.RemovePlayer(dataGridViewPlayers.SelectedRows[0].Index);
                RefreshPlayers();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите игрока для удаления.");
            }
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stats = new Stats(manager, controller.players);
            stats.ShowDialog();
            this.Show();
        }

        private void buttonYahtzee_Click(object sender, EventArgs e)
        {
            this.Hide();
            var yacht = new Yahtzee(controller);
            yacht.ShowDialog();
            this.Show();
            RefreshPlayers();
        }
    }
}
