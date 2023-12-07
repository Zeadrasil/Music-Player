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
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // HomePlaylistButton
            // 
            HomePlaylistButton.Location = new Point(16, 109);
            HomePlaylistButton.Name = "HomePlaylistButton";
            HomePlaylistButton.Size = new Size(112, 34);
            HomePlaylistButton.TabIndex = 1;
            HomePlaylistButton.Text = "playlists";
            HomePlaylistButton.UseVisualStyleBackColor = true;
            HomePlaylistButton.Click += HomePlaylistButton_Click;
            // 
            // HomeFindSongButton
            // 
            HomeFindSongButton.Location = new Point(169, 109);
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
            // button3
            // 
            button3.Location = new Point(169, 12);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "Load";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(16, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 182);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button3;
        private Button button2;
    }
}