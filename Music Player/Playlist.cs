﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    internal class Playlist
    {
        private List<Song> songs;
        private List<int> songOrder;
        private string name;
        private bool shuffled = false;
        private int id;
        private static int count;
        private static List<int> openIds = new List<int>();
        private bool overrideCheck = false;
        public Playlist(string name, int id)
        {
            this.name = name;
            this.id = id;
            songs = new List<Song>();
            songOrder = new List<int>();
        }

        public static Playlist? createPlaylist()
        {
            string[] name = new string[1];
            name[0] = "";
            GetStringForm gsf = new GetStringForm("What is the name of the new playlist?", ref name);
            gsf.ShowDialog();
            if (name[0] != "")
            {
                int id = count;
                if(openIds.Count > 0)
                {
                    id = openIds[0];
                    openIds.RemoveAt(0);
                }
                return new Playlist(name[0], id);
            }
            return null;
        }
        public void shuffle()
        {
            Random random = new Random();
            List<int> newOrder = songOrder.ToList();
            for(int i = 0; i < songOrder.Count; i++) 
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
            if(!songs.Contains(song)) 
            { 
                if(shuffled)
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
            if(songs.Contains(song))
            {
                song.removePlaylist(this);
                return true;
            }
            return false;
        }

        public void play(int startIndex)
        {
            overrideCheck = true;
            Thread.Sleep(250);
            bool firstRound = true;
            for(int i = (startIndex == -1) ? 0 : songOrder.IndexOf(startIndex); i < songOrder.Count; i++)
            {
                SongPlayer.PlaySong(songs[songOrder[i]]);
                while(SongPlayer.GetPlaybackState() == CSCore.SoundOut.PlaybackState.Paused || SongPlayer.GetPlaybackState() == CSCore.SoundOut.PlaybackState.Playing)
                {
                    if(overrideCheck)
                    {
                        if(firstRound)
                        {
                            firstRound = false;
                        }
                        else
                        {
                            return;
                        }
                    }
                    overrideCheck = false;
                    Thread.Sleep(500);
                }
            }
        }

        public void delete()
        {
            foreach(Song song in songs)
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
    }
}
