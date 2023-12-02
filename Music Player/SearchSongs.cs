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
    public partial class SearchSongs : Form
    {
        MusicPlayer player;
        public SearchSongs(ref MusicPlayer player)
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
    }
}
