namespace Music_Player
{
    partial class SearchSongs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSongs));
            SearchPlaylistButton = new Button();
            searchParameters = new TextBox();
            returnedSongs = new ListBox();
            playSelectedSong = new PictureBox();
            imageList1 = new ImageList(components);
            changeName = new Button();
            changeArtist = new Button();
            changeFilePath = new Button();
            ((System.ComponentModel.ISupportInitialize)playSelectedSong).BeginInit();
            SuspendLayout();
            // 
            // SearchPlaylistButton
            // 
            SearchPlaylistButton.BackColor = SystemColors.ActiveCaptionText;
            SearchPlaylistButton.ForeColor = SystemColors.ButtonFace;
            SearchPlaylistButton.ImageAlign = ContentAlignment.TopCenter;
            SearchPlaylistButton.Location = new Point(346, 357);
            SearchPlaylistButton.Name = "SearchPlaylistButton";
            SearchPlaylistButton.Size = new Size(129, 34);
            SearchPlaylistButton.TabIndex = 9;
            SearchPlaylistButton.Text = "playlists";
            SearchPlaylistButton.UseVisualStyleBackColor = false;
            SearchPlaylistButton.Click += SearchPlaylistButton_Click;
            // 
            // searchParameters
            // 
            searchParameters.BackColor = SystemColors.ActiveCaptionText;
            searchParameters.ForeColor = SystemColors.ButtonFace;
            searchParameters.Location = new Point(107, 60);
            searchParameters.Name = "searchParameters";
            searchParameters.Size = new Size(610, 31);
            searchParameters.TabIndex = 13;
            searchParameters.TextChanged += searchParameters_TextChanged;
            // 
            // returnedSongs
            // 
            returnedSongs.BackColor = SystemColors.ActiveCaptionText;
            returnedSongs.ForeColor = SystemColors.ButtonFace;
            returnedSongs.FormattingEnabled = true;
            returnedSongs.ItemHeight = 25;
            returnedSongs.Location = new Point(107, 110);
            returnedSongs.Name = "returnedSongs";
            returnedSongs.Size = new Size(610, 154);
            returnedSongs.TabIndex = 14;
            // 
            // playSelectedSong
            // 
            playSelectedSong.BackColor = SystemColors.ActiveCaptionText;
            playSelectedSong.Image = (Image)resources.GetObject("playSelectedSong.Image");
            playSelectedSong.Location = new Point(379, 270);
            playSelectedSong.Name = "playSelectedSong";
            playSelectedSong.Size = new Size(61, 58);
            playSelectedSong.SizeMode = PictureBoxSizeMode.StretchImage;
            playSelectedSong.TabIndex = 15;
            playSelectedSong.TabStop = false;
            playSelectedSong.Click += playSelectedSong_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "play.png");
            // 
            // changeName
            // 
            changeName.BackColor = SystemColors.ActiveCaptionText;
            changeName.ForeColor = SystemColors.ButtonFace;
            changeName.Location = new Point(107, 12);
            changeName.Name = "changeName";
            changeName.Size = new Size(129, 34);
            changeName.TabIndex = 16;
            changeName.Text = "changeName";
            changeName.UseVisualStyleBackColor = false;
            changeName.Click += changeName_Click;
            // 
            // changeArtist
            // 
            changeArtist.BackColor = SystemColors.ActiveCaptionText;
            changeArtist.ForeColor = SystemColors.ButtonFace;
            changeArtist.Location = new Point(346, 12);
            changeArtist.Name = "changeArtist";
            changeArtist.Size = new Size(129, 34);
            changeArtist.TabIndex = 17;
            changeArtist.Text = "changeArtist";
            changeArtist.UseVisualStyleBackColor = false;
            changeArtist.Click += changeArtist_Click;
            // 
            // changeFilePath
            // 
            changeFilePath.BackColor = SystemColors.ActiveCaptionText;
            changeFilePath.ForeColor = SystemColors.ButtonFace;
            changeFilePath.Location = new Point(588, 12);
            changeFilePath.Name = "changeFilePath";
            changeFilePath.Size = new Size(129, 34);
            changeFilePath.TabIndex = 18;
            changeFilePath.Text = "changeFile";
            changeFilePath.UseVisualStyleBackColor = false;
            changeFilePath.Click += changeFilePath_Click;
            // 
            // SearchSongs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(changeFilePath);
            Controls.Add(changeArtist);
            Controls.Add(changeName);
            Controls.Add(playSelectedSong);
            Controls.Add(returnedSongs);
            Controls.Add(searchParameters);
            Controls.Add(SearchPlaylistButton);
            Name = "SearchSongs";
            Text = "lkm";
            ((System.ComponentModel.ISupportInitialize)playSelectedSong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SearchPlaylistButton;
        private TextBox searchParameters;
        private ListBox returnedSongs;
        private PictureBox playSelectedSong;
        private ImageList imageList1;
        private Button changeName;
        private Button changeArtist;
        private Button changeFilePath;
    }
}