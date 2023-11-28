namespace Music_Player
{
    partial class HomePage
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
            HomePlaylistButton = new Button();
            HomeAddSongButton = new Button();
            HomeControlSongButton = new Button();
            HomeFindSongButton = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // HomePlaylistButton
            // 
            HomePlaylistButton.Location = new Point(160, 404);
            HomePlaylistButton.Name = "HomePlaylistButton";
            HomePlaylistButton.Size = new Size(112, 34);
            HomePlaylistButton.TabIndex = 1;
            HomePlaylistButton.Text = "playlists";
            HomePlaylistButton.UseVisualStyleBackColor = true;
            HomePlaylistButton.Click += HomePlaylistButton_Click;
            // 
            // HomeAddSongButton
            // 
            HomeAddSongButton.Location = new Point(278, 404);
            HomeAddSongButton.Name = "HomeAddSongButton";
            HomeAddSongButton.Size = new Size(112, 34);
            HomeAddSongButton.TabIndex = 2;
            HomeAddSongButton.Text = "addsong";
            HomeAddSongButton.UseVisualStyleBackColor = true;
            HomeAddSongButton.Click += HomeAddSongButton_Click;
            // 
            // HomeControlSongButton
            // 
            HomeControlSongButton.Location = new Point(396, 404);
            HomeControlSongButton.Name = "HomeControlSongButton";
            HomeControlSongButton.Size = new Size(118, 34);
            HomeControlSongButton.TabIndex = 3;
            HomeControlSongButton.Text = "controlSong";
            HomeControlSongButton.UseVisualStyleBackColor = true;
            HomeControlSongButton.Click += HomeControlSongButton_Click;
            // 
            // HomeFindSongButton
            // 
            HomeFindSongButton.Location = new Point(520, 404);
            HomeFindSongButton.Name = "HomeFindSongButton";
            HomeFindSongButton.Size = new Size(112, 34);
            HomeFindSongButton.TabIndex = 4;
            HomeFindSongButton.Text = "search";
            HomeFindSongButton.UseVisualStyleBackColor = true;
            HomeFindSongButton.Click += HomeFindSongButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HomeFindSongButton);
            Controls.Add(HomeControlSongButton);
            Controls.Add(HomeAddSongButton);
            Controls.Add(HomePlaylistButton);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion
        private Button HomePlaylistButton;
        private Button HomeAddSongButton;
        private Button HomeControlSongButton;
        private Button HomeFindSongButton;
        private ImageList imageList1;
    }
}