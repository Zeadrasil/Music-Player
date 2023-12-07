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
            HomeFindSongButton = new Button();
            imageList1 = new ImageList(components);
            loadButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // HomePlaylistButton
            // 
            HomePlaylistButton.BackColor = SystemColors.ActiveCaptionText;
            HomePlaylistButton.ForeColor = SystemColors.ButtonFace;
            HomePlaylistButton.Location = new Point(16, 109);
            HomePlaylistButton.Name = "HomePlaylistButton";
            HomePlaylistButton.Size = new Size(112, 34);
            HomePlaylistButton.TabIndex = 1;
            HomePlaylistButton.Text = "playlists";
            HomePlaylistButton.UseVisualStyleBackColor = false;
            HomePlaylistButton.Click += HomePlaylistButton_Click;
            // 
            // HomeFindSongButton
            // 
            HomeFindSongButton.BackColor = SystemColors.ActiveCaptionText;
            HomeFindSongButton.ForeColor = SystemColors.ButtonFace;
            HomeFindSongButton.Location = new Point(169, 109);
            HomeFindSongButton.Name = "HomeFindSongButton";
            HomeFindSongButton.Size = new Size(112, 34);
            HomeFindSongButton.TabIndex = 4;
            HomeFindSongButton.Text = "search";
            HomeFindSongButton.UseVisualStyleBackColor = false;
            HomeFindSongButton.Click += HomeFindSongButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // loadButton
            // 
            loadButton.BackColor = SystemColors.ActiveCaptionText;
            loadButton.ForeColor = SystemColors.ButtonFace;
            loadButton.Location = new Point(169, 12);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(112, 34);
            loadButton.TabIndex = 13;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ActiveCaptionText;
            saveButton.ForeColor = SystemColors.ButtonFace;
            saveButton.Location = new Point(16, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(307, 182);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(HomeFindSongButton);
            Controls.Add(HomePlaylistButton);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion
        private Button HomePlaylistButton;
        private Button HomeFindSongButton;
        private ImageList imageList1;
        private Button loadButton;
        private Button saveButton;
    }
}