
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AnswerLabelD = new System.Windows.Forms.Label();
            this.AnswerLabelC = new System.Windows.Forms.Label();
            this.AnswerLabelB = new System.Windows.Forms.Label();
            this.AnswerLabelA = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SeparatorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HighStakeCheckBox);
            this.groupBox1.Controls.Add(this.StopAudioButton);
            this.groupBox1.Controls.Add(this.MainThemeButton);
            this.groupBox1.Controls.Add(this.FastBackgroundCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(109, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 121);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // HighStakeCheckBox
            // 
            this.HighStakeCheckBox.AutoSize = true;
            this.HighStakeCheckBox.Location = new System.Drawing.Point(6, 68);
            this.HighStakeCheckBox.Name = "HighStakeCheckBox";
            this.HighStakeCheckBox.Size = new System.Drawing.Size(112, 17);
            this.HighStakeCheckBox.TabIndex = 8;
            this.HighStakeCheckBox.Text = "&High stake reward";
            this.HighStakeCheckBox.UseVisualStyleBackColor = true;
            // 
            // StopAudioButton
            // 
            this.StopAudioButton.Location = new System.Drawing.Point(113, 19);
            this.StopAudioButton.Name = "StopAudioButton";
            this.StopAudioButton.Size = new System.Drawing.Size(30, 30);
            this.StopAudioButton.TabIndex = 7;
            this.StopAudioButton.Text = "⏹";
            this.StopAudioButton.UseVisualStyleBackColor = true;
            this.StopAudioButton.Click += new System.EventHandler(this.StopAudioButton_Click);
            // 
            // MainThemeButton
            // 
            this.MainThemeButton.Location = new System.Drawing.Point(6, 19);
            this.MainThemeButton.Name = "MainThemeButton";
            this.MainThemeButton.Size = new System.Drawing.Size(101, 30);
            this.MainThemeButton.TabIndex = 6;
            this.MainThemeButton.Text = "Main Theme ▶";
            this.MainThemeButton.UseVisualStyleBackColor = true;
            this.MainThemeButton.Click += new System.EventHandler(this.MainThemeButton_Click);
            // 
            // FastBackgroundCheckBox
            // 
            this.FastBackgroundCheckBox.AutoSize = true;
            this.FastBackgroundCheckBox.Location = new System.Drawing.Point(6, 91);
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
            this.RoundResultLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundResultLabel.Location = new System.Drawing.Point(279, 387);
            this.RoundResultLabel.Name = "RoundResultLabel";
            this.RoundResultLabel.Size = new System.Drawing.Size(389, 65);
            this.RoundResultLabel.TabIndex = 16;
            this.RoundResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewRoundButton
            // 
            this.NewRoundButton.Location = new System.Drawing.Point(280, 458);
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
            this.WrongButton.Location = new System.Drawing.Point(543, 458);
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
            this.CorrectButton.Location = new System.Drawing.Point(411, 458);
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
            this.MainPanel.Controls.Add(this.SeparatorLabel);
            this.MainPanel.Controls.Add(this.groupBox3);
            this.MainPanel.Controls.Add(this.groupBox2);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.RoundResultLabel);
            this.MainPanel.Controls.Add(this.NewRoundButton);
            this.MainPanel.Controls.Add(this.CorrectButton);
            this.MainPanel.Controls.Add(this.WrongButton);
            this.MainPanel.Location = new System.Drawing.Point(63, 35);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(780, 510);
            this.MainPanel.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AnswerLabelD);
            this.groupBox3.Controls.Add(this.AnswerLabelC);
            this.groupBox3.Controls.Add(this.AnswerLabelB);
            this.groupBox3.Controls.Add(this.AnswerLabelA);
            this.groupBox3.Location = new System.Drawing.Point(3, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(771, 182);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Válasz lista";
            // 
            // AnswerLabelD
            // 
            this.AnswerLabelD.AutoSize = true;
            this.AnswerLabelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabelD.Location = new System.Drawing.Point(6, 151);
            this.AnswerLabelD.Name = "AnswerLabelD";
            this.AnswerLabelD.Size = new System.Drawing.Size(24, 18);
            this.AnswerLabelD.TabIndex = 3;
            this.AnswerLabelD.Text = "D)";
            // 
            // AnswerLabelC
            // 
            this.AnswerLabelC.AutoSize = true;
            this.AnswerLabelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabelC.Location = new System.Drawing.Point(6, 104);
            this.AnswerLabelC.Name = "AnswerLabelC";
            this.AnswerLabelC.Size = new System.Drawing.Size(24, 18);
            this.AnswerLabelC.TabIndex = 2;
            this.AnswerLabelC.Text = "C)";
            // 
            // AnswerLabelB
            // 
            this.AnswerLabelB.AutoSize = true;
            this.AnswerLabelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabelB.Location = new System.Drawing.Point(6, 67);
            this.AnswerLabelB.Name = "AnswerLabelB";
            this.AnswerLabelB.Size = new System.Drawing.Size(23, 18);
            this.AnswerLabelB.TabIndex = 1;
            this.AnswerLabelB.Text = "B)";
            // 
            // AnswerLabelA
            // 
            this.AnswerLabelA.AutoSize = true;
            this.AnswerLabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabelA.Location = new System.Drawing.Point(6, 26);
            this.AnswerLabelA.Name = "AnswerLabelA";
            this.AnswerLabelA.Size = new System.Drawing.Size(22, 18);
            this.AnswerLabelA.TabIndex = 0;
            this.AnswerLabelA.Text = "A)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QuestionLabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 107);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kérdés";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(3, 16);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(765, 88);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = resources.GetString("QuestionLabel.Text");
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeparatorLabel
            // 
            this.SeparatorLabel.BackColor = System.Drawing.Color.Black;
            this.SeparatorLabel.Location = new System.Drawing.Point(0, 117);
            this.SeparatorLabel.Name = "SeparatorLabel";
            this.SeparatorLabel.Size = new System.Drawing.Size(780, 2);
            this.SeparatorLabel.TabIndex = 20;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 580);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label AnswerLabelD;
        private System.Windows.Forms.Label AnswerLabelC;
        private System.Windows.Forms.Label AnswerLabelB;
        private System.Windows.Forms.Label AnswerLabelA;
        private System.Windows.Forms.Label SeparatorLabel;
    }
}