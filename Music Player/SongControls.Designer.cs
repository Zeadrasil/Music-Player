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
            ControllerFindSongButton = new Button();
            ControllerHomeButton = new Button();
            ControllerAddSongButton = new Button();
            ControllerPlaylistButton = new Button();
            pictureBox1 = new PictureBox();
            previousSongPicBox = new PictureBox();
            pauseSongPicBox = new PictureBox();
            playSongPicBox = new PictureBox();
            nextSongPicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)previousSongPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pauseSongPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playSongPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextSongPicBox).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // ControllerFindSongButton
            // 
            ControllerFindSongButton.Location = new Point(524, 404);
            ControllerFindSongButton.Name = "ControllerFindSongButton";
            ControllerFindSongButton.Size = new Size(112, 34);
            ControllerFindSongButton.TabIndex = 8;
            ControllerFindSongButton.Text = "search";
            ControllerFindSongButton.UseVisualStyleBackColor = true;
            ControllerFindSongButton.Click += ControllerFindSongButton_Click;
            // 
            // ControllerHomeButton
            // 
            ControllerHomeButton.Location = new Point(164, 404);
            ControllerHomeButton.Name = "ControllerHomeButton";
            ControllerHomeButton.Size = new Size(118, 34);
            ControllerHomeButton.TabIndex = 7;
            ControllerHomeButton.Text = "home";
            ControllerHomeButton.UseVisualStyleBackColor = true;
            ControllerHomeButton.Click += ControllerHomeButton_Click;
            // 
            // ControllerAddSongButton
            // 
            ControllerAddSongButton.Location = new Point(406, 404);
            ControllerAddSongButton.Name = "ControllerAddSongButton";
            ControllerAddSongButton.Size = new Size(112, 34);
            ControllerAddSongButton.TabIndex = 6;
            ControllerAddSongButton.Text = "addsong";
            ControllerAddSongButton.UseVisualStyleBackColor = true;
            ControllerAddSongButton.Click += ControllerAddSongButton_Click;
            // 
            // ControllerPlaylistButton
            // 
            ControllerPlaylistButton.Location = new Point(288, 404);
            ControllerPlaylistButton.Name = "ControllerPlaylistButton";
            ControllerPlaylistButton.Size = new Size(112, 34);
            ControllerPlaylistButton.TabIndex = 5;
            ControllerPlaylistButton.Text = "playlists";
            ControllerPlaylistButton.UseVisualStyleBackColor = true;
            ControllerPlaylistButton.Click += ControllerPlaylistButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(288, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 221);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // previousSongPicBox
            // 
            previousSongPicBox.Image = (Image)resources.GetObject("previousSongPicBox.Image");
            previousSongPicBox.Location = new Point(218, 269);
            previousSongPicBox.Name = "previousSongPicBox";
            previousSongPicBox.Size = new Size(64, 55);
            previousSongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            previousSongPicBox.TabIndex = 10;
            previousSongPicBox.TabStop = false;
            previousSongPicBox.Click += previousSongPicBox_Click;
            // 
            // pauseSongPicBox
            // 
            pauseSongPicBox.Image = (Image)resources.GetObject("pauseSongPicBox.Image");
            pauseSongPicBox.Location = new Point(336, 269);
            pauseSongPicBox.Name = "pauseSongPicBox";
            pauseSongPicBox.Size = new Size(64, 55);
            pauseSongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pauseSongPicBox.TabIndex = 11;
            pauseSongPicBox.TabStop = false;
            pauseSongPicBox.Click += pauseSongPicBox_Click;
            // 
            // playSongPicBox
            // 
            playSongPicBox.Image = (Image)resources.GetObject("playSongPicBox.Image");
            playSongPicBox.Location = new Point(406, 269);
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
            nextSongPicBox.Location = new Point(524, 269);
            nextSongPicBox.Name = "nextSongPicBox";
            nextSongPicBox.Size = new Size(64, 55);
            nextSongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            nextSongPicBox.TabIndex = 13;
            nextSongPicBox.TabStop = false;
            nextSongPicBox.Click += nextSongPicBox_Click;
            // 
            // SongControls
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextSongPicBox);
            Controls.Add(playSongPicBox);
            Controls.Add(pauseSongPicBox);
            Controls.Add(previousSongPicBox);
            Controls.Add(pictureBox1);
            Controls.Add(ControllerFindSongButton);
            Controls.Add(ControllerHomeButton);
            Controls.Add(ControllerAddSongButton);
            Controls.Add(ControllerPlaylistButton);
            Name = "SongControls";
            Text = "SongControls";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)previousSongPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pauseSongPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playSongPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextSongPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Button ControllerFindSongButton;
        private Button ControllerHomeButton;
        private Button ControllerAddSongButton;
        private Button ControllerPlaylistButton;
        private PictureBox pictureBox1;
        private PictureBox previousSongPicBox;
        private PictureBox pauseSongPicBox;
        private PictureBox playSongPicBox;
        private PictureBox nextSongPicBox;
    }
}