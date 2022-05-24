using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BigRedButtonQuiz.Forms
{
    public partial class MainForm : Form
    {
        private readonly List<UserControls.BigRedButtonControl> _buttons = new List<UserControls.BigRedButtonControl>();

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 8; i++)
            {
                var button = new UserControls.BigRedButtonControl(i)
                {
                    Location = new Point(8, 20 + i * 30)
                };
                _buttons.Add(button);
                PlayersGroup.Controls.Add(button);
            }
        }

        private void RefreshPortsButton_Click(object sender, EventArgs e)
        {
            foreach (var button in _buttons)
            {
                button.RefreshPortList();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int activeButtons = 0;
            foreach (var button in _buttons)
            {
                if (button.IsActive) activeButtons++;
            }

            if (activeButtons > 0)
            {
                var gameForm = new GameForm(_buttons);
                gameForm.ShowDialog(this);
                gameForm.Close();
                gameForm.Dispose();
                GC.Collect();
            }
            else
            {
                MessageBox.Show("There are no buttons connected!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}