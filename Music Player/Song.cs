using System;
using System.CodeDom.Compiler;
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
        private static uint count = 0;
        private static OpenFileDialog openFileDialog = new OpenFileDialog();
        private static List<uint> openIds = new List<uint>();
        public Song(string name, string path, string artist, uint id)
        {
            this.name = name;
            this.path = path;
            this.artist = artist;
            this.id = id;
        }
        public static Song? CreateSong()
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

        public static uint getCount()
        {
            return count;
        }
        public uint getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getPath() 
        { 
            return path; 
        }
        public string getArtist()
        {
            return artist;
        }
        public void updateName()
        {
            string[] temp = new string[1];
            temp[0] = name;
            GetStringForm gsf = new GetStringForm("New name for " + name + ":", ref temp);
            gsf.ShowDialog();
            name = temp[0];
        }
        public void delete()
        {
            openIds.Append(id);
            openIds.Sort();
        }

        public static List<uint> getOpenIds()
        {
            return new List<uint>(openIds.ToArray());
        }

    }
}
