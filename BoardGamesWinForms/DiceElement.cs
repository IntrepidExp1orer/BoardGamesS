using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGamesWinForms
{
    public partial class DiceElement: UserControl
    {
        public int Value { get; private set; } = 1;
        public bool IsLocked { get; set; } = false;

        public DiceElement()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.dice1;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }


        public void SetValue(int newValue)
        {
            Value = newValue;
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{Value}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IsLocked = !IsLocked;
            this.BackColor = IsLocked ? Color.Gold : Color.Transparent;
            this.Padding = IsLocked ? new Padding(3) : new Padding(0);
        }

        public void Reset()
        {
            SetValue(1);
            IsLocked = false;
            this.BackColor = Color.Transparent;
            this.Padding = new Padding(0);
            this.Enabled = false;
        }
    }
}
