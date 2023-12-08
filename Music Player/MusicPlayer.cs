using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public partial class MusicPlayer
    {
        private List<Song> songs;
        private List<Song> searchedSongs;
        private List<Playlist> playlists;
        public MusicPlayer()
        {
            songs = new List<Song>();
            searchedSongs = new List<Song>();
            playlists = new List<Playlist>();
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
                    Song.setCount(int.Parse(sr.ReadLine()!));
                    int lastId = -1;
                    string holder = sr.ReadLine()!;
                    while(holder != "??PLAYLISTS??" && !sr.EndOfStream)
                    {
                        string name = sr.ReadLine()!;
                        string artist = sr.ReadLine()!;
                        int id = int.Parse(sr.ReadLine()!);
                        newSongs.Add(new Song(name, holder, artist, id));
                        while(id - lastId > 1)
                        {
                            lastId++;
                            Song.addUnusedId(lastId);
                        }
                        lastId++;
                        holder = sr.ReadLine()!;
                    }
                    if(!sr.EndOfStream)
                    {
                        Playlist.setCount(int.Parse(sr.ReadLine()!));
                        lastId = -1;
                        while(!sr.EndOfStream)
                        {
                            string name = sr.ReadLine()!;
                            int id = int.Parse(sr.ReadLine()!);
                            Playlist playlist = new Playlist(name, id);
                            int count = int.Parse(sr.ReadLine()!);
                            for(int i = 0; i < count; i++)
                            {
                                playlist.addSong(getSong(getTrueIndex(int.Parse(sr.ReadLine()!))));
                            }
                        }
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
                Song song = Song.CreateSong()!;
                if (song == null)
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

        public void play(int index)
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
                        sw.WriteLine(song.getTitle());
                        sw.WriteLine(song.getArtist());
                        sw.WriteLine(song.getId());
                    }
                    sw.WriteLine("??PLAYLISTS??");
                    foreach(Playlist playlist in playlists)
                    {
                        sw.WriteLine(playlist.getName());
                        sw.WriteLine(playlist.getId());
                        sw.WriteLine(playlist.getLength());
                        foreach(Song song in playlist.getSongs())
                        {
                            sw.WriteLine(song.getId());
                        }
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

        public void play(int playlistIndex, int startIndex)
        {
            playlists[playlistIndex].play(startIndex);
        }
        public Song getSong(int playlistIndex, int songIndex)
        {
            return playlists[playlistIndex].getSong(songIndex);
        }
        public bool addPlaylist()
        {
            Playlist playlist = Playlist.createPlaylist();
            if(playlist != null)
            {
                playlists.Insert(playlist.getId(), playlist);
                return true;
            }
            return false;
        }
        public bool removePlaylist(int index)
        {
            try
            {
                playlists[index].delete();
                playlists.RemoveAt(index);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Deleting Playlist: " + ex.Message);
                return false;
            }
        }

        public Playlist getPlaylist(int index)
        {
            return playlists[index];
        }
        public int getPlaylistCount()
        {
            return playlists.Count;
        }
    }
}
