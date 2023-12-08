using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public partial class Playlist
    {
        private List<Song> songs;
        private List<int> songOrder;
        private string name;
        private bool shuffled = false;
        private int id;
        private static int count;
        private static List<int> openIds = new List<int>();
        public Playlist(string name, int id)
        {
            this.name = name;
            this.id = id;
            songs = new List<Song>();
            songOrder = new List<int>();
        }

        public static Playlist createPlaylist()
        {
            string[] name = new string[1];
            name[0] = "";
            do
            {
                GetStringForm gsf = new GetStringForm("What is the name of the new playlist?", ref name);
                gsf.ShowDialog();
            } while (string.IsNullOrWhiteSpace(name[0]));

            int id = count;
            if (openIds.Count > 0)
            {
                id = openIds[0];
                openIds.RemoveAt(0);
            }
            return new Playlist(name[0], id);
        }
        public void shuffle()
        {
            Random random = new Random();
            List<int> newOrder = songOrder.ToList();
            for (int i = 0; i < songOrder.Count; i++)
            {
                newOrder.Remove(i);
                newOrder.Insert(random.Next(songOrder.Count), i);
            }

            songOrder = newOrder;
            shuffled = true;
        }
        public void unShuffle()
        {
            songOrder.Sort();
        }
        public bool isShuffled()
        {
            return shuffled;
        }

        public bool addSong(Song song)
        {
            if (!songs.Contains(song))
            {
                if (shuffled)
                {
                    unShuffle();
                }
                songs.Add(song);
                songOrder.Add(songOrder.Count);
                song.addPlaylist(this);
                return true;
            }
            return false;
        }
        public bool removeSong(Song song)
        {
            if (songs.Contains(song))
            {
                song.removePlaylist(this);
                return true;
            }
            return false;
        }

        public void play(int index)
        {
            SongPlayer.PlaySong(songs[songOrder[index]]);
        }

        public void delete()
        {
            foreach (Song song in songs)
            {
                song.removePlaylist(this);
            }
            openIds.Add(id);
        }

        public List<Song> getSongs()
        {
            return songs.ToList();
        }
        public Song getSong(int index)
        {
            return songs[index];
        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public static void setCount(int count)
        {
            Playlist.count = count;
        }
        public int getLength()
        {
            return songs.Count;
        }
        public bool contains(Song song)
        {
            return songs.Contains(song);
        }
        public int getRelativeIndex(int index)
        {
            return songOrder.IndexOf(index);
        }
    }
}
