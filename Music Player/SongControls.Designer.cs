namespace Music_Player
{
    partial class SongControls
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongControls));
            imageList1 = new ImageList(components);
            songArt = new PictureBox();
            previousSongPicBox = new PictureBox();
            playSongPicBox = new PictureBox();
            nextSongPicBox = new PictureBox();
            songName = new Label();
            artistName = new Label();
            playlistName = new Label();
            checkBox1 = new CheckBox();
            placeInSong = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)songArt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)previousSongPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playSongPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextSongPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)placeInSong).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "play.png");
            imageList1.Images.SetKeyName(1, "pause.png");
            imageList1.Images.SetKeyName(2, "next.png");
            imageList1.Images.SetKeyName(3, "previous.png");
            // 
            // songArt
            // 
            songArt.BackColor = SystemColors.ActiveCaptionText;
            songArt.Location = new Point(288, 29);
            songArt.Name = "songArt";
            songArt.Size = new Size(230, 221);
            songArt.TabIndex = 9;
            songArt.TabStop = false;
            // 
            // previousSongPicBox
            // 
            previousSongPicBox.BackColor = SystemColors.ActiveCaptionText;
            previousSongPicBox.Image = (Image)resources.GetObject("previousSongPicBox.Image");
            previousSongPicBox.Location = new Point(288, 331);
            previousSongPicBox.Name = "previousSongPicBox";
            previousSongPicBox.Size = new Size(55, 55);
            previousSongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            previousSongPicBox.TabIndex = 10;
            previousSongPicBox.TabStop = false;
            previousSongPicBox.Click += previousSongPicBox_Click;
            // 
            // playSongPicBox
            // 
            playSongPicBox.BackColor = SystemColors.ActiveCaptionText;
            playSongPicBox.Image = (Image)resources.GetObject("playSongPicBox.Image");
            playSongPicBox.Location = new Point(372, 331);
            playSongPicBox.Name = "playSongPicBox";
            playSongPicBox.Size = new Size(64, 55);
            playSongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            playSongPicBox.TabIndex = 12;
            playSongPicBox.TabStop = false;
            playSongPicBox.Click += playSongPicBox_Click;
            // 
            // nextSongPicBox
            // 
            nextSongPicBox.BackColor = SystemColors.ActiveCaptionText;
            nextSongPicBox.Image = (Image)resources.GetObject("nextSongPicBox.Image");
            nextSongPicBox.Location = new Point(461, 331);
            nextSongPicBox.Name = "nextSongPicBox";
            nextSongPicBox.Size = new Size(55, 55);
            nextSongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            nextSongPicBox.TabIndex = 13;
            nextSongPicBox.TabStop = false;
            nextSongPicBox.Click += nextSongPicBox_Click;
            // 
            // songName
            // 
            songName.BackColor = SystemColors.ActiveCaptionText;
            songName.ForeColor = SystemColors.ButtonFace;
            songName.Location = new Point(25, 269);
            songName.Name = "songName";
            songName.Size = new Size(750, 25);
            songName.TabIndex = 14;
            songName.Text = "Song Name";
            songName.TextAlign = ContentAlignment.TopCenter;
            // 
            // artistName
            // 
            artistName.BackColor = SystemColors.ActiveCaptionText;
            artistName.ForeColor = SystemColors.ButtonFace;
            artistName.Location = new Point(25, 303);
            artistName.Name = "artistName";
            artistName.Size = new Size(750, 25);
            artistName.TabIndex = 15;
            artistName.Text = "Artist Name";
            artistName.TextAlign = ContentAlignment.TopCenter;
            // 
            // playlistName
            // 
            playlistName.BackColor = SystemColors.ActiveCaptionText;
            playlistName.ForeColor = SystemColors.ButtonFace;
            playlistName.Location = new Point(25, 1);
            playlistName.Name = "playlistName";
            playlistName.Size = new Size(750, 25);
            playlistName.TabIndex = 16;
            playlistName.Text = "Playlist Name";
            playlistName.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveCaptionText;
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(343, 409);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 29);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Loop Song";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // placeInSong
            // 
            placeInSong.AutoSize = false;
            placeInSong.BackColor = SystemColors.ActiveCaptionText;
            placeInSong.Cursor = Cursors.NoMoveHoriz;
            placeInSong.Location = new Point(25, 256);
            placeInSong.Name = "placeInSong";
            placeInSong.Size = new Size(750, 20);
            placeInSong.TabIndex = 18;
            placeInSong.TickFrequency = 0;
            placeInSong.TickStyle = TickStyle.None;
            placeInSong.Scroll += placeInSong_Scroll;
            // 
            // SongControls
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(placeInSong);
            Controls.Add(checkBox1);
            Controls.Add(playlistName);
            Controls.Add(artistName);
            Controls.Add(songName);
            Controls.Add(nextSongPicBox);
            Controls.Add(playSongPicBox);
            Controls.Add(previousSongPicBox);
            Controls.Add(songArt);
            Name = "SongControls";
            Text = "Playing Song";
            Load += SongControls_Load;
            ((System.ComponentModel.ISupportInitialize)songArt).EndInit();
            ((System.ComponentModel.ISupportInitialize)previousSongPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playSongPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextSongPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)placeInSong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox songArt;
        private PictureBox previousSongPicBox;
        private PictureBox playSongPicBox;
        private PictureBox nextSongPicBox;
        private Label songName;
        private Label artistName;
        private Label playlistName;
        private TrackBar placeInSong;
        private CheckBox checkBox1;
    }
}