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

        private readonly BigRedButtonSerialPort _serial;

        public BigRedButtonControl(int index)
        {
            InitializeComponent();

            ButtonIndex = index;
            _serial = new BigRedButtonSerialPort();
            RefreshPortList();
            IndexLabel.Text = $"#{index + 1}";
            PlayerNameTextBox.Text = $"Player #{index + 1}";
            StatusLabel.Text = "Not connected";
        }

        public void RefreshPortList()
        {
            SerialPortList.Items.Clear();
            SerialPortList.Items.Add("Select");
            SerialPortList.Items.AddRange(SerialPort.GetPortNames());
            SerialPortList.SelectedIndex = Math.Max(0, SerialPortList.Items.IndexOf(_serial.PortName ?? ""));
        }

        public void SetLight(bool on)
        {
            if (!_serial.IsOpen)
            {
                ResetControl();
                return;
            }
            _serial.SetLight(on);
        }

        public bool IsActive => _serial.IsOpen;

        private void UpdateStateLabel(bool buttonDown)
        {
            StatusLabel.ForeColor = Color.FromArgb(255, 255, 255);
            StatusLabel.BackColor = buttonDown ? Color.FromArgb(255, 0, 0) : Color.FromArgb(128, 128, 128);
        }

        private void ResetControl()
        {
            _serial.StateChanged -= ButtonStateChangedEvent;
            StatusLabel.ForeColor = SystemColors.ControlText;
            StatusLabel.BackColor = SystemColors.Control;
            StatusLabel.Text = "Not connected";
            TestButton.Enabled = false;
            SerialPortList.SelectedIndex = 0;
        }

        private void SerialPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SerialPortList.SelectedIndex < 1)
                return;

            var port = (string)SerialPortList.SelectedItem;
            if (port == _serial.PortName)
                return;

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
                ResetControl();
                MessageBox.Show($"Failed to connect to port {port}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            SetLight(true);
        }

        private void TestButton_MouseUp(object sender, MouseEventArgs e)
        {
            SetLight(false);
        }
    }
}