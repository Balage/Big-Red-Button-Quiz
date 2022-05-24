namespace BigRedButtonQuiz.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PlayersGroup = new System.Windows.Forms.GroupBox();
            this.RefreshPortsButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.RefreshPortsButton.Size = new System.Drawing.Size(130, 30);
            this.RefreshPortsButton.TabIndex = 11;
            this.RefreshPortsButton.Text = "Refresh port list";
            this.RefreshPortsButton.UseVisualStyleBackColor = true;
            this.RefreshPortsButton.Click += new System.EventHandler(this.RefreshPortsButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(274, 286);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(130, 30);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = ">>  Start Game!  >>";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 328);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.RefreshPortsButton);
            this.Controls.Add(this.PlayersGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Red Button Assisted Quiz - Setup";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox PlayersGroup;
        private System.Windows.Forms.Button RefreshPortsButton;
        private System.Windows.Forms.Button StartButton;
    }
}

