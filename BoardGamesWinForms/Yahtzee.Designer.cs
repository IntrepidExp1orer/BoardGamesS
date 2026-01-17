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
            SuspendLayout();
            // 
            // diceElement1
            // 
            diceElement1.IsLocked = false;
            diceElement1.Location = new Point(133, 328);
            diceElement1.Name = "diceElement1";
            diceElement1.Size = new Size(64, 64);
            diceElement1.TabIndex = 0;
            // 
            // diceElement2
            // 
            diceElement2.IsLocked = false;
            diceElement2.Location = new Point(254, 328);
            diceElement2.Name = "diceElement2";
            diceElement2.Size = new Size(64, 64);
            diceElement2.TabIndex = 1;
            // 
            // diceElement3
            // 
            diceElement3.IsLocked = false;
            diceElement3.Location = new Point(383, 328);
            diceElement3.Name = "diceElement3";
            diceElement3.Size = new Size(64, 64);
            diceElement3.TabIndex = 2;
            // 
            // diceElement4
            // 
            diceElement4.IsLocked = false;
            diceElement4.Location = new Point(501, 328);
            diceElement4.Name = "diceElement4";
            diceElement4.Size = new Size(64, 64);
            diceElement4.TabIndex = 3;
            // 
            // diceElement5
            // 
            diceElement5.IsLocked = false;
            diceElement5.Location = new Point(618, 328);
            diceElement5.Name = "diceElement5";
            diceElement5.Size = new Size(64, 64);
            diceElement5.TabIndex = 4;
            // 
            // Yahtzee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(diceElement5);
            Controls.Add(diceElement4);
            Controls.Add(diceElement3);
            Controls.Add(diceElement2);
            Controls.Add(diceElement1);
            Name = "Yahtzee";
            Text = "Yahtzee";
            ResumeLayout(false);
        }

        #endregion

        private DiceElement diceElement1;
        private DiceElement diceElement2;
        private DiceElement diceElement3;
        private DiceElement diceElement4;
        private DiceElement diceElement5;
    }
}