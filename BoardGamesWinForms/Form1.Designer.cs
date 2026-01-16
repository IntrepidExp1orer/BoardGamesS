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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonStats = new Button();
            button5 = new Button();
            buttonAddPlayer = new Button();
            textBoxAddPlayer = new TextBox();
            dataGridViewPlayers = new DataGridView();
            columnName = new DataGridViewTextBoxColumn();
            ColumnSessionWins = new DataGridViewTextBoxColumn();
            buttonRemoveUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(437, 96);
            button1.Name = "button1";
            button1.Size = new Size(130, 43);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(437, 171);
            button2.Name = "button2";
            button2.Size = new Size(130, 43);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(437, 248);
            button3.Name = "button3";
            button3.Size = new Size(130, 43);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonStats
            // 
            buttonStats.Location = new Point(616, 248);
            buttonStats.Name = "buttonStats";
            buttonStats.Size = new Size(130, 43);
            buttonStats.TabIndex = 3;
            buttonStats.Text = "Статистика";
            buttonStats.UseVisualStyleBackColor = true;
            buttonStats.Click += buttonStats_Click;
            // 
            // button5
            // 
            button5.Location = new Point(616, 337);
            button5.Name = "button5";
            button5.Size = new Size(130, 43);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // buttonAddPlayer
            // 
            buttonAddPlayer.Location = new Point(200, 265);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(97, 26);
            buttonAddPlayer.TabIndex = 5;
            buttonAddPlayer.Text = "Добавить";
            buttonAddPlayer.UseVisualStyleBackColor = true;
            buttonAddPlayer.Click += buttonAddPlayer_Click;
            // 
            // textBoxAddPlayer
            // 
            textBoxAddPlayer.Location = new Point(45, 265);
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
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Columns.AddRange(new DataGridViewColumn[] { columnName, ColumnSessionWins });
            dataGridViewPlayers.Location = new Point(45, 96);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
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
            buttonRemoveUser.Location = new Point(200, 309);
            buttonRemoveUser.Name = "buttonRemoveUser";
            buttonRemoveUser.Size = new Size(97, 23);
            buttonRemoveUser.TabIndex = 8;
            buttonRemoveUser.Text = "Удалить";
            buttonRemoveUser.UseVisualStyleBackColor = true;
            buttonRemoveUser.Click += buttonRemoveUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemoveUser);
            Controls.Add(dataGridViewPlayers);
            Controls.Add(textBoxAddPlayer);
            Controls.Add(buttonAddPlayer);
            Controls.Add(button5);
            Controls.Add(buttonStats);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonStats;
        private Button button5;
        private Button buttonAddPlayer;
        private TextBox textBoxAddPlayer;
        private DataGridView dataGridViewPlayers;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn ColumnSessionWins;
        private Button buttonRemoveUser;
    }
}
