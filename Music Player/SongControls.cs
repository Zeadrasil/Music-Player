using System.Collections.Concurrent;

namespace Music_Player
{
    public partial class SongControls : Form
    {
        private int playlistIndex = -1;
        private Song song;
        private Playlist? playlist;
        MusicPlayer player;
        ConcurrentDictionary<int, int> slider;
        ConcurrentDictionary<int, bool> loop;
        Task headTask;
        public SongControls(Song song, ref MusicPlayer player)
        {
            InitializeComponent();
            this.song = song;
            this.player = player;
            slider = new ConcurrentDictionary<int, int>();
            loop = new ConcurrentDictionary<int, bool>();
            onCreate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            player.getSongPlayer().StopSong();
            base.OnFormClosing(e);
        }

        public SongControls(Playlist playlist, int playlistIndex, ref MusicPlayer player)
        {
            InitializeComponent();
            song = playlist.getSong(playlistIndex);
            this.playlistIndex = playlistIndex;
            this.playlist = playlist;
            this.player = player;
            slider = new ConcurrentDictionary<int, int>();
            loop = new ConcurrentDictionary<int, bool>();
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
                song = playlist.getSong(playlistIndex);
            }
        }
        private void changeForms(Form frm)
        {
            player.getSongPlayer().StopSong();
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
            if (playlistIndex == 0)
            {
                changeForms(new SongControls(playlist, playlist.getLength(), ref player));
            }
            else
            {
                changeForms(new SongControls(playlist, playlistIndex - 1, ref player));
            }
        }

        private void playSongPicBox_Click(object sender, EventArgs e)
        {
            if (player.getSongPlayer().GetPlaybackState() == CSCore.SoundOut.PlaybackState.Playing)
            {
                player.getSongPlayer().PauseSong();
                playSongPicBox.Image = imageList1.Images[0];
            }
            else if (player.getSongPlayer().GetPlaybackState() == CSCore.SoundOut.PlaybackState.Paused)
            {
                player.getSongPlayer().ResumeSong();
                playSongPicBox.Image = imageList1.Images[1];
                headTask = new Task(updateHead);
                headTask.Start();
            }
            else
            {
                player.getSongPlayer().PlaySong(song);
                placeInSong.Maximum = player.getSongPlayer().getLength();
                placeInSong.SmallChange = (int) (placeInSong.Maximum * 0.05f);
                placeInSong.LargeChange = (int)(placeInSong.Maximum * 0.2f);
                headTask = new Task(updateHead);
                headTask.Start();
            }
        }


        private void nextSongPicBox_Click(object sender, EventArgs e)
        {
            if (playlistIndex == playlist.getLength() - 1)
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
            slider.TryAdd(0, placeInSong.Value);
            loop.TryAdd(0, checkBox1.Checked);
            playSongPicBox_Click(sender, e);
        }

        private void updateHead()
        {
            try
            {
                int bar;
                while (player.getSongPlayer().getPosition() < player.getSongPlayer().getLength() && player.getSongPlayer().GetPlaybackState() == CSCore.SoundOut.PlaybackState.Playing && player.getSongPlayer().getPlayingSong() == song)
                {
                    slider.TryGetValue(0, out bar);
                    Thread.Sleep(200);
                    if (Math.Abs(player.getSongPlayer().getPosition() - bar) > 300)
                    {
                        player.getSongPlayer().SeekToTimeMS(bar);
                    }
                    placeInSong.Invoke(updatePlace, player.getSongPlayer().getPosition());
                }
                if (player.getSongPlayer().getPlayingSong() != song)
                {
                    Close();
                }
                if (player.getSongPlayer().GetPlaybackState() != CSCore.SoundOut.PlaybackState.Paused)
                {
                    bool looping;
                    loop.TryGetValue(0, out looping);
                    if (looping)
                    {
                        placeInSong.Invoke(updatePlace, 0);
                        player.getSongPlayer().PauseSong();
                        playSongPicBox_Click(null, null);
                    }
                    else if (playlist != null && playlistIndex < playlist.getLength())
                    {
                        nextSongPicBox_Click(null, null);
                    }
                    else
                    {
                        placeInSong.Invoke(close, 0);
                    }
                }
            }
            catch(ObjectDisposedException)
            {

            }
        }

        private void updatePlace(int place)
        {
            int update;
            slider.TryGetValue(0, out update);
            slider.TryUpdate(0, place, update);
            placeInSong.Value = place;
        }

        private void placeInSong_Scroll(object sender, EventArgs e)
        {
            int old;
            slider.TryGetValue(0, out old);
            slider.TryUpdate(0, placeInSong.Value, old);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool old;
            loop.TryGetValue(0, out old);
            loop.TryUpdate(0, checkBox1.Checked, old);
        }
        private void close(int useless)
        {
            this.Close();
        }
    }
}
