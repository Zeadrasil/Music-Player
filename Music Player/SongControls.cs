using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class SongControls : Form
    {
        private int playlistIndex = -1;
        private Song song;
        private Playlist? playlist;
        MusicPlayer player;
        public SongControls(Song song, ref MusicPlayer player)
        {
            InitializeComponent();
            this.song = song;
            onCreate();
            this.player = player;
        }
        public SongControls(Playlist playlist, int playlistIndex, ref MusicPlayer player)
        {
            InitializeComponent();
            song = playlist.getSong(playlistIndex);
            this.playlistIndex = playlistIndex;
            this.playlist = playlist;
            this.player = player;
            onCreate();
        }
        private void onCreate()
        {
            if(playlistIndex == -1)
            {
                nextSongPicBox.Hide();
                nextSongPicBox.Enabled = false;
                previousSongPicBox.Hide();
                previousSongPicBox.Enabled = false;
            }
            else
            {
                if(playlistIndex == 0)
                {
                    previousSongPicBox.Hide();
                    previousSongPicBox.Enabled = false;
                }
                else if(playlistIndex == playlist.getLength())
                { 
                    nextSongPicBox.Hide();
                    nextSongPicBox.Enabled = false;
                }
            }
        }
        private void changeForms(Form frm)
        {
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            //frm.FormClosing += delegate { this.Show(); };
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }

        private void ControllerHomeButton_Click(object sender, EventArgs e)
        {
            changeForms(new HomePage(ref player));
        }

        private void ControllerPlaylistButton_Click(object sender, EventArgs e)
        {
            changeForms(new PlaylistPage(ref player));
        }

        private void ControllerAddSongButton_Click(object sender, EventArgs e)
        {
            changeForms(new Form1());
        }

        private void ControllerFindSongButton_Click(object sender, EventArgs e)
        {
            changeForms(new SearchSongs(ref player));
        }

        private void previousSongPicBox_Click(object sender, EventArgs e)
        {
            changeForms(new SongControls(playlist, playlistIndex - 1, ref player));
        }

        private void pauseSongPicBox_Click(object sender, EventArgs e)
        {
            changeForms(new SongControls(playlist, playlistIndex + 1, ref player));
        }

        private void playSongPicBox_Click(object sender, EventArgs e)
        {

        }

        private void nextSongPicBox_Click(object sender, EventArgs e)
        {

        }
    }
}
