using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BigRedButtonQuiz.Forms
{
    public partial class GameForm : Form
    {
        private readonly IReadOnlyList<UserControls.BigRedButtonControl> _buttons;
        
        private readonly WaveOutEvent _soundDevice;
        private readonly AudioFileReader _sndMainTheme = new AudioFileReader(@".\\audio\\main_theme.mp3");
        private readonly AudioFileReader[] _sndWinMedium = new AudioFileReader[2]
        {
            new AudioFileReader(@".\\audio\\win_medium_1.mp3"),
            new AudioFileReader(@".\\audio\\win_medium_2.mp3")
        };
        private readonly AudioFileReader[] _sndWinBig = new AudioFileReader[2]
        {
            new AudioFileReader(@".\\audio\\win_big_1.mp3"),
            new AudioFileReader(@".\\audio\\win_big_2.mp3")
        };
        private readonly AudioFileReader _sndLoseSmall = new AudioFileReader(@".\\audio\\lose_small.mp3");
        private readonly AudioFileReader _sndLoseBig = new AudioFileReader(@".\\audio\\lose_big.mp3");
        private readonly AudioFileReader _sndMark = new AudioFileReader(@".\\audio\\mark.mp3");
        private readonly AudioFileReader[] _sndNext = new AudioFileReader[2]
        {
            new AudioFileReader(@".\\audio\\next_1.mp3"),
            new AudioFileReader(@".\\audio\\next_2.mp3")
        };
        private readonly AudioFileReader _sndBackFast = new AudioFileReader(@".\\audio\\back_fast.mp3");
        private readonly AudioFileReader[] _sndBackSlow = new AudioFileReader[2]
        {
            new AudioFileReader(@".\\audio\\back_slow_1.mp3"),
            new AudioFileReader(@".\\audio\\back_slow_2.mp3")
        };
        private int _slowBackIndex = 0;
        private int _lastPlayerIndex = 0;

        private readonly Random _random = new Random();

        enum RoundStateEnum
        {
            Prepare,
            Active,
            ButtonPressed,
            Result
        }
        private RoundStateEnum _roundState = RoundStateEnum.Prepare;

        public GameForm(IReadOnlyList<UserControls.BigRedButtonControl> buttons)
        {
            InitializeComponent();

            const int padding = 30;
            ClientSize = new Size(
                MainPanel.ClientSize.Width + padding * 2,
                MainPanel.ClientSize.Height + padding * 2
            );
            MinimumSize = Size;
            MainPanel.Location = new Point(padding, padding);

            _soundDevice = new WaveOutEvent();
            _buttons = buttons;
            foreach (var button in buttons)
            {
                if (button.IsActive)
                {
                    button.ButtonPress += ButtonPressEvent;
                    button.ButtonDisconnected += ButtonDisconnectedEvent;
                }
            }
        }

        private void ButtonDisconnectedEvent(object sender, UserControls.BigRedButtonControl.ButtonEventArgs e)
        {
            MessageBox.Show($"The button for {e.PlayerName} has been disconnected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var button in _buttons)
            {
                button.ButtonPress -= ButtonPressEvent;
                button.ButtonDisconnected -= ButtonDisconnectedEvent;
            }

            _soundDevice.PlaybackStopped -= _outputDevice_PlaybackStopped;
            _soundDevice.Stop();
            _soundDevice.Dispose();

            _sndMainTheme.Dispose();
            _sndWinMedium[0].Dispose();
            _sndWinMedium[1].Dispose();
            _sndWinBig[0].Dispose();
            _sndWinBig[1].Dispose();
            _sndLoseSmall.Dispose();
            _sndLoseBig.Dispose();
            _sndMark.Dispose();
            _sndNext[0].Dispose();
            _sndNext[1].Dispose();
            _sndBackFast.Dispose();
            _sndBackSlow[0].Dispose();
            _sndBackSlow[1].Dispose();
        }

        private void ButtonPressEvent(object sender, UserControls.BigRedButtonControl.ButtonEventArgs e)
        {
            if (_roundState == RoundStateEnum.Active)
            {
                _soundDevice.PlaybackStopped -= _outputDevice_PlaybackStopped;
                PlayAudio(_sndMark);

                UpdateRoundState(RoundStateEnum.ButtonPressed);
                _buttons[e.ButtonIndex].SetLight(true);
                RoundResultLabel.Text = $"{e.PlayerName}\nhas\npressed the button!";
                _lastPlayerIndex = e.ButtonIndex;
            }
        }

        private void NewRoundButton_Click(object sender, EventArgs e)
        {
            int activeButtons = 0;
            foreach (var button in _buttons)
            {
                button.SetLight(false);
                if (button.IsActive) activeButtons++;
            }
            if (activeButtons > 0)
            {
                if (_roundState == RoundStateEnum.ButtonPressed) // Undo button press
                {
                    UpdateRoundState(RoundStateEnum.Active);
                    PlayAudio((
                        FastBackgroundCheckBox.Checked
                            ? _sndBackFast
                            : _sndBackSlow[_slowBackIndex]
                        ),
                        true
                    );
                }
                else
                {
                    UpdateRoundState(RoundStateEnum.Active);
                    _slowBackIndex = _random.Next(2);
                    PlayAudio(_sndNext[_random.Next(2)], true);
                }
            }
            else
            {
                MessageBox.Show("There are no buttons connected!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _outputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (_roundState == RoundStateEnum.Active) // Start or loop background music
            {
                PlayAudio(FastBackgroundCheckBox.Checked
                    ? _sndBackFast
                    : _sndBackSlow[_slowBackIndex]
                );
            }
        }

        private void UpdateRoundState(RoundStateEnum state)
        {
            _roundState = state;
            switch (state)
            {
                case RoundStateEnum.Prepare:
                    RoundResultLabel.Text = "Prepare the buttons...";
                    break;

                case RoundStateEnum.Active:
                    RoundResultLabel.Text = "Ready your buttons!";
                    break;
            }

            NewRoundButton.Enabled = state != RoundStateEnum.Active;
            CorrectButton.Enabled = state == RoundStateEnum.ButtonPressed;
            WrongButton.Enabled = state == RoundStateEnum.ButtonPressed;

            if (state != RoundStateEnum.Result)
            {
                RoundResultLabel.BackColor = SystemColors.Window;
            }
        }

        private void PlayAudio(AudioFileReader audio, bool bindStopEvent = false)
        {
            _soundDevice.Stop();
            audio.Position = 0;
            _soundDevice.Init(audio);
            if (bindStopEvent) _soundDevice.PlaybackStopped += _outputDevice_PlaybackStopped;
            _soundDevice.Play();
        }

        private void MainThemeButton_Click(object sender, EventArgs e)
        {
            PlayAudio(_sndMainTheme);
        }

        private void StopAudioButton_Click(object sender, EventArgs e)
        {
            _soundDevice.Stop();
        }

        private void CorrectButton_Click(object sender, EventArgs e)
        {
            PlayAudio(HighStakeCheckBox.Checked
                ? _sndWinBig[_random.Next(2)]
                : _sndWinMedium[_random.Next(2)]
            );
            RoundResultLabel.Text = $"{_buttons[_lastPlayerIndex].PlayerName}\nis\nCORRECT!";
            RoundResultLabel.BackColor = Color.FromArgb(192, 255, 192);
            UpdateRoundState(RoundStateEnum.Result);
        }

        private void WrongButton_Click(object sender, EventArgs e)
        {
            PlayAudio(HighStakeCheckBox.Checked
                ? _sndLoseBig
                : _sndLoseSmall
            );
            RoundResultLabel.Text = $"{_buttons[_lastPlayerIndex].PlayerName}\nis\nWRONG!";
            RoundResultLabel.BackColor = Color.FromArgb(255, 192, 192);
            UpdateRoundState(RoundStateEnum.Result);
        }
    }
}
