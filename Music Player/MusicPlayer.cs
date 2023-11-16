using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    internal class MusicPlayer
    {
        List<Song> songs;

        MusicPlayer()
        {
            songs = new List<Song>();
        }

        public void load()
        {

        }

        public bool addSong()
        {
            try
            {
                Song song = Song.CreateSong();
                if (song.Equals(null))
                {
                    return false;
                }
                else
                {
                    songs.Append(song);
                    return true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error creating song:\n" + ex.Message);
                return false;
            }
        }
        public bool removeSong(uint index)
        {
            try
            {
                int trueIndex = (int)index;
                for(int i = 0; i < index && i < Song.getOpenIds().Count; i++)
                {
                    if (Song.getOpenIds()[i] > index) break;
                    trueIndex--;
                }
                songs[trueIndex].delete();
                songs.RemoveAt(trueIndex);
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error deleting song:\n" + ex.Message);
                return false;
            }
        }
    }
}
