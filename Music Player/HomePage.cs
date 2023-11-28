using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Music_Player
{
    public partial class HomePage : Form
    {
        public HomePage()
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

        private void HomePlaylistButton_Click(object sender, EventArgs e)
        {
            var frm = new PlaylistPage();
            changeForms(frm);
        }

        private void HomeAddSongButton_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            changeForms(frm);
        }

        private void HomeControlSongButton_Click(object sender, EventArgs e)
        {
            var frm = new SongControls();
            changeForms(frm);
        }

        private void HomeFindSongButton_Click(object sender, EventArgs e)
        {
            var frm = new SearchSongs();
            changeForms(frm);
        }
    }
}
