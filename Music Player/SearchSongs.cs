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
        public SearchSongs()
        {
            InitializeComponent();
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
            changeForms(new HomePage());
        }

        private void SearchPlaylistButton_Click(object sender, EventArgs e)
        {
            changeForms(new PlaylistPage());
        }

        private void SearchAddSongButton_Click(object sender, EventArgs e)
        {
            changeForms(new Form1());
        }

        private void SearchControlSongButton_Click(object sender, EventArgs e)
        {
            changeForms(new SongControls());
        }
    }
}
