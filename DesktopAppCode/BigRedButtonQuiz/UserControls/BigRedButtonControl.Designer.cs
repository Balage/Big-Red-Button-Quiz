
namespace BigRedButtonQuiz.UserControls
{
    partial class BigRedButtonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IndexLabel = new System.Windows.Forms.Label();
            this.SerialPortList = new System.Windows.Forms.ComboBox();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IndexLabel
            // 
            this.IndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IndexLabel.Location = new System.Drawing.Point(0, 0);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(30, 23);
            this.IndexLabel.TabIndex = 0;
            this.IndexLabel.Text = "999.";
            this.IndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SerialPortList
            // 
            this.SerialPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialPortList.FormattingEnabled = true;
            this.SerialPortList.Location = new System.Drawing.Point(30, 1);
            this.SerialPortList.Name = "SerialPortList";
            this.SerialPortList.Size = new System.Drawing.Size(60, 21);
            this.SerialPortList.TabIndex = 1;
            this.SerialPortList.SelectedIndexChanged += new System.EventHandler(this.SerialPortList_SelectedIndexChanged);
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Location = new System.Drawing.Point(96, 1);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.PlayerNameTextBox.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Location = new System.Drawing.Point(242, 1);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(90, 21);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "StatusLabel";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestButton
            // 
            this.TestButton.Enabled = false;
            this.TestButton.Location = new System.Drawing.Point(338, 1);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(36, 21);
            this.TestButton.TabIndex = 4;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TestButton_MouseDown);
            this.TestButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TestButton_MouseUp);
            // 
            // BigRedButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.SerialPortList);
            this.Controls.Add(this.IndexLabel);
            this.Name = "BigRedButtonControl";
            this.Size = new System.Drawing.Size(378, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.ComboBox SerialPortList;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button TestButton;
    }
}
