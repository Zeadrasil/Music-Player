using System.Numerics;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        private MusicPlayer player;
        private string lastTerm;
        public Form1()
        {
            InitializeComponent();
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
            player.playSong(player.getSong(listBox1.SelectedIndex).getId());
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
            for(int index = 0; index < player.getActiveSongCount(); index++)
            {
                Song song = player.getSong(index);
                listBox1.Items.Add(song.getTitle() + "  |  " + song.getArtist());
            }
        }
    }
}