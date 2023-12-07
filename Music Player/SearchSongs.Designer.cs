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
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SearchPlaylistButton
            // 
            SearchPlaylistButton.Location = new Point(346, 404);
            SearchPlaylistButton.Name = "SearchPlaylistButton";
            SearchPlaylistButton.Size = new Size(112, 34);
            SearchPlaylistButton.TabIndex = 9;
            SearchPlaylistButton.Text = "playlists";
            SearchPlaylistButton.UseVisualStyleBackColor = true;
            SearchPlaylistButton.Click += SearchPlaylistButton_Click;
            // 
            // searchParameters
            // 
            searchParameters.Location = new Point(107, 60);
            searchParameters.Name = "searchParameters";
            searchParameters.Size = new Size(610, 31);
            searchParameters.TabIndex = 13;
            searchParameters.TextChanged += searchParameters_TextChanged;
            // 
            // returnedSongs
            // 
            returnedSongs.FormattingEnabled = true;
            returnedSongs.ItemHeight = 25;
            returnedSongs.Location = new Point(107, 110);
            returnedSongs.Name = "returnedSongs";
            returnedSongs.Size = new Size(610, 154);
            returnedSongs.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(369, 270);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "play.png");
            // 
            // SearchSongs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(returnedSongs);
            Controls.Add(searchParameters);
            Controls.Add(SearchPlaylistButton);
            Name = "SearchSongs";
            Text = "lkm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SearchPlaylistButton;
        private TextBox searchParameters;
        private ListBox returnedSongs;
        private PictureBox pictureBox1;
        private ImageList imageList1;
    }
}