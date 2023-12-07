namespace Music_Player
{
    partial class PlaylistPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistPage));
            PlaylistFindSongButton = new Button();
            imageList1 = new ImageList(components);
            removeSongButton = new Button();
            addSongButton = new Button();
            playlistPicker = new ComboBox();
            songsNotInPlaylist = new ListBox();
            songsInPlaylist = new ListBox();
            songSearchResult = new TextBox();
            playPlaylist = new PictureBox();
            createPlaylist = new Button();
            removePlaylist = new Button();
            shuffle = new CheckBox();
            changePlaylistName = new Button();
            ((System.ComponentModel.ISupportInitialize)playPlaylist).BeginInit();
            SuspendLayout();
            // 
            // PlaylistFindSongButton
            // 
            PlaylistFindSongButton.BackColor = SystemColors.ActiveCaptionText;
            PlaylistFindSongButton.ForeColor = SystemColors.ButtonFace;
            PlaylistFindSongButton.Location = new Point(676, 404);
            PlaylistFindSongButton.Name = "PlaylistFindSongButton";
            PlaylistFindSongButton.Size = new Size(112, 34);
            PlaylistFindSongButton.TabIndex = 8;
            PlaylistFindSongButton.Text = "songs";
            PlaylistFindSongButton.UseVisualStyleBackColor = false;
            PlaylistFindSongButton.Click += PlaylistFindSongButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // removeSongButton
            // 
            removeSongButton.BackColor = SystemColors.ActiveCaptionText;
            removeSongButton.ForeColor = SystemColors.ButtonFace;
            removeSongButton.Location = new Point(12, 211);
            removeSongButton.Name = "removeSongButton";
            removeSongButton.Size = new Size(112, 34);
            removeSongButton.TabIndex = 12;
            removeSongButton.Text = "remove song";
            removeSongButton.UseVisualStyleBackColor = false;
            removeSongButton.Click += removeSongButton_Click;
            // 
            // addSongButton
            // 
            addSongButton.BackColor = SystemColors.ActiveCaptionText;
            addSongButton.ForeColor = SystemColors.ButtonFace;
            addSongButton.Location = new Point(165, 211);
            addSongButton.Name = "addSongButton";
            addSongButton.Size = new Size(112, 34);
            addSongButton.TabIndex = 9;
            addSongButton.Text = "addSong";
            addSongButton.UseVisualStyleBackColor = false;
            addSongButton.Click += addSongButton_Click;
            // 
            // playlistPicker
            // 
            playlistPicker.BackColor = SystemColors.ActiveCaptionText;
            playlistPicker.ForeColor = SystemColors.ButtonFace;
            playlistPicker.FormattingEnabled = true;
            playlistPicker.Location = new Point(12, 12);
            playlistPicker.Name = "playlistPicker";
            playlistPicker.Size = new Size(205, 33);
            playlistPicker.TabIndex = 13;
            playlistPicker.SelectedIndexChanged += playlistPicker_SelectedIndexChanged;
            // 
            // songsNotInPlaylist
            // 
            songsNotInPlaylist.BackColor = SystemColors.ActiveCaptionText;
            songsNotInPlaylist.ForeColor = SystemColors.ButtonFace;
            songsNotInPlaylist.FormattingEnabled = true;
            songsNotInPlaylist.ItemHeight = 25;
            songsNotInPlaylist.Location = new Point(523, 49);
            songsNotInPlaylist.Name = "songsNotInPlaylist";
            songsNotInPlaylist.Size = new Size(265, 129);
            songsNotInPlaylist.TabIndex = 14;
            // 
            // songsInPlaylist
            // 
            songsInPlaylist.BackColor = SystemColors.ActiveCaptionText;
            songsInPlaylist.ForeColor = SystemColors.ButtonFace;
            songsInPlaylist.FormattingEnabled = true;
            songsInPlaylist.ItemHeight = 25;
            songsInPlaylist.Location = new Point(12, 51);
            songsInPlaylist.Name = "songsInPlaylist";
            songsInPlaylist.Size = new Size(265, 129);
            songsInPlaylist.TabIndex = 15;
            // 
            // songSearchResult
            // 
            songSearchResult.BackColor = SystemColors.ActiveCaptionText;
            songSearchResult.ForeColor = SystemColors.ButtonFace;
            songSearchResult.Location = new Point(620, 12);
            songSearchResult.Name = "songSearchResult";
            songSearchResult.Size = new Size(168, 31);
            songSearchResult.TabIndex = 16;
            songSearchResult.TextChanged += songSearchResult_TextChanged;
            // 
            // playPlaylist
            // 
            playPlaylist.BackColor = SystemColors.ActiveCaptionText;
            playPlaylist.Image = (Image)resources.GetObject("playPlaylist.Image");
            playPlaylist.Location = new Point(115, 269);
            playPlaylist.Name = "playPlaylist";
            playPlaylist.Size = new Size(61, 58);
            playPlaylist.SizeMode = PictureBoxSizeMode.StretchImage;
            playPlaylist.TabIndex = 17;
            playPlaylist.TabStop = false;
            playPlaylist.Click += playPlaylist_Click;
            // 
            // createPlaylist
            // 
            createPlaylist.BackColor = SystemColors.ActiveCaptionText;
            createPlaylist.ForeColor = SystemColors.ButtonFace;
            createPlaylist.Location = new Point(283, 51);
            createPlaylist.Name = "createPlaylist";
            createPlaylist.Size = new Size(112, 72);
            createPlaylist.TabIndex = 19;
            createPlaylist.Text = "create playlist";
            createPlaylist.UseVisualStyleBackColor = false;
            createPlaylist.Click += createPlaylist_Click;
            // 
            // removePlaylist
            // 
            removePlaylist.BackColor = SystemColors.ActiveCaptionText;
            removePlaylist.ForeColor = SystemColors.ButtonFace;
            removePlaylist.Location = new Point(401, 51);
            removePlaylist.Name = "removePlaylist";
            removePlaylist.Size = new Size(116, 72);
            removePlaylist.TabIndex = 20;
            removePlaylist.Text = "remove playlist";
            removePlaylist.UseVisualStyleBackColor = false;
            removePlaylist.Click += removePlaylist_Click;
            // 
            // shuffle
            // 
            shuffle.AutoSize = true;
            shuffle.BackColor = SystemColors.ActiveCaptionText;
            shuffle.ForeColor = SystemColors.ButtonFace;
            shuffle.Location = new Point(352, 129);
            shuffle.Name = "shuffle";
            shuffle.Size = new Size(91, 29);
            shuffle.TabIndex = 22;
            shuffle.Text = "shuffle";
            shuffle.UseVisualStyleBackColor = false;
            // 
            // changePlaylistName
            // 
            changePlaylistName.BackColor = SystemColors.ActiveCaptionText;
            changePlaylistName.ForeColor = SystemColors.ButtonFace;
            changePlaylistName.Location = new Point(283, 9);
            changePlaylistName.Name = "changePlaylistName";
            changePlaylistName.Size = new Size(234, 34);
            changePlaylistName.TabIndex = 23;
            changePlaylistName.Text = "change playlist name";
            changePlaylistName.UseVisualStyleBackColor = false;
            // 
            // PlaylistPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(changePlaylistName);
            Controls.Add(shuffle);
            Controls.Add(removePlaylist);
            Controls.Add(createPlaylist);
            Controls.Add(playPlaylist);
            Controls.Add(songSearchResult);
            Controls.Add(songsInPlaylist);
            Controls.Add(songsNotInPlaylist);
            Controls.Add(playlistPicker);
            Controls.Add(removeSongButton);
            Controls.Add(addSongButton);
            Controls.Add(PlaylistFindSongButton);
            Name = "PlaylistPage";
            Text = "PlaylistPage";
            Load += PlaylistPage_Load;
            ((System.ComponentModel.ISupportInitialize)playPlaylist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlaylistFindSongButton;
        private ImageList imageList1;
        private Button removeSongButton;
        private Button addSongButton;
        private ComboBox playlistPicker;
        private ListBox songsNotInPlaylist;
        private ListBox songsInPlaylist;
        private TextBox songSearchResult;
        private PictureBox playPlaylist;
        private Button createPlaylist;
        private Button removePlaylist;
        private CheckBox looping;
        private CheckBox shuffle;
        private Button changePlaylistName;
    }
}