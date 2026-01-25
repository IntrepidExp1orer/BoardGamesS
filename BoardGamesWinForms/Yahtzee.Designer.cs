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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            buttonRules = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewScore).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // diceElement1
            // 
            diceElement1.Anchor = AnchorStyles.None;
            diceElement1.Enabled = false;
            diceElement1.IsLocked = false;
            diceElement1.Location = new Point(20, 8);
            diceElement1.Name = "diceElement1";
            diceElement1.Size = new Size(64, 64);
            diceElement1.TabIndex = 0;
            // 
            // diceElement2
            // 
            diceElement2.Anchor = AnchorStyles.None;
            diceElement2.Enabled = false;
            diceElement2.IsLocked = false;
            diceElement2.Location = new Point(125, 8);
            diceElement2.Name = "diceElement2";
            diceElement2.Size = new Size(64, 64);
            diceElement2.TabIndex = 1;
            // 
            // diceElement3
            // 
            diceElement3.Anchor = AnchorStyles.None;
            diceElement3.Enabled = false;
            diceElement3.IsLocked = false;
            diceElement3.Location = new Point(230, 8);
            diceElement3.Name = "diceElement3";
            diceElement3.Size = new Size(64, 64);
            diceElement3.TabIndex = 2;
            // 
            // diceElement4
            // 
            diceElement4.Anchor = AnchorStyles.None;
            diceElement4.Enabled = false;
            diceElement4.IsLocked = false;
            diceElement4.Location = new Point(335, 8);
            diceElement4.Name = "diceElement4";
            diceElement4.Size = new Size(64, 64);
            diceElement4.TabIndex = 3;
            // 
            // diceElement5
            // 
            diceElement5.Anchor = AnchorStyles.None;
            diceElement5.Enabled = false;
            diceElement5.IsLocked = false;
            diceElement5.Location = new Point(441, 8);
            diceElement5.Name = "diceElement5";
            diceElement5.Size = new Size(64, 64);
            diceElement5.TabIndex = 4;
            // 
            // buttonRoll
            // 
            buttonRoll.Anchor = AnchorStyles.None;
            buttonRoll.BackColor = Color.DarkRed;
            buttonRoll.Enabled = false;
            buttonRoll.ForeColor = SystemColors.ButtonHighlight;
            buttonRoll.Location = new Point(349, 594);
            buttonRoll.Name = "buttonRoll";
            buttonRoll.Size = new Size(101, 40);
            buttonRoll.TabIndex = 5;
            buttonRoll.Text = "Roll (3/3)";
            buttonRoll.UseVisualStyleBackColor = false;
            buttonRoll.Click += buttonRoll_Click;
            // 
            // dataGridViewScore
            // 
            dataGridViewScore.AllowUserToAddRows = false;
            dataGridViewScore.AllowUserToDeleteRows = false;
            dataGridViewScore.AllowUserToResizeColumns = false;
            dataGridViewScore.AllowUserToResizeRows = false;
            dataGridViewScore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewScore.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewScore.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewScore.Location = new Point(136, 61);
            dataGridViewScore.MultiSelect = false;
            dataGridViewScore.Name = "dataGridViewScore";
            dataGridViewScore.RowHeadersVisible = false;
            dataGridViewScore.ShowEditingIcon = false;
            dataGridViewScore.Size = new Size(527, 375);
            dataGridViewScore.TabIndex = 6;
            dataGridViewScore.CellClick += dataGridViewScore_CellClick;
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.None;
            buttonStart.BackColor = Color.Aquamarine;
            buttonStart.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStart.Location = new Point(26, 506);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(81, 69);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(diceElement1, 0, 0);
            tableLayoutPanel1.Controls.Add(diceElement2, 1, 0);
            tableLayoutPanel1.Controls.Add(diceElement3, 2, 0);
            tableLayoutPanel1.Controls.Add(diceElement4, 3, 0);
            tableLayoutPanel1.Controls.Add(diceElement5, 4, 0);
            tableLayoutPanel1.Location = new Point(136, 500);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(527, 81);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.RosyBrown;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(dataGridViewScore, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 2);
            tableLayoutPanel2.Controls.Add(buttonStart, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonRoll, 1, 3);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonRules, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 68.1818161F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.636364F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.Size = new Size(800, 645);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.RosyBrown;
            label3.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 9);
            label3.Name = "label3";
            label3.Size = new Size(160, 40);
            label3.TabIndex = 12;
            label3.Text = "Yahtzee";
            // 
            // buttonRules
            // 
            buttonRules.Anchor = AnchorStyles.None;
            buttonRules.BackColor = Color.White;
            buttonRules.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRules.ForeColor = SystemColors.ActiveCaptionText;
            buttonRules.Location = new Point(710, 6);
            buttonRules.Name = "buttonRules";
            buttonRules.Padding = new Padding(2);
            buttonRules.Size = new Size(45, 45);
            buttonRules.TabIndex = 13;
            buttonRules.Text = "?";
            buttonRules.UseVisualStyleBackColor = false;
            buttonRules.Visible = false;
            buttonRules.Click += buttonRules_Click;
            // 
            // Yahtzee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 645);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Yahtzee";
            Text = "Yahtzee";
            ((System.ComponentModel.ISupportInitialize)dataGridViewScore).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Button buttonRules;
    }
}