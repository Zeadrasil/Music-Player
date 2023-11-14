using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    internal class Song
    {
        private string name;
        private string path;
        private string artist;
        private uint id;
        public static uint count = 0;
        private static OpenFileDialog openFileDialog = new OpenFileDialog();
        private static List<uint> openIds = new List<uint>();
        public Song(string name, string path, string artist, uint id)
        {
            this.name = name;
            this.path = path;
            this.artist = artist;
            this.id = id;
        }
        public static Song CreateSong()
        {
            openFileDialog.Filter = "Audio Files | *.mp3 | *.FLAC | *.AAC | *.WMA | *.AC3 | *.PCM | *.GSM | *.wav";
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
                uint id = count;
                if(openIds.Count > 0) 
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
    }
}
