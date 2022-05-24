namespace BigRedButtonQuiz
{
    partial class MainForm
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
            this.NewRoundButton = new System.Windows.Forms.Button();
            this.RoundResultLabel = new System.Windows.Forms.Label();
            this.PlayersGroup = new System.Windows.Forms.GroupBox();
            this.RefreshPortsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HighStakeCheckBox = new System.Windows.Forms.CheckBox();
            this.StopAudioButton = new System.Windows.Forms.Button();
            this.MainThemeButton = new System.Windows.Forms.Button();
            this.FastBackgroundCheckBox = new System.Windows.Forms.CheckBox();
            this.CorrectButton = new System.Windows.Forms.Button();
            this.WrongButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewRoundButton
            // 
            this.NewRoundButton.Location = new System.Drawing.Point(430, 255);
            this.NewRoundButton.Name = "NewRoundButton";
            this.NewRoundButton.Size = new System.Drawing.Size(126, 51);
            this.NewRoundButton.TabIndex = 7;
            this.NewRoundButton.Text = "&NEW ROUND";
            this.NewRoundButton.UseVisualStyleBackColor = true;
            this.NewRoundButton.Click += new System.EventHandler(this.NewRoundButton_Click);
            // 
            // RoundResultLabel
            // 
            this.RoundResultLabel.BackColor = System.Drawing.SystemColors.Window;
            this.RoundResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoundResultLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundResultLabel.Location = new System.Drawing.Point(430, 9);
            this.RoundResultLabel.Name = "RoundResultLabel";
            this.RoundResultLabel.Size = new System.Drawing.Size(389, 234);
            this.RoundResultLabel.TabIndex = 9;
            this.RoundResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayersGroup
            // 
            this.PlayersGroup.Location = new System.Drawing.Point(12, 12);
            this.PlayersGroup.Name = "PlayersGroup";
            this.PlayersGroup.Size = new System.Drawing.Size(392, 268);
            this.PlayersGroup.TabIndex = 10;
            this.PlayersGroup.TabStop = false;
            this.PlayersGroup.Text = "Players";
            // 
            // RefreshPortsButton
            // 
            this.RefreshPortsButton.Location = new System.Drawing.Point(12, 286);
            this.RefreshPortsButton.Name = "RefreshPortsButton";
            this.RefreshPortsButton.Size = new System.Drawing.Size(145, 23);
            this.RefreshPortsButton.TabIndex = 11;
            this.RefreshPortsButton.Text = "Refresh port list";
            this.RefreshPortsButton.UseVisualStyleBackColor = true;
            this.RefreshPortsButton.Click += new System.EventHandler(this.RefreshPortsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HighStakeCheckBox);
            this.groupBox1.Controls.Add(this.StopAudioButton);
            this.groupBox1.Controls.Add(this.MainThemeButton);
            this.groupBox1.Controls.Add(this.FastBackgroundCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(842, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 294);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound Deck";
            // 
            // HighStakeCheckBox
            // 
            this.HighStakeCheckBox.AutoSize = true;
            this.HighStakeCheckBox.Location = new System.Drawing.Point(6, 114);
            this.HighStakeCheckBox.Name = "HighStakeCheckBox";
            this.HighStakeCheckBox.Size = new System.Drawing.Size(112, 17);
            this.HighStakeCheckBox.TabIndex = 8;
            this.HighStakeCheckBox.Text = "&High stake reward";
            this.HighStakeCheckBox.UseVisualStyleBackColor = true;
            // 
            // StopAudioButton
            // 
            this.StopAudioButton.Location = new System.Drawing.Point(6, 55);
            this.StopAudioButton.Name = "StopAudioButton";
            this.StopAudioButton.Size = new System.Drawing.Size(137, 30);
            this.StopAudioButton.TabIndex = 7;
            this.StopAudioButton.Text = "Stop playback";
            this.StopAudioButton.UseVisualStyleBackColor = true;
            this.StopAudioButton.Click += new System.EventHandler(this.StopAudioButton_Click);
            // 
            // MainThemeButton
            // 
            this.MainThemeButton.Location = new System.Drawing.Point(6, 19);
            this.MainThemeButton.Name = "MainThemeButton";
            this.MainThemeButton.Size = new System.Drawing.Size(137, 30);
            this.MainThemeButton.TabIndex = 6;
            this.MainThemeButton.Text = "Main Theme ▶";
            this.MainThemeButton.UseVisualStyleBackColor = true;
            this.MainThemeButton.Click += new System.EventHandler(this.MainThemeButton_Click);
            // 
            // FastBackgroundCheckBox
            // 
            this.FastBackgroundCheckBox.AutoSize = true;
            this.FastBackgroundCheckBox.Location = new System.Drawing.Point(6, 137);
            this.FastBackgroundCheckBox.Name = "FastBackgroundCheckBox";
            this.FastBackgroundCheckBox.Size = new System.Drawing.Size(136, 17);
            this.FastBackgroundCheckBox.TabIndex = 0;
            this.FastBackgroundCheckBox.Text = "&Fast background music";
            this.FastBackgroundCheckBox.UseVisualStyleBackColor = true;
            // 
            // CorrectButton
            // 
            this.CorrectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CorrectButton.Enabled = false;
            this.CorrectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectButton.ForeColor = System.Drawing.Color.White;
            this.CorrectButton.Location = new System.Drawing.Point(562, 255);
            this.CorrectButton.Name = "CorrectButton";
            this.CorrectButton.Size = new System.Drawing.Size(131, 50);
            this.CorrectButton.TabIndex = 1;
            this.CorrectButton.Text = "&CORRECT";
            this.CorrectButton.UseVisualStyleBackColor = false;
            this.CorrectButton.Click += new System.EventHandler(this.CorrectButton_Click);
            // 
            // WrongButton
            // 
            this.WrongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WrongButton.Enabled = false;
            this.WrongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongButton.ForeColor = System.Drawing.Color.White;
            this.WrongButton.Location = new System.Drawing.Point(699, 256);
            this.WrongButton.Name = "WrongButton";
            this.WrongButton.Size = new System.Drawing.Size(120, 50);
            this.WrongButton.TabIndex = 3;
            this.WrongButton.Text = "&WRONG";
            this.WrongButton.UseVisualStyleBackColor = false;
            this.WrongButton.Click += new System.EventHandler(this.WrongButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 318);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RefreshPortsButton);
            this.Controls.Add(this.PlayersGroup);
            this.Controls.Add(this.RoundResultLabel);
            this.Controls.Add(this.NewRoundButton);
            this.Controls.Add(this.WrongButton);
            this.Controls.Add(this.CorrectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Red Button Assisted Quiz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewRoundButton;
        private System.Windows.Forms.Label RoundResultLabel;
        private System.Windows.Forms.GroupBox PlayersGroup;
        private System.Windows.Forms.Button RefreshPortsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox FastBackgroundCheckBox;
        private System.Windows.Forms.Button MainThemeButton;
        private System.Windows.Forms.Button WrongButton;
        private System.Windows.Forms.Button CorrectButton;
        private System.Windows.Forms.Button StopAudioButton;
        private System.Windows.Forms.CheckBox HighStakeCheckBox;
    }
}

