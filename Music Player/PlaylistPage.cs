namespace Music_Player
{
    public partial class PlaylistPage : Form
    {
        MusicPlayer player;
        string lastTerm = "";
        List<int> inPlaylist = new List<int>();
        List<int> outPlaylist = new List<int>();
        List<int> localIndex = new List<int>();
        public PlaylistPage(ref MusicPlayer player)
        {
            InitializeComponent();
            this.player = player;
            updateDisplays();
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

        private void PlaylistHomeButton_Click(object sender, EventArgs e)
        {
            changeForms(new HomePage(ref player));
        }

        private void PlaylistAddSongButton_Click(object sender, EventArgs e)
        {
            changeForms(new Form1());
        }

        private void PlaylistControlSongButton_Click(object sender, EventArgs e)
        {
            if (player.getActiveSongCount() > 0)
            {
                var frm = new SongControls(player.getSong(new Random().Next(player.getActiveSongCount())), ref player);
                changeForms(frm);
            }
        }

        private void PlaylistFindSongButton_Click(object sender, EventArgs e)
        {
            changeForms(new SearchSongs(ref player));
        }

        private void playlistPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplays();
        }

        private void updateDisplays()
        {
            songsInPlaylist.BeginUpdate();
            songsNotInPlaylist.BeginUpdate();
            songsInPlaylist.Items.Clear();
            songsNotInPlaylist.Items.Clear();
            inPlaylist.Clear();
            outPlaylist.Clear();
            if (playlistPicker.SelectedIndex != -1)
            {
                player.getPlaylist(playlistPicker.SelectedIndex).unShuffle();
                for (int i = 0; i < player.getActiveSongCount(); i++)
                {
                    if (player.getPlaylist(playlistPicker.SelectedIndex).contains(player.getSong(i)))
                    {
                        songsInPlaylist.Items.Add(player.getSong(i).getTitle() + " - " + player.getSong(i).getArtist());
                        inPlaylist.Add(player.getSong(i).getId());
                    }
                    else
                    {
                        songsNotInPlaylist.Items.Add(player.getSong(i).getTitle() + " - " + player.getSong(i).getArtist());
                        outPlaylist.Add(player.getSong(i).getId());
                    }
                }
                for(int i = 0; i < player.getPlaylist(playlistPicker.SelectedIndex).getLength(); i++)
                {
                    if(player.searchContains(player.getPlaylist(playlistPicker.SelectedIndex).getSong(i)))
                    {
                        localIndex.Add(i);
                    }
                }
            }
            songsInPlaylist.SelectedIndex = -1;
            songsNotInPlaylist.SelectedIndex = -1;
            songsInPlaylist.EndUpdate();
            songsNotInPlaylist.EndUpdate();
        }

        private void songSearchResult_TextChanged(object sender, EventArgs e)
        {
            if (songSearchResult.Text.Length < lastTerm.Length || songSearchResult.Text.Length == 0)
            {
                player.clearSearch();
            }
            if (songSearchResult.Text.Length > 0)
            {
                player.search(songSearchResult.Text);
            }
            lastTerm = songSearchResult.Text;
            updateDisplays();
        }

        private void removeSongButton_Click(object sender, EventArgs e)
        {
            if (playlistPicker.SelectedIndex != -1 && songsInPlaylist.SelectedIndex != -1)
            {
                player.getPlaylist(playlistPicker.SelectedIndex).removeSong(player.getSong(localIndex[songsInPlaylist.SelectedIndex]));
                updateDisplays();
            }
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            if (playlistPicker.SelectedIndex != -1 && songsNotInPlaylist.SelectedIndex != -1)
            {
                player.getPlaylist(playlistPicker.SelectedIndex).addSong(player.getSong(outPlaylist[songsNotInPlaylist.SelectedIndex]));
                updateDisplays();
            }
        }

        private void playPlaylist_Click(object sender, EventArgs e)
        {
            if (playlistPicker.SelectedIndex != -1/*  && songsInPlaylist.SelectedIndex != -1 */)
            {
                if (shuffle.Checked) player.getPlaylist(playlistPicker.SelectedIndex).shuffle();
                if (songsInPlaylist.SelectedIndex == -1)
                {
                    new SongControls(player.getPlaylist(playlistPicker.SelectedIndex), 0, ref player).Show();
                }
                else
                {
                    new SongControls(player.getPlaylist(playlistPicker.SelectedIndex), player.getPlaylist(playlistPicker.SelectedIndex).getRelativeIndex(localIndex[songsInPlaylist.SelectedIndex]), ref player).Show();
                }
            }
        }


        private void createPlaylist_Click(object sender, EventArgs e)
        {
            player.addPlaylist();
            playlistPicker.Items.Add(player.getPlaylist(player.getPlaylistCount() - 1).getName());
            playlistPicker.SelectedIndex = playlistPicker.Items.Count - 1;
        }

        private void removePlaylist_Click(object sender, EventArgs e)
        {
            if (playlistPicker.SelectedIndex != -1)
            {
                player.removePlaylist(playlistPicker.SelectedIndex);
                playlistPicker.Items.RemoveAt(playlistPicker.SelectedIndex);
                playlistPicker.Text = "";
            }
        }

        private void PlaylistPage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < player.getPlaylistCount(); i++)
            {
                playlistPicker.Items.Add(player.getPlaylist(i).getName());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeForms(new HomePage(ref player));
        }
    }
}
