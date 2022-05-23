using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BigRedButtonQuiz
{
    public partial class MainForm : Form
    {
        private List<UserControls.BigRedButtonControl> _buttons = new List<UserControls.BigRedButtonControl>();

        enum RoundStateEnum
        {
            Prepare,
            Active,
            Result
        }
        private RoundStateEnum _roundState = RoundStateEnum.Prepare;

        public MainForm()
        {
            InitializeComponent();
            UpdateRoundState(RoundStateEnum.Prepare);

            for (int i = 0; i < 8; i++)
            {
                var button = new UserControls.BigRedButtonControl(i)
                {
                    Location = new System.Drawing.Point(8, 20 + i * 30)
                };
                button.ButtonPress += ButtonPressEvent;
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

        private void NewRoundButton_Click(object sender, EventArgs e)
        {
            int activeButtons = 0;
            foreach (var button in _buttons)
            {
                if (button.IsActive)
                {
                    activeButtons++;
                    button.SetLED(false);
                }
            }
            if (activeButtons > 0)
            {
                UpdateRoundState(RoundStateEnum.Active);
            }
            else
            {
                MessageBox.Show("There are no buttons connected!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonPressEvent(object sender, UserControls.BigRedButtonControl.ButtonPressEventArgs e)
        {
            if (_roundState == RoundStateEnum.Active)
            {
                UpdateRoundState(RoundStateEnum.Result);
                _buttons[e.ButtonIndex].SetLED(true);
                RoundResultLabel.Text = $"{e.PlayerName} won!";
            }
        }

        private void UpdateRoundState(RoundStateEnum state)
        {
            _roundState = state;
            switch (state)
            {
                case RoundStateEnum.Prepare: RoundResultLabel.Text = "Prepare the buttons..."; break;
                case RoundStateEnum.Active: RoundResultLabel.Text = "Ready to push!"; break;
            }
        }
    }
}