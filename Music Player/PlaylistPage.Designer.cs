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
            PlaylistFindSongButton = new Button();
            PlaylistControlSongButton = new Button();
            PlaylistAddSongButton = new Button();
            PlaylistHomeButton = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // PlaylistFindSongButton
            // 
            PlaylistFindSongButton.Location = new Point(527, 404);
            PlaylistFindSongButton.Name = "PlaylistFindSongButton";
            PlaylistFindSongButton.Size = new Size(112, 34);
            PlaylistFindSongButton.TabIndex = 8;
            PlaylistFindSongButton.Text = "search";
            PlaylistFindSongButton.UseVisualStyleBackColor = true;
            PlaylistFindSongButton.Click += PlaylistFindSongButton_Click;
            // 
            // PlaylistControlSongButton
            // 
            PlaylistControlSongButton.Location = new Point(403, 404);
            PlaylistControlSongButton.Name = "PlaylistControlSongButton";
            PlaylistControlSongButton.Size = new Size(118, 34);
            PlaylistControlSongButton.TabIndex = 7;
            PlaylistControlSongButton.Text = "controlSong";
            PlaylistControlSongButton.UseVisualStyleBackColor = true;
            PlaylistControlSongButton.Click += PlaylistControlSongButton_Click;
            // 
            // PlaylistAddSongButton
            // 
            PlaylistAddSongButton.Location = new Point(285, 404);
            PlaylistAddSongButton.Name = "PlaylistAddSongButton";
            PlaylistAddSongButton.Size = new Size(112, 34);
            PlaylistAddSongButton.TabIndex = 6;
            PlaylistAddSongButton.Text = "addsong";
            PlaylistAddSongButton.UseVisualStyleBackColor = true;
            PlaylistAddSongButton.Click += PlaylistAddSongButton_Click;
            // 
            // PlaylistHomeButton
            // 
            PlaylistHomeButton.Location = new Point(167, 404);
            PlaylistHomeButton.Name = "PlaylistHomeButton";
            PlaylistHomeButton.Size = new Size(112, 34);
            PlaylistHomeButton.TabIndex = 5;
            PlaylistHomeButton.Text = "home";
            PlaylistHomeButton.UseVisualStyleBackColor = true;
            PlaylistHomeButton.Click += PlaylistHomeButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // PlaylistPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PlaylistFindSongButton);
            Controls.Add(PlaylistControlSongButton);
            Controls.Add(PlaylistAddSongButton);
            Controls.Add(PlaylistHomeButton);
            Name = "PlaylistPage";
            Text = "PlaylistPage";
            ResumeLayout(false);
        }

        #endregion

        private Button PlaylistFindSongButton;
        private Button PlaylistControlSongButton;
        private Button PlaylistAddSongButton;
        private Button PlaylistHomeButton;
        private ImageList imageList1;
    }
}