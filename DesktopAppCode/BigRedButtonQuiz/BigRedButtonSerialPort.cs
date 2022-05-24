using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigRedButtonQuiz
{
    public enum BigRedButtonState
    {
        NoChange = 0,
        ButtonUp = 1,
        ButtonDown = 2
    }

    public class ButtonStateChangedEventArgs : EventArgs
    {
        public BigRedButtonState ButtonState { get; }

        public ButtonStateChangedEventArgs(BigRedButtonState buttonState)
        {
            ButtonState = buttonState;
        }
    }

    public class BigRedButtonSerialPort
    {
        private readonly SerialPort _port;

        public event EventHandler<ButtonStateChangedEventArgs> StateChanged;

        public BigRedButtonSerialPort()
        {
            _port = new SerialPort
            {
                PortName = "COM1",
                BaudRate = 38400,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One,
                NewLine = "\n",
                DtrEnable = true // <-- This is important for Arduino Leonardo chips!
            };
        }

        public bool IsOpen => _port.IsOpen;
        public string PortName => _port.IsOpen ? _port.PortName : null;

        public void Connect(string portName)
        {
            _port.DataReceived -= DataReceived;

            if (!SerialPort.GetPortNames().Contains(portName))
            {
                throw new ArgumentException("Port is not available");
            }

            if (_port.IsOpen)
            {
                _port.Close();
            }

            _port.PortName = portName;
            _port.Open();
            

            WriteLine("**BRBQ*I");

            var binaryData = ReadLine(timeout: 2);
            var data = Encoding.ASCII.GetString(binaryData);
            if (data != "ACK")
            {
                throw new Exception($"Invalid response from device: {data}");
            }

            _port.DataReceived += DataReceived;
            // TODO: Detect when device is unconnected
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var binaryData = ReadLine(timeout: 2, giveUpOnStart: true);
            if (binaryData == null)
            {
                return;
            }

            var data = Encoding.ASCII.GetString(binaryData);
            switch (data)
            {
                case "EBU": InvokeStateChangedEvent(BigRedButtonState.ButtonUp); break;
                case "EBD": InvokeStateChangedEvent(BigRedButtonState.ButtonDown); break;
                default: throw new Exception($"Invalid response: {data}");
            }
        }

        private void InvokeStateChangedEvent(BigRedButtonState state)
        {
            if (StateChanged != null)
            {
                var eventArgs = new ButtonStateChangedEventArgs(state);
                var targetControl = StateChanged.Target as Control;
                if (targetControl?.InvokeRequired ?? false)
                {
                    targetControl.Invoke(StateChanged, new object[] { this, eventArgs });
                }
                else
                {
                    StateChanged.Invoke(this, eventArgs);
                }
            }
        }

        public BigRedButtonState AskCurrentState()
        {
            var binaryData = WriteLineAndRead("**BRBQ*S", timeout: 2);
            var data = Encoding.ASCII.GetString(binaryData);
            if (data == "SBU") return BigRedButtonState.ButtonUp;
            if (data == "SBD") return BigRedButtonState.ButtonDown;
            throw new Exception("Invalid response: " + data);
        }

        public void SetLight(bool lightState)
        {
            var binaryData = WriteLineAndRead($"**BRBQ*{(lightState ? 'H' : 'L')}", timeout: 2);
            var data = Encoding.ASCII.GetString(binaryData);
            if (data != "ACK")
            {
                throw new Exception($"Invalid response from device: {data}");
            }
        }

        private byte[] WriteLineAndRead(string text, int timeout, bool giveUpOnStart = false)
        {
            if (!_port.IsOpen) throw new Exception("Port is closed.");
            _port.DataReceived -= DataReceived;
            while (_port.BytesToRead > 0) _port.ReadByte(); // Clear input buffer
            _port.WriteLine(text);
            var binaryData = ReadLine(timeout, giveUpOnStart);
            _port.DataReceived += DataReceived;
            return binaryData;
        }

        private void WriteLine(string text)
        {
            if (!_port.IsOpen) throw new Exception("Port is closed.");
            while (_port.BytesToRead > 0) _port.ReadByte(); // Clear input buffer
            _port.WriteLine(text);
        }

        private byte[] ReadLine(int timeout, bool giveUpOnStart = false)
        {
            if (!_port.IsOpen) throw new Exception("Port is closed.");

            // Listen in
            if (giveUpOnStart && _port.BytesToRead == 0)
            {
                // Nothing to read
                return null;
            }

            // Read up until next '\n'
            var receivedData = new List<byte>();
            long tick = DateTime.Now.Ticks;
            long tickEnd = tick + timeout * 10000000; // seconds

            while (tick < tickEnd)
            {
                if (_port.BytesToRead > 0)
                {
                    var data = (byte)_port.ReadByte();
                    if (data == '\n')
                    {
                        // Done
                        return receivedData.ToArray();
                    }
                    else
                    {
                        receivedData.Add(data);
                    }
                }

                tick = DateTime.Now.Ticks;
            }

            // Timed out
            throw new Exception($"Timed out on {_port.PortName}!");
        }
    }
}