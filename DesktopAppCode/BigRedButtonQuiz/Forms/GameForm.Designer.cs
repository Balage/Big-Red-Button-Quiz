
namespace BigRedButtonQuiz.Forms
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HighStakeCheckBox = new System.Windows.Forms.CheckBox();
            this.StopAudioButton = new System.Windows.Forms.Button();
            this.MainThemeButton = new System.Windows.Forms.Button();
            this.FastBackgroundCheckBox = new System.Windows.Forms.CheckBox();
            this.RoundResultLabel = new System.Windows.Forms.Label();
            this.NewRoundButton = new System.Windows.Forms.Button();
            this.WrongButton = new System.Windows.Forms.Button();
            this.CorrectButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HighStakeCheckBox);
            this.groupBox1.Controls.Add(this.StopAudioButton);
            this.groupBox1.Controls.Add(this.MainThemeButton);
            this.groupBox1.Controls.Add(this.FastBackgroundCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 297);
            this.groupBox1.TabIndex = 17;
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
            // RoundResultLabel
            // 
            this.RoundResultLabel.BackColor = System.Drawing.SystemColors.Window;
            this.RoundResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoundResultLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundResultLabel.Location = new System.Drawing.Point(173, 3);
            this.RoundResultLabel.Name = "RoundResultLabel";
            this.RoundResultLabel.Size = new System.Drawing.Size(389, 234);
            this.RoundResultLabel.TabIndex = 16;
            this.RoundResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewRoundButton
            // 
            this.NewRoundButton.Location = new System.Drawing.Point(173, 249);
            this.NewRoundButton.Name = "NewRoundButton";
            this.NewRoundButton.Size = new System.Drawing.Size(125, 51);
            this.NewRoundButton.TabIndex = 15;
            this.NewRoundButton.Text = "&NEW ROUND";
            this.NewRoundButton.UseVisualStyleBackColor = true;
            this.NewRoundButton.Click += new System.EventHandler(this.NewRoundButton_Click);
            // 
            // WrongButton
            // 
            this.WrongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WrongButton.Enabled = false;
            this.WrongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongButton.ForeColor = System.Drawing.Color.White;
            this.WrongButton.Location = new System.Drawing.Point(436, 249);
            this.WrongButton.Name = "WrongButton";
            this.WrongButton.Size = new System.Drawing.Size(125, 50);
            this.WrongButton.TabIndex = 14;
            this.WrongButton.Text = "&WRONG";
            this.WrongButton.UseVisualStyleBackColor = false;
            this.WrongButton.Click += new System.EventHandler(this.WrongButton_Click);
            // 
            // CorrectButton
            // 
            this.CorrectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CorrectButton.Enabled = false;
            this.CorrectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectButton.ForeColor = System.Drawing.Color.White;
            this.CorrectButton.Location = new System.Drawing.Point(304, 249);
            this.CorrectButton.Name = "CorrectButton";
            this.CorrectButton.Size = new System.Drawing.Size(126, 50);
            this.CorrectButton.TabIndex = 13;
            this.CorrectButton.Text = "&CORRECT";
            this.CorrectButton.UseVisualStyleBackColor = false;
            this.CorrectButton.Click += new System.EventHandler(this.CorrectButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.RoundResultLabel);
            this.MainPanel.Controls.Add(this.NewRoundButton);
            this.MainPanel.Controls.Add(this.CorrectButton);
            this.MainPanel.Controls.Add(this.WrongButton);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(566, 302);
            this.MainPanel.TabIndex = 18;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 422);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Big Red Button Assisted Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox HighStakeCheckBox;
        private System.Windows.Forms.Button StopAudioButton;
        private System.Windows.Forms.Button MainThemeButton;
        private System.Windows.Forms.CheckBox FastBackgroundCheckBox;
        private System.Windows.Forms.Label RoundResultLabel;
        private System.Windows.Forms.Button NewRoundButton;
        private System.Windows.Forms.Button WrongButton;
        private System.Windows.Forms.Button CorrectButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}