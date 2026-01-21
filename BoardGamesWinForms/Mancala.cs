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
        private readonly GameManager controller;
        public Mancala(GameManager controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
    }
}
