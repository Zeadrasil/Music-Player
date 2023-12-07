using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using TagLib.Flac;

namespace Music_Player
{
    public partial class Song
    {
        private string? title;
        private string path;
        private string? artist;
        private Image? coverArt;
        private int id;
        private static int count = 0;
        private static OpenFileDialog openFileDialog = new OpenFileDialog();
        private static List<int> openIds = new List<int>();
        private List<Playlist> playlists;
        public Song(string path, int id) : this(null!, path, null!, id) { }
        public Song(string title, string path, string artist, int id)
        {
            this.title = title;
            this.path = path;
            this.artist = artist;
            this.id = id;
            playlists = new List<Playlist>();
        }
        public static Song? CreateSong()
        {
            openFileDialog.Filter = "Audio Files |*.mp3||*.FLAC||*.AAC||*.WMA||*.AC3||*.PCM||*.GSM||*.wav";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] name = new string[1];
                name[0] = openFileDialog.FileName.Split('/').Last();
                string path = openFileDialog.FileName;
                string[] artist = new string[1];
                artist[0] = "";
                GetStringForm gsf = new GetStringForm("Please enter the song name", ref name);
                gsf.ShowDialog();
                gsf = new GetStringForm("Please enter the artist name", ref artist);
                gsf.ShowDialog();
                int id = count;
                if (openIds.Count > 0)
                {
                    id = openIds[0];
                    openIds.RemoveAt(0);
                }
                else
                {
                    count++;
                }
                return new Song(name[0], path, artist[0], id);
            }
            return null;
        }

        public static int getCount()
        {
            return count;
        }
        public int getId()
        {
            return id;
        }
        public string getTitle()
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                title = TagLib.File.Create(path).Tag.Title;
                if (string.IsNullOrWhiteSpace(title))
                    throw new Exception($"\"{path}\" does not have a valid title!");
                return title;
            }
            return title;
        }
        public string getPath()
        {
            return path;
        }
        public string getArtist()
        {
            if (string.IsNullOrWhiteSpace(artist))
            {
                artist = TagLib.File.Create(path).Tag.FirstAlbumArtist;
                if (string.IsNullOrWhiteSpace(title))
                    throw new Exception($"\"{path}\" does not have a valid artist!");
                return artist;
            }
            return artist;
        }

        public void updateName()
        {
            string[] temp = new string[1];
            temp[0] = title;
            GetStringForm gsf = new GetStringForm("New name for " + title + ":", ref temp);
            gsf.ShowDialog();
            title = temp[0];
        }
        public void updateArtist()
        {
            string[] temp = new string[1];
            temp[0] = artist;
            GetStringForm gsf = new GetStringForm("New artist for " + title + ":", ref temp);
            gsf.ShowDialog();
            artist = temp[0];
        }
        public void updatePath()
        {
            openFileDialog.FileName = path;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
        }
        public void delete()
        {
            openIds.Add(id);
            openIds.Sort();
            while (playlists.Count > 0)
            {
                playlists[0].removeSong(this);
                playlists.RemoveAt(0);
            }
        }

        public static List<int> getOpenIds()
        {
            return new List<int>(openIds.ToArray());
        }
        public bool fitsSearchParams(string searchParams)
        {
            return getTitle().ToLower().Contains(searchParams.ToLower()) || getArtist().ToLower().Contains(searchParams.ToLower());
        }
        public static void setCount(int newCount)
        {
            count = newCount;
        }

        public static void addUnusedId(int id)
        {
            openIds.Add(id);
        }
        public bool addPlaylist(Playlist playList)
        {
            if (playlists.Contains(playList))
            {
                return false;
            }
            playlists.Add(playList);
            return true;
        }
        public bool removePlaylist(Playlist playList)
        {
            if (playlists.Contains(playList))
            {
                playlists.Remove(playList);
                return true;
            }
            return false;
        }
    }
}
