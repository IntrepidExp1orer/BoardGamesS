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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewStats
            // 
            dataGridViewStats.AllowUserToAddRows = false;
            dataGridViewStats.AllowUserToDeleteRows = false;
            dataGridViewStats.AllowUserToResizeColumns = false;
            dataGridViewStats.AllowUserToResizeRows = false;
            dataGridViewStats.Anchor = AnchorStyles.Top;
            dataGridViewStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStats.BackgroundColor = Color.DarkSlateGray;
            dataGridViewStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStats.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnTotalWins });
            dataGridViewStats.Location = new Point(152, 93);
            dataGridViewStats.Name = "dataGridViewStats";
            dataGridViewStats.ReadOnly = true;
            dataGridViewStats.RowHeadersVisible = false;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.SeaShell;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridViewStats, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 29);
            label1.Name = "label1";
            label1.Size = new Size(207, 31);
            label1.TabIndex = 1;
            label1.Text = "Полная статистика";
            // 
            // Stats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Stats";
            Text = "Stats";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewStats;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnTotalWins;
    }
}