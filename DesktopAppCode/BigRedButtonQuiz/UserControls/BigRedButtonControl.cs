using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace BigRedButtonQuiz.UserControls
{
    public partial class BigRedButtonControl : UserControl
    {
        public class ButtonPressEventArgs : EventArgs
        {
            public int ButtonIndex { get; }
            public string PlayerName { get; }

            public ButtonPressEventArgs(int buttonIndex, string playerName)
            {
                ButtonIndex = buttonIndex;
                PlayerName = playerName;
            }
        }

        public int ButtonIndex { get; }
        public string PlayerName => PlayerNameTextBox.Text.Trim();

        public event EventHandler<ButtonPressEventArgs> ButtonPress;
        public event EventHandler Connected; // TODO: Wire this up
        public event EventHandler Disconnected; // TODO: Wire this up

        private BigRedButtonControllerSerial _serial;

        public BigRedButtonControl(int index)
        {
            InitializeComponent();

            ButtonIndex = index;
            _serial = new BigRedButtonControllerSerial();
            RefreshPortList();
            StatusLabel.Text = "Not connected";
            IndexLabel.Text = $"#{index + 1}";
            PlayerNameTextBox.Text = $"Player #{index + 1}";
        }

        public void RefreshPortList()
        {
            SerialPortList.Items.Clear();
            SerialPortList.Items.Add("Select");
            SerialPortList.Items.AddRange(SerialPort.GetPortNames());
            SerialPortList.SelectedIndex = 0;
        }

        public void SetLED(bool on)
        {
            _serial.SetLight(on);
        }

        public bool IsActive => _serial.IsOpen;

        private void UpdateStateLabel(bool buttonDown)
        {
            StatusLabel.BackColor = buttonDown ? Color.FromArgb(255, 0, 0) : Color.FromArgb(128, 128, 128);
            StatusLabel.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void SerialPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SerialPortList.SelectedIndex < 1)
                return;

            var port = (string)SerialPortList.SelectedItem;

            try
            {
                _serial.Connect(port);
                _serial.StateChanged += ButtonStateChangedEvent;
                StatusLabel.Text = "Connected";
                TestButton.Enabled = true;
                UpdateStateLabel(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to port {port}: {ex.Message}");
            }
        }

        private void ButtonStateChangedEvent(object sender, ButtonStateChangedEventArgs e)
        {
            if (e.ButtonState == BigRedButtonState.ButtonUp)
            {
                UpdateStateLabel(false);
            }
            if (e.ButtonState == BigRedButtonState.ButtonDown)
            {
                UpdateStateLabel(true);
                ButtonPress?.Invoke(this, new ButtonPressEventArgs(ButtonIndex, PlayerName));
            }
        }

        private void TestButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (_serial.IsOpen)
            {
                _serial.SetLight(true);
            }
        }

        private void TestButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (_serial.IsOpen)
            {
                _serial.SetLight(false);
            }
        }
    }
}
