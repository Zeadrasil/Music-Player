namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusicPlayer player = new MusicPlayer();
            player.addSong();
            player.playSong(0);

        }
    }
}