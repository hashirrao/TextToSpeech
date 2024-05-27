using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using System.IO.Pipes;

namespace TextToSpeech
{
    public partial class Main : Form
    {
        SpeechSynthesizer ss;
        bool play;
        bool start;
        private bool move;
        private int x, y;
        public Main()
        {
            InitializeComponent();
            start = play = true;
            move = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playPause_Click(object sender, EventArgs e)
        {
            if (start)
            {
                ss = new SpeechSynthesizer();
				ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                ss.Rate = speedTrackBar.Value;
                ss.Volume = volumeTrackBar.Value;
                ss.SpeakAsync(textBox.Text);
                start = false;
            }
            if (play)
            {
                ss.Resume();
                play = false;
                playPause.BackgroundImage = Properties.Resources.media_playback_pause_5;
            }
            else
            {
                ss.Pause();
                play = true;
                playPause.BackgroundImage = Properties.Resources.media_playback_start_5;
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            start = true;
            ss.Pause();
            play = true;
            playPause.BackgroundImage = Properties.Resources.media_playback_start_5;
        }

        private void playPause_MouseDown(object sender, MouseEventArgs e)
        {
            playPause.Size = new System.Drawing.Size(47, 47);
        }

        private void playPause_MouseUp(object sender, MouseEventArgs e)
        {
            playPause.Size = new System.Drawing.Size(50, 50);
        }

        private void stop_MouseDown(object sender, MouseEventArgs e)
        {
            stop.Size = new System.Drawing.Size(47, 47);
        }

        private void stop_MouseUp(object sender, MouseEventArgs e)
        {
            stop.Size = new System.Drawing.Size(50, 50);
        }

        private void record_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "wave files| *.wav";
            sfd.ShowDialog();
            String fname;
            fname = sfd.FileName;
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Rate = speedTrackBar.Value;
            ss.Volume = volumeTrackBar.Value;
            ss.SetOutputToWaveFile(fname);
            ss.Speak(textBox.Text);
            ss.SetOutputToDefaultAudioDevice();
            MessageBox.Show("Text record save as a wav file");
        }

        private void record_MouseDown(object sender, MouseEventArgs e)
        {
            record.Size = new System.Drawing.Size(47, 47);
        }

        private void record_MouseUp(object sender, MouseEventArgs e)
        {
            record.Size = new System.Drawing.Size(50, 50);
        }

		private void open_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "text files|*.txt";
			ofd.ShowDialog();
			String fname = ofd.FileName;
			StreamReader sr = new StreamReader(fname);
			textBox.Text = sr.ReadToEnd();
			sr.Close();
		}

		private void open_MouseDown(object sender, MouseEventArgs e)
		{
			open.Size = new System.Drawing.Size(47, 47);
		}

		private void open_MouseUp(object sender, MouseEventArgs e)
		{
			open.Size = new System.Drawing.Size(50, 50);
		}

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            move = true;
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.CloseEnter;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.CloseButton;
        }

        private void closeButton_MouseDown(object sender, MouseEventArgs e)
        {
            closeButton.Image = Properties.Resources.ClosePress;
        }

        private void closeButton_MouseUp(object sender, MouseEventArgs e)
        {
            closeButton.Image = Properties.Resources.CloseEnter;
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.Image = Properties.Resources.MinimizeEnter;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.Image = Properties.Resources.MinimizeButton;
        }

        private void minimizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            minimizeButton.Image = Properties.Resources.MinimizePress;
        }

        private void minimizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            minimizeButton.Image = Properties.Resources.MinimizeEnter;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }
    }
}
