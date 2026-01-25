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
    public partial class MancalaPit : UserControl
    {
        public int Row { get; }
        public int Col { get; }
        public bool IsStore { get; }
        public int stones;
        public int Stones
        {
            get => stones;
            set
            {
                stones = value;
                Invalidate();
            }
        }


        public MancalaPit(int row, int col, bool isStore = false)
        {
            InitializeComponent();
            Row = row;
            Col = col;
            IsStore = isStore;

            Dock = DockStyle.Fill;
            Margin = new Padding(5);
            BackColor = isStore ? Color.DarkKhaki : Color.BurlyWood;

            DoubleBuffered = true;
            Size = new Size(90, 90);
            Cursor = Cursors.Hand;

            Enabled = !IsStore;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.FillEllipse(IsStore ? Brushes.DarkKhaki : Brushes.Bisque, 5, 5, Width - 10, Height - 10);

            g.DrawEllipse(Pens.SaddleBrown, 5, 5, Width - 10, Height - 10);


            using Font font = new Font("Segoe UI", 16, FontStyle.Bold);
            string text = Stones.ToString();
            SizeF size = g.MeasureString(text, font);

            g.DrawString(
                text,
                font,
                Brushes.Black,
                (Width - size.Width) / 2,
                (Height - size.Height) / 2);
        }
    }
}
