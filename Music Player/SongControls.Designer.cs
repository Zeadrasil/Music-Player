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
            imageList1 = new ImageList(components);
            ControllerFindSongButton = new Button();
            ControllerHomeButton = new Button();
            ControllerAddSongButton = new Button();
            ControllerPlaylistButton = new Button();
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
            // SongControls
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ControllerFindSongButton);
            Controls.Add(ControllerHomeButton);
            Controls.Add(ControllerAddSongButton);
            Controls.Add(ControllerPlaylistButton);
            Name = "SongControls";
            Text = "SongControls";
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Button ControllerFindSongButton;
        private Button ControllerHomeButton;
        private Button ControllerAddSongButton;
        private Button ControllerPlaylistButton;
    }
}