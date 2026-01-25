namespace BoardGamesWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonYahtzee = new Button();
            buttonMancala = new Button();
            button3 = new Button();
            buttonStats = new Button();
            buttonExit = new Button();
            buttonAddPlayer = new Button();
            textBoxAddPlayer = new TextBox();
            dataGridViewPlayers = new DataGridView();
            columnName = new DataGridViewTextBoxColumn();
            ColumnSessionWins = new DataGridViewTextBoxColumn();
            buttonRemoveUser = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonYahtzee
            // 
            buttonYahtzee.BackColor = Color.YellowGreen;
            buttonYahtzee.Location = new Point(483, 93);
            buttonYahtzee.Name = "buttonYahtzee";
            buttonYahtzee.Size = new Size(130, 43);
            buttonYahtzee.TabIndex = 0;
            buttonYahtzee.Text = "Yahtzee";
            buttonYahtzee.UseVisualStyleBackColor = false;
            buttonYahtzee.Click += buttonYahtzee_Click;
            // 
            // buttonMancala
            // 
            buttonMancala.BackColor = Color.YellowGreen;
            buttonMancala.Location = new Point(483, 183);
            buttonMancala.Name = "buttonMancala";
            buttonMancala.Size = new Size(130, 43);
            buttonMancala.TabIndex = 1;
            buttonMancala.Text = "Манкала";
            buttonMancala.UseVisualStyleBackColor = false;
            buttonMancala.Click += buttonMancala_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OliveDrab;
            button3.Location = new Point(483, 273);
            button3.Name = "button3";
            button3.Size = new Size(130, 43);
            button3.TabIndex = 2;
            button3.Text = "Coming soon...";
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonStats
            // 
            buttonStats.BackColor = Color.YellowGreen;
            buttonStats.Location = new Point(643, 273);
            buttonStats.Name = "buttonStats";
            buttonStats.Size = new Size(130, 43);
            buttonStats.TabIndex = 3;
            buttonStats.Text = "Статистика";
            buttonStats.UseVisualStyleBackColor = false;
            buttonStats.Click += buttonStats_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.OliveDrab;
            buttonExit.Location = new Point(643, 363);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(130, 43);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonAddPlayer
            // 
            buttonAddPlayer.Anchor = AnchorStyles.Left;
            buttonAddPlayer.BackColor = Color.GreenYellow;
            buttonAddPlayer.Location = new Point(163, 302);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(97, 26);
            buttonAddPlayer.TabIndex = 5;
            buttonAddPlayer.Text = "Добавить";
            buttonAddPlayer.UseVisualStyleBackColor = false;
            buttonAddPlayer.Click += buttonAddPlayer_Click;
            // 
            // textBoxAddPlayer
            // 
            textBoxAddPlayer.Anchor = AnchorStyles.None;
            textBoxAddPlayer.Location = new Point(30, 303);
            textBoxAddPlayer.Name = "textBoxAddPlayer";
            textBoxAddPlayer.Size = new Size(100, 23);
            textBoxAddPlayer.TabIndex = 6;
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AllowUserToDeleteRows = false;
            dataGridViewPlayers.AllowUserToResizeColumns = false;
            dataGridViewPlayers.AllowUserToResizeRows = false;
            dataGridViewPlayers.Anchor = AnchorStyles.None;
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.BackgroundColor = Color.DarkSlateGray;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Columns.AddRange(new DataGridViewColumn[] { columnName, ColumnSessionWins });
            tableLayoutPanel1.SetColumnSpan(dataGridViewPlayers, 2);
            dataGridViewPlayers.Location = new Point(36, 105);
            dataGridViewPlayers.MultiSelect = false;
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(dataGridViewPlayers, 2);
            dataGridViewPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers.Size = new Size(247, 150);
            dataGridViewPlayers.TabIndex = 7;
            // 
            // columnName
            // 
            columnName.DataPropertyName = "name";
            columnName.HeaderText = "Имя";
            columnName.Name = "columnName";
            columnName.ReadOnly = true;
            // 
            // ColumnSessionWins
            // 
            ColumnSessionWins.DataPropertyName = "winCount";
            ColumnSessionWins.HeaderText = "Побед";
            ColumnSessionWins.Name = "ColumnSessionWins";
            ColumnSessionWins.ReadOnly = true;
            // 
            // buttonRemoveUser
            // 
            buttonRemoveUser.BackColor = Color.Salmon;
            buttonRemoveUser.Location = new Point(163, 363);
            buttonRemoveUser.Name = "buttonRemoveUser";
            buttonRemoveUser.Size = new Size(97, 23);
            buttonRemoveUser.TabIndex = 8;
            buttonRemoveUser.Text = "Удалить";
            buttonRemoveUser.UseVisualStyleBackColor = false;
            buttonRemoveUser.Click += buttonRemoveUser_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.SeaShell;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(buttonRemoveUser, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonStats, 4, 3);
            tableLayoutPanel1.Controls.Add(buttonAddPlayer, 1, 3);
            tableLayoutPanel1.Controls.Add(dataGridViewPlayers, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonExit, 4, 4);
            tableLayoutPanel1.Controls.Add(button3, 3, 3);
            tableLayoutPanel1.Controls.Add(buttonMancala, 3, 2);
            tableLayoutPanel1.Controls.Add(buttonYahtzee, 3, 1);
            tableLayoutPanel1.Controls.Add(textBoxAddPlayer, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Настольные игры";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonYahtzee;
        private Button buttonMancala;
        private Button button3;
        private Button buttonStats;
        private Button buttonExit;
        private Button buttonAddPlayer;
        private TextBox textBoxAddPlayer;
        private DataGridView dataGridViewPlayers;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn ColumnSessionWins;
        private Button buttonRemoveUser;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
