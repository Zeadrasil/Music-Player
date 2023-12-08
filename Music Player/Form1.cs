namespace Music_Player
{
    public partial class Form1 : Form
    {
        private MusicPlayer player;
        private string lastTerm;
        public Form1()
        {
            InitializeComponent();
            player = new MusicPlayer();
            lastTerm = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new MusicPlayer();
            lastTerm = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.addSong();
            player.clearSearch();
            if (textBox1.Text.Length > 0)
            {
                player.search(textBox1.Text);
            }
            updateOptions();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                player.removeSong(player.getSong(listBox1.SelectedIndex).getId());
                updateOptions();
            }
            else
            {
                MessageBox.Show("Please remove search terms");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < lastTerm.Length || textBox1.Text.Length == 0)
            {
                player.clearSearch();
            }
            if (textBox1.Text.Length > 0)
            {
                player.search(textBox1.Text);
            }
            updateOptions();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.play(player.getSong(listBox1.SelectedIndex).getId());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = player.save().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.load();
            updateOptions();
        }

        private void updateOptions()
        {
            listBox1.Items.Clear();
            for (int index = 0; index < player.getActiveSongCount(); index++)
            {
                Song song = player.getSong(index);
                listBox1.Items.Add(song.getTitle() + "  |  " + song.getArtist());
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
            changeForms(new SearchSongs(ref player));
        }

        private void SearchControlSongButton_Click(object sender, EventArgs e)
        {
            changeForms(new SongControls(player.getSong(listBox1.SelectedIndex), ref player));
        }
    }
}