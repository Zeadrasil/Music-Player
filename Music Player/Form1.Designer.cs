﻿namespace Music_Player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            SearchControlSongButton = new Button();
            SearchHomeButton = new Button();
            SearchAddSongButton = new Button();
            SearchPlaylistButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(168, 231);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "addSong";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(370, 244);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(602, 267);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Load";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(610, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(86, 271);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 5;
            button4.Text = "remove song";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(313, 308);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 6;
            button5.Text = "play";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(110, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(610, 154);
            listBox1.TabIndex = 7;
            // 
            // SearchControlSongButton
            // 
            SearchControlSongButton.Location = new Point(537, 404);
            SearchControlSongButton.Name = "SearchControlSongButton";
            SearchControlSongButton.Size = new Size(120, 34);
            SearchControlSongButton.TabIndex = 16;
            SearchControlSongButton.Text = "controlSongs";
            SearchControlSongButton.UseVisualStyleBackColor = true;
            SearchControlSongButton.Click += SearchControlSongButton_Click;
            // 
            // SearchHomeButton
            // 
            SearchHomeButton.Location = new Point(177, 404);
            SearchHomeButton.Name = "SearchHomeButton";
            SearchHomeButton.Size = new Size(118, 34);
            SearchHomeButton.TabIndex = 15;
            SearchHomeButton.Text = "home";
            SearchHomeButton.UseVisualStyleBackColor = true;
            SearchHomeButton.Click += SearchHomeButton_Click;
            // 
            // SearchAddSongButton
            // 
            SearchAddSongButton.Location = new Point(419, 404);
            SearchAddSongButton.Name = "SearchAddSongButton";
            SearchAddSongButton.Size = new Size(112, 34);
            SearchAddSongButton.TabIndex = 14;
            SearchAddSongButton.Text = "search";
            SearchAddSongButton.UseVisualStyleBackColor = true;
            SearchAddSongButton.Click += SearchAddSongButton_Click;
            // 
            // SearchPlaylistButton
            // 
            SearchPlaylistButton.Location = new Point(301, 404);
            SearchPlaylistButton.Name = "SearchPlaylistButton";
            SearchPlaylistButton.Size = new Size(112, 34);
            SearchPlaylistButton.TabIndex = 13;
            SearchPlaylistButton.Text = "playlists";
            SearchPlaylistButton.UseVisualStyleBackColor = true;
            SearchPlaylistButton.Click += SearchPlaylistButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchControlSongButton);
            Controls.Add(SearchHomeButton);
            Controls.Add(SearchAddSongButton);
            Controls.Add(SearchPlaylistButton);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private ListBox listBox1;
        private Button SearchControlSongButton;
        private Button SearchHomeButton;
        private Button SearchAddSongButton;
        private Button SearchPlaylistButton;
    }
}