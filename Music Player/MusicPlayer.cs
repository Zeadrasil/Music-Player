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
        private List<Song> searchedSongs;
        public MusicPlayer()
        {
            songs = new List<Song>();
            searchedSongs = new List<Song>();
        }

        public bool load()
        {
            try
            {
                List<Song> newSongs = new List<Song>();
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Text Files |*.txt";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFile.FileName);
                    Song.setCount(int.Parse(sr.ReadLine()));
                    int lastId = -1;
                    while(!sr.EndOfStream)
                    {
                        string path = sr.ReadLine();
                        string name = sr.ReadLine();
                        string artist = sr.ReadLine();
                        int id = int.Parse(sr.ReadLine());
                        newSongs.Add(new Song(name, path, artist, id));
                        while(id - lastId > 1)
                        {
                            lastId++;
                            Song.addUnusedId(lastId);
                        }
                        lastId++;
                    }
                    songs = newSongs;
                    clearSearch();
                    sr.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading song data: " + ex.Message);
            }
            return false;
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
                searchedSongs.Remove(songs[trueIndex]);
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
            for (int i = 0; i < index && i < Song.getOpenIds().Count && Song.getOpenIds()[i] < index; i++)
            {
                trueIndex--;
            }
            return trueIndex;
        }

        public void search(string term)
        {
            List<Song> newSongs = new List<Song>();
            foreach(Song song in searchedSongs)
            {
                if(song.fitsSearchParams(term))
                {
                    newSongs.Add(song);
                }
            }
            searchedSongs = newSongs;
        }
        public void clearSearch()
        {
            searchedSongs = new List<Song>(songs.ToArray());
        }

        public bool save()
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text File |*.txt";
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFile.FileName);
                    sw.WriteLine(Song.getCount());
                    foreach(Song song in songs)
                    {
                        sw.WriteLine(song.getPath());
                        sw.WriteLine(song.getName());
                        sw.WriteLine(song.getArtist());
                        sw.WriteLine(song.getId());
                    }
                    sw.Close();
                    return true;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
            return false;
        }

        public int getActiveSongCount()
        {
            return searchedSongs.Count;
        }
        public Song getSong(int index)
        {
            return searchedSongs[index];
        }
    }
}
