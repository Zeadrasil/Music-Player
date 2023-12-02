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
    public partial class PlaylistPage : Form
    {
        MusicPlayer player;
        public PlaylistPage(ref MusicPlayer player)
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
    }
}
