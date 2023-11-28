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
            SearchControlSongButton = new Button();
            SearchHomeButton = new Button();
            SearchAddSongButton = new Button();
            SearchPlaylistButton = new Button();
            SuspendLayout();
            // 
            // SearchControlSongButton
            // 
            SearchControlSongButton.Location = new Point(522, 404);
            SearchControlSongButton.Name = "SearchControlSongButton";
            SearchControlSongButton.Size = new Size(120, 34);
            SearchControlSongButton.TabIndex = 12;
            SearchControlSongButton.Text = "controlSongs";
            SearchControlSongButton.UseVisualStyleBackColor = true;
            SearchControlSongButton.Click += SearchControlSongButton_Click;
            // 
            // SearchHomeButton
            // 
            SearchHomeButton.Location = new Point(162, 404);
            SearchHomeButton.Name = "SearchHomeButton";
            SearchHomeButton.Size = new Size(118, 34);
            SearchHomeButton.TabIndex = 11;
            SearchHomeButton.Text = "home";
            SearchHomeButton.UseVisualStyleBackColor = true;
            SearchHomeButton.Click += SearchHomeButton_Click;
            // 
            // SearchAddSongButton
            // 
            SearchAddSongButton.Location = new Point(404, 404);
            SearchAddSongButton.Name = "SearchAddSongButton";
            SearchAddSongButton.Size = new Size(112, 34);
            SearchAddSongButton.TabIndex = 10;
            SearchAddSongButton.Text = "addsong";
            SearchAddSongButton.UseVisualStyleBackColor = true;
            SearchAddSongButton.Click += SearchAddSongButton_Click;
            // 
            // SearchPlaylistButton
            // 
            SearchPlaylistButton.Location = new Point(286, 404);
            SearchPlaylistButton.Name = "SearchPlaylistButton";
            SearchPlaylistButton.Size = new Size(112, 34);
            SearchPlaylistButton.TabIndex = 9;
            SearchPlaylistButton.Text = "playlists";
            SearchPlaylistButton.UseVisualStyleBackColor = true;
            SearchPlaylistButton.Click += SearchPlaylistButton_Click;
            // 
            // SearchSongs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchControlSongButton);
            Controls.Add(SearchHomeButton);
            Controls.Add(SearchAddSongButton);
            Controls.Add(SearchPlaylistButton);
            Name = "SearchSongs";
            Text = "SearchSongs";
            ResumeLayout(false);
        }

        #endregion

        private Button SearchControlSongButton;
        private Button SearchHomeButton;
        private Button SearchAddSongButton;
        private Button SearchPlaylistButton;
    }
}