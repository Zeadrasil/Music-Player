namespace Music_Player
{
    public partial class HomePage : Form
    {
        MusicPlayer player;
        public HomePage()
        {
            InitializeComponent();
            player = new MusicPlayer();
        }
        public HomePage(ref MusicPlayer player)
        {
            InitializeComponent();
            this.player = player;
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

        private void HomePlaylistButton_Click(object sender, EventArgs e)
        {
            var frm = new PlaylistPage(ref player);
            changeForms(frm);
        }

        private void HomeAddSongButton_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            changeForms(frm);
        }

        private void HomeControlSongButton_Click(object sender, EventArgs e)
        {
            if (player.getActiveSongCount() > 0)
            {
                var frm = new SongControls(player.getSong(new Random().Next(player.getActiveSongCount())), ref player);
                changeForms(frm);
            }
        }

        private void HomeFindSongButton_Click(object sender, EventArgs e)
        {
            var frm = new SearchSongs(ref player);
            changeForms(frm);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            player.save();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            player.load();
        }
    }
}
