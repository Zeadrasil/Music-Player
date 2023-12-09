namespace Music_Player
{
    public partial class SearchSongs : Form
    {
        string lastTerm = "";
        MusicPlayer player;
        public SearchSongs(ref MusicPlayer player)
        {
            InitializeComponent();
            this.player = player;
            player.search("");
            updateDisplay();
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

        private void SearchHomeButton_Click(object sender, EventArgs e)
        {
            changeForms(new HomePage(ref player));
        }

        private void SearchPlaylistButton_Click(object sender, EventArgs e)
        {
            changeForms(new PlaylistPage(ref player));
        }

        private void SearchAddSongButton_Click(object sender, EventArgs e)
        {
            changeForms(new Form1());
        }

        private void SearchControlSongButton_Click(object sender, EventArgs e)
        {
            if (player.getActiveSongCount() > 0)
            {
                var frm = new SongControls(player.getSong(new Random().Next(player.getActiveSongCount())), ref player);
                changeForms(frm);
            }
        }

        private void searchParameters_TextChanged(object sender, EventArgs e)
        {
            if (searchParameters.Text.Length < lastTerm.Length || searchParameters.Text.Length == 0)
            {
                player.clearSearch();
            }
            if (searchParameters.Text.Length > 0)
            {
                player.search(searchParameters.Text);
            }
            updateDisplay();
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            player.addSong();
            updateDisplay();
        }

        private void updateDisplay()
        {
            returnedSongs.BeginUpdate();
            returnedSongs.Items.Clear();
            player.search(searchParameters.Text);
            for (int i = 0; i < player.getActiveSongCount(); i++)
            {
                returnedSongs.Items.Add(player.getSong(i).getTitle() + " - " + player.getSong(i).getArtist());
            }
            returnedSongs.EndUpdate();
        }

        private void playSelectedSong_Click(object sender, EventArgs e)
        {
            if (returnedSongs.SelectedIndex != -1)
            {
                new SongControls(player.getSong(returnedSongs.SelectedIndex), ref player).Show();
            }
        }

        private void changeName_Click(object sender, EventArgs e)
        {
            if (returnedSongs.SelectedIndex != -1)
            {
                player.getSong(returnedSongs.SelectedIndex).updateName();
                updateDisplay();
            }
        }

        private void changeArtist_Click(object sender, EventArgs e)
        {
            if (returnedSongs.SelectedIndex != -1)
            {
                player.getSong(returnedSongs.SelectedIndex).updateArtist();
                updateDisplay();
            }
        }

        private void changeFilePath_Click(object sender, EventArgs e)
        {
            if (returnedSongs.SelectedIndex != -1)
            {
                player.getSong(returnedSongs.SelectedIndex).updatePath();
            }
        }


        private void removeSongButton_Click(object sender, EventArgs e)
        {
            if (returnedSongs.SelectedIndex != -1)
            {
                player.removeSong(returnedSongs.SelectedIndex);
                updateDisplay();
            }
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            changeForms(new HomePage(ref player));
        }
    }
}
