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
            ((System.ComponentModel.ISupportInitialize)songArt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)previousSongPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playSongPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextSongPicBox).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "play.png");
            imageList1.Images.SetKeyName(1, "pause.png");
            // 
            // songArt
            // 
            songArt.Location = new Point(288, 29);
            songArt.Name = "songArt";
            songArt.Size = new Size(230, 221);
            songArt.TabIndex = 9;
            songArt.TabStop = false;
            // 
            // previousSongPicBox
            // 
            previousSongPicBox.Image = (Image)resources.GetObject("previousSongPicBox.Image");
            previousSongPicBox.Location = new Point(288, 331);
            previousSongPicBox.Name = "previousSongPicBox";
            previousSongPicBox.Size = new Size(64, 55);
            previousSongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            previousSongPicBox.TabIndex = 10;
            previousSongPicBox.TabStop = false;
            previousSongPicBox.Click += previousSongPicBox_Click;
            // 
            // playSongPicBox
            // 
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
            nextSongPicBox.Image = (Image)resources.GetObject("nextSongPicBox.Image");
            nextSongPicBox.Location = new Point(454, 331);
            nextSongPicBox.Name = "nextSongPicBox";
            nextSongPicBox.Size = new Size(64, 55);
            nextSongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            nextSongPicBox.TabIndex = 13;
            nextSongPicBox.TabStop = false;
            nextSongPicBox.Click += nextSongPicBox_Click;
            // 
            // songName
            // 
            songName.AutoSize = true;
            songName.Location = new Point(288, 264);
            songName.Name = "songName";
            songName.Size = new Size(99, 25);
            songName.TabIndex = 14;
            songName.Text = "songName";
            // 
            // artistName
            // 
            artistName.AutoSize = true;
            artistName.Location = new Point(288, 289);
            artistName.Name = "artistName";
            artistName.Size = new Size(98, 25);
            artistName.TabIndex = 15;
            artistName.Text = "artistName";
            // 
            // playlistName
            // 
            playlistName.AutoSize = true;
            playlistName.Location = new Point(344, 1);
            playlistName.Name = "playlistName";
            playlistName.Size = new Size(114, 25);
            playlistName.TabIndex = 16;
            playlistName.Text = "playlistName";
            // 
            // SongControls
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playlistName);
            Controls.Add(artistName);
            Controls.Add(songName);
            Controls.Add(nextSongPicBox);
            Controls.Add(playSongPicBox);
            Controls.Add(previousSongPicBox);
            Controls.Add(songArt);
            Name = "SongControls";
            Text = "SongControls";
            Load += SongControls_Load;
            ((System.ComponentModel.ISupportInitialize)songArt).EndInit();
            ((System.ComponentModel.ISupportInitialize)previousSongPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playSongPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextSongPicBox).EndInit();
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
    }
}