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
            removeSongButton = new Button();
            homePageButton = new Button();
            addSongButton = new Button();
            ((System.ComponentModel.ISupportInitialize)playSelectedSong).BeginInit();
            SuspendLayout();
            // 
            // SearchPlaylistButton
            // 
            SearchPlaylistButton.BackColor = SystemColors.ActiveCaptionText;
            SearchPlaylistButton.ForeColor = SystemColors.ButtonFace;
            SearchPlaylistButton.ImageAlign = ContentAlignment.TopCenter;
            SearchPlaylistButton.Location = new Point(572, 294);
            SearchPlaylistButton.Name = "SearchPlaylistButton";
            SearchPlaylistButton.Size = new Size(145, 34);
            SearchPlaylistButton.TabIndex = 9;
            SearchPlaylistButton.Text = "Playlists";
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
            changeName.Location = new Point(112, 12);
            changeName.Name = "changeName";
            changeName.Size = new Size(140, 34);
            changeName.TabIndex = 16;
            changeName.Text = "Change Name";
            changeName.UseVisualStyleBackColor = false;
            changeName.Click += changeName_Click;
            // 
            // changeArtist
            // 
            changeArtist.BackColor = SystemColors.ActiveCaptionText;
            changeArtist.ForeColor = SystemColors.ButtonFace;
            changeArtist.Location = new Point(340, 12);
            changeArtist.Name = "changeArtist";
            changeArtist.Size = new Size(140, 34);
            changeArtist.TabIndex = 17;
            changeArtist.Text = "Change Artist";
            changeArtist.UseVisualStyleBackColor = false;
            changeArtist.Click += changeArtist_Click;
            // 
            // changeFilePath
            // 
            changeFilePath.BackColor = SystemColors.ActiveCaptionText;
            changeFilePath.ForeColor = SystemColors.ButtonFace;
            changeFilePath.Location = new Point(572, 12);
            changeFilePath.Name = "changeFilePath";
            changeFilePath.Size = new Size(145, 34);
            changeFilePath.TabIndex = 18;
            changeFilePath.Text = "Change File";
            changeFilePath.UseVisualStyleBackColor = false;
            changeFilePath.Click += changeFilePath_Click;
            // 
            // removeSongButton
            // 
            removeSongButton.BackColor = SystemColors.ActiveCaptionText;
            removeSongButton.ForeColor = SystemColors.ButtonFace;
            removeSongButton.ImageAlign = ContentAlignment.TopCenter;
            removeSongButton.Location = new Point(112, 371);
            removeSongButton.Name = "removeSongButton";
            removeSongButton.Size = new Size(140, 34);
            removeSongButton.TabIndex = 20;
            removeSongButton.Text = "Remove Song";
            removeSongButton.UseVisualStyleBackColor = false;
            removeSongButton.Click += removeSongButton_Click;
            // 
            // homePageButton
            // 
            homePageButton.BackColor = SystemColors.ActiveCaptionText;
            homePageButton.ForeColor = SystemColors.ButtonFace;
            homePageButton.ImageAlign = ContentAlignment.TopCenter;
            homePageButton.Location = new Point(572, 371);
            homePageButton.Name = "homePageButton";
            homePageButton.Size = new Size(145, 34);
            homePageButton.TabIndex = 21;
            homePageButton.Text = "Home";
            homePageButton.UseVisualStyleBackColor = false;
            homePageButton.Click += homePageButton_Click;
            // 
            // addSongButton
            // 
            addSongButton.BackColor = SystemColors.ActiveCaptionText;
            addSongButton.ForeColor = SystemColors.ButtonFace;
            addSongButton.ImageAlign = ContentAlignment.TopCenter;
            addSongButton.Location = new Point(112, 294);
            addSongButton.Name = "addSongButton";
            addSongButton.Size = new Size(140, 34);
            addSongButton.TabIndex = 19;
            addSongButton.Text = "Add Song";
            addSongButton.UseVisualStyleBackColor = false;
            addSongButton.Click += addSongButton_Click;
            // 
            // SearchSongs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(homePageButton);
            Controls.Add(removeSongButton);
            Controls.Add(addSongButton);
            Controls.Add(changeFilePath);
            Controls.Add(changeArtist);
            Controls.Add(changeName);
            Controls.Add(playSelectedSong);
            Controls.Add(returnedSongs);
            Controls.Add(searchParameters);
            Controls.Add(SearchPlaylistButton);
            Name = "SearchSongs";
            Text = "Search Songs";
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
        private Button removeSongButton;
        private Button homePageButton;
        private Button addSongButton;
    }
}