namespace DnD_Duel_Sim
{
    partial class Fighter_Generator
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.LevelSelector = new System.Windows.Forms.ComboBox();
            this.divider1 = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(151, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Manual";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(233, 251);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 21);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Random";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(322, 251);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Preset";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Martial Archetype";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(102, 289);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 21);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Champion";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(201, 289);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 21);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Battle Master";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(320, 289);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(121, 21);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Eldritch Knight";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // LevelSelector
            // 
            this.LevelSelector.FormattingEnabled = true;
            this.LevelSelector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.LevelSelector.Location = new System.Drawing.Point(233, 35);
            this.LevelSelector.Name = "LevelSelector";
            this.LevelSelector.Size = new System.Drawing.Size(58, 24);
            this.LevelSelector.TabIndex = 8;
            // 
            // divider1
            // 
            this.divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider1.Location = new System.Drawing.Point(88, 216);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(362, 2);
            this.divider1.TabIndex = 9;
            this.divider1.Text = "label2";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(181, 38);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(46, 17);
            this.levelLabel.TabIndex = 10;
            this.levelLabel.Text = "Level:";
            // 
            // Fighter_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 679);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.LevelSelector);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Fighter_Generator";
            this.Text = "Fighter Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ComboBox LevelSelector;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label levelLabel;
    }
}