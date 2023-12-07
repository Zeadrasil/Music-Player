﻿namespace Music_Player
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
            button4 = new Button();
            button1 = new Button();
            playlistPicker = new ComboBox();
            songsNotInPlaylist = new ListBox();
            songsInPlaylist = new ListBox();
            songSearchResult = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PlaylistFindSongButton
            // 
            PlaylistFindSongButton.Location = new Point(676, 404);
            PlaylistFindSongButton.Name = "PlaylistFindSongButton";
            PlaylistFindSongButton.Size = new Size(112, 34);
            PlaylistFindSongButton.TabIndex = 8;
            PlaylistFindSongButton.Text = "songs";
            PlaylistFindSongButton.UseVisualStyleBackColor = true;
            PlaylistFindSongButton.Click += PlaylistFindSongButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button4
            // 
            button4.Location = new Point(12, 211);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 12;
            button4.Text = "remove song";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(165, 211);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "addSong";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // playlistPicker
            // 
            playlistPicker.FormattingEnabled = true;
            playlistPicker.Location = new Point(12, 12);
            playlistPicker.Name = "playlistPicker";
            playlistPicker.Size = new Size(205, 33);
            playlistPicker.TabIndex = 13;
            playlistPicker.SelectedIndexChanged += playlistPicker_SelectedIndexChanged;
            // 
            // songsNotInPlaylist
            // 
            songsNotInPlaylist.FormattingEnabled = true;
            songsNotInPlaylist.ItemHeight = 25;
            songsNotInPlaylist.Location = new Point(523, 49);
            songsNotInPlaylist.Name = "songsNotInPlaylist";
            songsNotInPlaylist.Size = new Size(265, 129);
            songsNotInPlaylist.TabIndex = 14;
            // 
            // songsInPlaylist
            // 
            songsInPlaylist.FormattingEnabled = true;
            songsInPlaylist.ItemHeight = 25;
            songsInPlaylist.Location = new Point(12, 51);
            songsInPlaylist.Name = "songsInPlaylist";
            songsInPlaylist.Size = new Size(265, 129);
            songsInPlaylist.TabIndex = 15;
            // 
            // songSearchResult
            // 
            songSearchResult.Location = new Point(620, 12);
            songSearchResult.Name = "songSearchResult";
            songSearchResult.Size = new Size(168, 31);
            songSearchResult.TabIndex = 16;
            songSearchResult.TextChanged += songSearchResult_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(115, 269);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(473, 264);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 18;
            button2.Text = "shuffle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(622, 255);
            button3.Name = "button3";
            button3.Size = new Size(112, 72);
            button3.TabIndex = 19;
            button3.Text = "create playlist";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(490, 332);
            button5.Name = "button5";
            button5.Size = new Size(112, 62);
            button5.TabIndex = 20;
            button5.Text = "remove playlist";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // PlaylistPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(songSearchResult);
            Controls.Add(songsInPlaylist);
            Controls.Add(songsNotInPlaylist);
            Controls.Add(playlistPicker);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(PlaylistFindSongButton);
            Name = "PlaylistPage";
            Text = "PlaylistPage";
            Load += PlaylistPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlaylistFindSongButton;
        private ImageList imageList1;
        private Button button4;
        private Button button1;
        private ComboBox playlistPicker;
        private ListBox songsNotInPlaylist;
        private ListBox songsInPlaylist;
        private TextBox songSearchResult;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}