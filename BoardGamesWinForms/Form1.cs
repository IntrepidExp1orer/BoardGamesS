using BoardGamesCore;

namespace BoardGamesWinForms
{
    public partial class Form1 : Form
    {
        private readonly GameManager controller = new GameManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAddPlayer.Text))
            {
                controller.AddPlayer(textBoxAddPlayer.Text);
                textBoxAddPlayer.Clear();
                RefreshPlayers();
            }
        }

        private void RefreshPlayers()
        {
            dataGridViewPlayers.DataSource = null;
            dataGridViewPlayers.DataSource = controller.Players.Select(p => new { name = p.name, winCount = p.winCount }).ToList();

        }

        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.CurrentRow != null)
            { 
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите игрока для удаления.");
            }
        }
    }
}
