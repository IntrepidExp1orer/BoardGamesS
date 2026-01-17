namespace BoardGamesWinForms
{
    partial class Yahtzee
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
            diceElement1 = new DiceElement();
            diceElement2 = new DiceElement();
            diceElement3 = new DiceElement();
            diceElement4 = new DiceElement();
            diceElement5 = new DiceElement();
            buttonRoll = new Button();
            dataGridViewScore = new DataGridView();
            buttonStart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewScore).BeginInit();
            SuspendLayout();
            // 
            // diceElement1
            // 
            diceElement1.IsLocked = false;
            diceElement1.Location = new Point(120, 308);
            diceElement1.Name = "diceElement1";
            diceElement1.Size = new Size(64, 64);
            diceElement1.TabIndex = 0;
            // 
            // diceElement2
            // 
            diceElement2.IsLocked = false;
            diceElement2.Location = new Point(241, 308);
            diceElement2.Name = "diceElement2";
            diceElement2.Size = new Size(64, 64);
            diceElement2.TabIndex = 1;
            // 
            // diceElement3
            // 
            diceElement3.IsLocked = false;
            diceElement3.Location = new Point(359, 308);
            diceElement3.Name = "diceElement3";
            diceElement3.Size = new Size(64, 64);
            diceElement3.TabIndex = 2;
            // 
            // diceElement4
            // 
            diceElement4.IsLocked = false;
            diceElement4.Location = new Point(476, 308);
            diceElement4.Name = "diceElement4";
            diceElement4.Size = new Size(64, 64);
            diceElement4.TabIndex = 3;
            // 
            // diceElement5
            // 
            diceElement5.IsLocked = false;
            diceElement5.Location = new Point(605, 308);
            diceElement5.Name = "diceElement5";
            diceElement5.Size = new Size(64, 64);
            diceElement5.TabIndex = 4;
            // 
            // buttonRoll
            // 
            buttonRoll.Enabled = false;
            buttonRoll.Location = new Point(343, 398);
            buttonRoll.Name = "buttonRoll";
            buttonRoll.Size = new Size(101, 40);
            buttonRoll.TabIndex = 5;
            buttonRoll.Text = "Roll";
            buttonRoll.UseVisualStyleBackColor = true;
            buttonRoll.Click += buttonRoll_Click;
            // 
            // dataGridViewScore
            // 
            dataGridViewScore.AllowUserToAddRows = false;
            dataGridViewScore.AllowUserToDeleteRows = false;
            dataGridViewScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewScore.Location = new Point(120, 39);
            dataGridViewScore.Name = "dataGridViewScore";
            dataGridViewScore.ReadOnly = true;
            dataGridViewScore.Size = new Size(549, 248);
            dataGridViewScore.TabIndex = 6;
            dataGridViewScore.CellClick += dataGridViewScore_CellClick;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(192, 255, 192);
            buttonStart.Location = new Point(12, 369);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(81, 69);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Начать";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // Yahtzee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStart);
            Controls.Add(dataGridViewScore);
            Controls.Add(buttonRoll);
            Controls.Add(diceElement5);
            Controls.Add(diceElement4);
            Controls.Add(diceElement3);
            Controls.Add(diceElement2);
            Controls.Add(diceElement1);
            Name = "Yahtzee";
            Text = "Yahtzee";
            ((System.ComponentModel.ISupportInitialize)dataGridViewScore).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DiceElement diceElement1;
        private DiceElement diceElement2;
        private DiceElement diceElement3;
        private DiceElement diceElement4;
        private DiceElement diceElement5;
        private Button buttonRoll;
        private DataGridView dataGridViewScore;
        private Button buttonStart;
    }
}