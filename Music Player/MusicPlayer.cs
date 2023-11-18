using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    internal class MusicPlayer
    {
        private List<Song> songs;
        public MusicPlayer()
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
                    songs.Insert(song.getId(), song);
                    return true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error creating song:\n" + ex.Message);
                return false;
            }
        }
        public bool removeSong(int index)
        {
            try
            {
                int trueIndex = getTrueIndex(index);
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

        public void playSong(int index)
        {
            SongPlayer.PlaySong(songs[getTrueIndex(index)]);
        }

        private int getTrueIndex(int index)
        {
            int trueIndex = index;
            for (int i = 0; i < index && i < Song.getOpenIds().Count; i++)
            {
                if (Song.getOpenIds()[i] > index) break;
                trueIndex--;
            }
            return trueIndex;
        }
    }
}
