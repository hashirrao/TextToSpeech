namespace TextToSpeech
{
    partial class Main
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.PictureBox();
            this.record = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.playPause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPause)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 42);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(361, 223);
            this.textBox.TabIndex = 6;
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(18, 288);
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(104, 45);
            this.speedTrackBar.TabIndex = 7;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Location = new System.Drawing.Point(155, 288);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(218, 45);
            this.volumeTrackBar.TabIndex = 8;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(50, 341);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 9;
            this.speedLabel.Text = "Speed";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(256, 341);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeLabel.TabIndex = 10;
            this.volumeLabel.Text = "Volume";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(450, 20);
            this.topPanel.TabIndex = 15;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::TextToSpeech.Properties.Resources.MinimizeButton;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.Location = new System.Drawing.Point(416, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(14, 14);
            this.minimizeButton.TabIndex = 17;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseDown);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Image = global::TextToSpeech.Properties.Resources.CloseButton;
            this.closeButton.Location = new System.Drawing.Point(434, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(14, 14);
            this.closeButton.TabIndex = 16;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseDown);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseUp);
            // 
            // open
            // 
            this.open.BackgroundImage = global::TextToSpeech.Properties.Resources.Dark_Town;
            this.open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.open.Location = new System.Drawing.Point(379, 210);
            this.open.Margin = new System.Windows.Forms.Padding(10);
            this.open.Name = "open";
            this.open.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.open.Size = new System.Drawing.Size(50, 50);
            this.open.TabIndex = 14;
            this.open.TabStop = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            this.open.MouseDown += new System.Windows.Forms.MouseEventHandler(this.open_MouseDown);
            this.open.MouseUp += new System.Windows.Forms.MouseEventHandler(this.open_MouseUp);
            // 
            // record
            // 
            this.record.BackgroundImage = global::TextToSpeech.Properties.Resources.media_record;
            this.record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.record.Location = new System.Drawing.Point(379, 154);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(50, 50);
            this.record.TabIndex = 13;
            this.record.TabStop = false;
            this.record.Click += new System.EventHandler(this.record_Click);
            this.record.MouseDown += new System.Windows.Forms.MouseEventHandler(this.record_MouseDown);
            this.record.MouseUp += new System.Windows.Forms.MouseEventHandler(this.record_MouseUp);
            // 
            // stop
            // 
            this.stop.BackgroundImage = global::TextToSpeech.Properties.Resources.media_playback_stop_5;
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop.Location = new System.Drawing.Point(379, 98);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(50, 50);
            this.stop.TabIndex = 12;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            this.stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stop_MouseDown);
            this.stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stop_MouseUp);
            // 
            // playPause
            // 
            this.playPause.BackgroundImage = global::TextToSpeech.Properties.Resources.media_playback_start_5;
            this.playPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playPause.Location = new System.Drawing.Point(379, 42);
            this.playPause.Name = "playPause";
            this.playPause.Size = new System.Drawing.Size(50, 50);
            this.playPause.TabIndex = 11;
            this.playPause.TabStop = false;
            this.playPause.Click += new System.EventHandler(this.playPause_Click);
            this.playPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playPause_MouseDown);
            this.playPause.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playPause_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(450, 363);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.open);
            this.Controls.Add(this.record);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.playPause);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text to speech";
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox playPause;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox record;
		private System.Windows.Forms.PictureBox open;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox closeButton;
    }
}

