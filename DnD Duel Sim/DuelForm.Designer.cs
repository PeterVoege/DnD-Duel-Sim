namespace DnD_Duel_Sim
{
    partial class DuelForm
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
            this.CombatLog = new System.Windows.Forms.RichTextBox();
            this.NextTurnButton = new System.Windows.Forms.Button();
            this.EndFightButton = new System.Windows.Forms.Button();
            this.Char1StatHeader = new System.Windows.Forms.Label();
            this.Char2StatHeader = new System.Windows.Forms.Label();
            this.Char2RaceLabel = new System.Windows.Forms.Label();
            this.Char1RaceLabel = new System.Windows.Forms.Label();
            this.Char1StatsLabel = new System.Windows.Forms.Label();
            this.Char2StatsLabel = new System.Windows.Forms.Label();
            this.Char1LevelLabel = new System.Windows.Forms.Label();
            this.Char2LevelLabel = new System.Windows.Forms.Label();
            this.Char2NameLabel = new System.Windows.Forms.Label();
            this.Char1NameLabel = new System.Windows.Forms.Label();
            this.Char1HPLabel = new System.Windows.Forms.Label();
            this.Char2HPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CombatLog
            // 
            this.CombatLog.Location = new System.Drawing.Point(52, 168);
            this.CombatLog.Name = "CombatLog";
            this.CombatLog.Size = new System.Drawing.Size(661, 222);
            this.CombatLog.TabIndex = 0;
            this.CombatLog.Text = "";
            // 
            // NextTurnButton
            // 
            this.NextTurnButton.Location = new System.Drawing.Point(233, 420);
            this.NextTurnButton.Name = "NextTurnButton";
            this.NextTurnButton.Size = new System.Drawing.Size(81, 30);
            this.NextTurnButton.TabIndex = 1;
            this.NextTurnButton.Text = "Next Turn";
            this.NextTurnButton.UseVisualStyleBackColor = true;
            this.NextTurnButton.Click += new System.EventHandler(this.NextTurnButton_Click);
            // 
            // EndFightButton
            // 
            this.EndFightButton.Location = new System.Drawing.Point(439, 420);
            this.EndFightButton.Name = "EndFightButton";
            this.EndFightButton.Size = new System.Drawing.Size(82, 30);
            this.EndFightButton.TabIndex = 2;
            this.EndFightButton.Text = "End Fight";
            this.EndFightButton.UseVisualStyleBackColor = true;
            this.EndFightButton.Click += new System.EventHandler(this.EndFightButton_Click);
            // 
            // Char1StatHeader
            // 
            this.Char1StatHeader.Location = new System.Drawing.Point(155, 93);
            this.Char1StatHeader.Name = "Char1StatHeader";
            this.Char1StatHeader.Size = new System.Drawing.Size(190, 17);
            this.Char1StatHeader.TabIndex = 31;
            this.Char1StatHeader.Text = "Str/Dex/Con/Int/Wis/Cha";
            this.Char1StatHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char2StatHeader
            // 
            this.Char2StatHeader.Location = new System.Drawing.Point(395, 93);
            this.Char2StatHeader.Name = "Char2StatHeader";
            this.Char2StatHeader.Size = new System.Drawing.Size(190, 17);
            this.Char2StatHeader.TabIndex = 30;
            this.Char2StatHeader.Text = "Str/Dex/Con/Int/Wis/Cha";
            this.Char2StatHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char2RaceLabel
            // 
            this.Char2RaceLabel.Location = new System.Drawing.Point(395, 70);
            this.Char2RaceLabel.Name = "Char2RaceLabel";
            this.Char2RaceLabel.Size = new System.Drawing.Size(190, 17);
            this.Char2RaceLabel.TabIndex = 29;
            this.Char2RaceLabel.Text = "Race/Background";
            this.Char2RaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char1RaceLabel
            // 
            this.Char1RaceLabel.Location = new System.Drawing.Point(155, 70);
            this.Char1RaceLabel.Name = "Char1RaceLabel";
            this.Char1RaceLabel.Size = new System.Drawing.Size(190, 17);
            this.Char1RaceLabel.TabIndex = 28;
            this.Char1RaceLabel.Text = "Race/Background";
            this.Char1RaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char1StatsLabel
            // 
            this.Char1StatsLabel.Location = new System.Drawing.Point(155, 110);
            this.Char1StatsLabel.Name = "Char1StatsLabel";
            this.Char1StatsLabel.Size = new System.Drawing.Size(190, 17);
            this.Char1StatsLabel.TabIndex = 27;
            this.Char1StatsLabel.Text = "Stats";
            this.Char1StatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char2StatsLabel
            // 
            this.Char2StatsLabel.Location = new System.Drawing.Point(395, 110);
            this.Char2StatsLabel.Name = "Char2StatsLabel";
            this.Char2StatsLabel.Size = new System.Drawing.Size(190, 17);
            this.Char2StatsLabel.TabIndex = 26;
            this.Char2StatsLabel.Text = "Stats";
            this.Char2StatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char1LevelLabel
            // 
            this.Char1LevelLabel.Location = new System.Drawing.Point(155, 47);
            this.Char1LevelLabel.Name = "Char1LevelLabel";
            this.Char1LevelLabel.Size = new System.Drawing.Size(190, 17);
            this.Char1LevelLabel.TabIndex = 25;
            this.Char1LevelLabel.Text = "Level/Class";
            this.Char1LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char2LevelLabel
            // 
            this.Char2LevelLabel.Location = new System.Drawing.Point(395, 47);
            this.Char2LevelLabel.Name = "Char2LevelLabel";
            this.Char2LevelLabel.Size = new System.Drawing.Size(190, 17);
            this.Char2LevelLabel.TabIndex = 24;
            this.Char2LevelLabel.Text = "Level/Class";
            this.Char2LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char2NameLabel
            // 
            this.Char2NameLabel.Location = new System.Drawing.Point(395, 24);
            this.Char2NameLabel.Name = "Char2NameLabel";
            this.Char2NameLabel.Size = new System.Drawing.Size(190, 17);
            this.Char2NameLabel.TabIndex = 23;
            this.Char2NameLabel.Text = "Name";
            this.Char2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char1NameLabel
            // 
            this.Char1NameLabel.Location = new System.Drawing.Point(155, 24);
            this.Char1NameLabel.Name = "Char1NameLabel";
            this.Char1NameLabel.Size = new System.Drawing.Size(190, 17);
            this.Char1NameLabel.TabIndex = 22;
            this.Char1NameLabel.Text = "Name";
            this.Char1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char1HPLabel
            // 
            this.Char1HPLabel.Location = new System.Drawing.Point(155, 133);
            this.Char1HPLabel.Name = "Char1HPLabel";
            this.Char1HPLabel.Size = new System.Drawing.Size(190, 17);
            this.Char1HPLabel.TabIndex = 32;
            this.Char1HPLabel.Text = "HP/MaxHP";
            this.Char1HPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char2HPLabel
            // 
            this.Char2HPLabel.Location = new System.Drawing.Point(395, 133);
            this.Char2HPLabel.Name = "Char2HPLabel";
            this.Char2HPLabel.Size = new System.Drawing.Size(190, 17);
            this.Char2HPLabel.TabIndex = 32;
            this.Char2HPLabel.Text = "HP/MaxHP";
            this.Char2HPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.Char2HPLabel);
            this.Controls.Add(this.Char1HPLabel);
            this.Controls.Add(this.Char1StatHeader);
            this.Controls.Add(this.Char2StatHeader);
            this.Controls.Add(this.Char2RaceLabel);
            this.Controls.Add(this.Char1RaceLabel);
            this.Controls.Add(this.Char1StatsLabel);
            this.Controls.Add(this.Char2StatsLabel);
            this.Controls.Add(this.Char1LevelLabel);
            this.Controls.Add(this.Char2LevelLabel);
            this.Controls.Add(this.Char2NameLabel);
            this.Controls.Add(this.Char1NameLabel);
            this.Controls.Add(this.EndFightButton);
            this.Controls.Add(this.NextTurnButton);
            this.Controls.Add(this.CombatLog);
            this.Name = "DuelForm";
            this.Text = "DuelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CombatLog;
        private System.Windows.Forms.Button NextTurnButton;
        private System.Windows.Forms.Button EndFightButton;
        private System.Windows.Forms.Label Char1StatHeader;
        private System.Windows.Forms.Label Char2StatHeader;
        private System.Windows.Forms.Label Char2RaceLabel;
        private System.Windows.Forms.Label Char1RaceLabel;
        private System.Windows.Forms.Label Char1StatsLabel;
        private System.Windows.Forms.Label Char2StatsLabel;
        private System.Windows.Forms.Label Char1LevelLabel;
        private System.Windows.Forms.Label Char2LevelLabel;
        private System.Windows.Forms.Label Char2NameLabel;
        private System.Windows.Forms.Label Char1NameLabel;
        private System.Windows.Forms.Label Char1HPLabel;
        private System.Windows.Forms.Label Char2HPLabel;
    }
}