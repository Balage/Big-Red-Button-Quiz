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
            this.SuspendLayout();
            // 
            // NewRoundButton
            // 
            this.NewRoundButton.Location = new System.Drawing.Point(430, 255);
            this.NewRoundButton.Name = "NewRoundButton";
            this.NewRoundButton.Size = new System.Drawing.Size(389, 51);
            this.NewRoundButton.TabIndex = 7;
            this.NewRoundButton.Text = "NEW ROUND";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 318);
            this.Controls.Add(this.RefreshPortsButton);
            this.Controls.Add(this.PlayersGroup);
            this.Controls.Add(this.RoundResultLabel);
            this.Controls.Add(this.NewRoundButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Red Button Assisted Quiz";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewRoundButton;
        private System.Windows.Forms.Label RoundResultLabel;
        private System.Windows.Forms.GroupBox PlayersGroup;
        private System.Windows.Forms.Button RefreshPortsButton;
    }
}

