namespace BoardGamesWinForms
{
    partial class Stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewStats = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnTotalWins = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStats
            // 
            dataGridViewStats.AllowUserToAddRows = false;
            dataGridViewStats.AllowUserToDeleteRows = false;
            dataGridViewStats.AllowUserToResizeColumns = false;
            dataGridViewStats.AllowUserToResizeRows = false;
            dataGridViewStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStats.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnTotalWins });
            dataGridViewStats.Location = new Point(165, 112);
            dataGridViewStats.Name = "dataGridViewStats";
            dataGridViewStats.ReadOnly = true;
            dataGridViewStats.Size = new Size(495, 231);
            dataGridViewStats.TabIndex = 0;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "name";
            ColumnName.HeaderText = "Имя";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            // 
            // ColumnTotalWins
            // 
            ColumnTotalWins.DataPropertyName = "totalWins";
            ColumnTotalWins.HeaderText = "Всего побед";
            ColumnTotalWins.Name = "ColumnTotalWins";
            ColumnTotalWins.ReadOnly = true;
            // 
            // Stats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewStats);
            Name = "Stats";
            Text = "Stats";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewStats;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnTotalWins;
    }
}