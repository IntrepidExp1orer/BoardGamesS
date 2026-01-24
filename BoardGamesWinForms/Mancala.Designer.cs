namespace BoardGamesWinForms
{
    partial class Mancala
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
            tableLayoutPanel = new TableLayoutPanel();
            buttonStart = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.BurlyWood;
            tableLayoutPanel.ColumnCount = 8;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.49953F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4995317F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5032816F));
            tableLayoutPanel.Location = new Point(100, 46);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel.Size = new Size(594, 285);
            tableLayoutPanel.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(192, 255, 192);
            buttonStart.ForeColor = SystemColors.ControlText;
            buttonStart.Location = new Point(356, 357);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(81, 69);
            buttonStart.TabIndex = 8;
            buttonStart.Text = "Начать";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 344);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(656, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // Mancala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Controls.Add(tableLayoutPanel);
            Name = "Mancala";
            Text = "Mancala";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Button buttonStart;
        private Label label1;
        private Label label2;
    }
}