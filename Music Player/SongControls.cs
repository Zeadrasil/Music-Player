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
        bool looping = false; //Placeholder, there should be a control for this
        bool playlistLooping = false; //Placeholder, there should be a control for this
        public SongControls(Song song, ref MusicPlayer player)
        {
            InitializeComponent();
            this.song = song;
            onCreate();
            this.player = player;
        }
        public SongControls(Playlist playlist, int playlistIndex, ref MusicPlayer player, bool playlistLooping = false)
        {
            InitializeComponent();
            song = playlist.getSong(playlistIndex);
            this.playlistIndex = playlistIndex;
            this.playlist = playlist;
            this.player = player;
            this.playlistLooping = playlistLooping;
            onCreate();
        }
        private void onCreate()
        {
            if (playlistIndex == -1)
            {
                nextSongPicBox.Hide();
                nextSongPicBox.Enabled = false;
                previousSongPicBox.Hide();
                previousSongPicBox.Enabled = false;
            }
            else
            {
                if (playlistIndex == 0)
                {
                    previousSongPicBox.Hide();
                    previousSongPicBox.Enabled = false;
                }
                else if (playlistIndex == playlist.getLength())
                {
                    nextSongPicBox.Hide();
                    nextSongPicBox.Enabled = false;
                }
                song = playlist.getSong(playlistIndex);
            }
            SongPlayer.StopSong();
            playSongPicBox_Click(null, null);
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


        private void playSongPicBox_Click(object sender, EventArgs e)
        {
            if (SongPlayer.GetPlaybackState() == CSCore.SoundOut.PlaybackState.Playing)
            {
                SongPlayer.PauseSong();
                playSongPicBox.Image = imageList1.Images[0];
            }
            else if (SongPlayer.GetPlaybackState() == CSCore.SoundOut.PlaybackState.Paused)
            {
                SongPlayer.ResumeSong();
                playSongPicBox.Image = imageList1.Images[0];
            }
            else
            {
                SongPlayer.PlaySong(song);
            }
            while (SongPlayer.GetPlaybackState() == CSCore.SoundOut.PlaybackState.Playing)
            {
                Thread.Sleep(100);
            }
            if (SongPlayer.getPlayingSong() != song)
            {
                Close();
            }
            if (SongPlayer.GetPlaybackState() == CSCore.SoundOut.PlaybackState.Stopped)
            {
                if (checkBox1.Checked)
                {
                    playSongPicBox_Click(sender, e);
                }
                else if (playlist != null && playlistIndex < playlist.getLength())
                {
                    nextSongPicBox_Click(sender, e);
                }
            }
        }

        private void nextSongPicBox_Click(object sender, EventArgs e)
        {
            if (playlistLooping && playlistIndex == playlist.getLength())
            {
                playlistIndex = -1;
            }
            changeForms(new SongControls(playlist, playlistIndex + 1, ref player));
        }

        private void SongControls_Load(object sender, EventArgs e)
        {
            if (playlist != null)
            {
                playlistName.Text = playlist.getName();
            }
            else
            {
                playlistName.Text = "";
            }
            songName.Text = song.getTitle();
            artistName.Text = song.getArtist();
        }
    }
}
