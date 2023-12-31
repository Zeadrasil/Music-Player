using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;

namespace Music_Player
{
    public partial class SongPlayer
    {
        private readonly  ISoundOut soundOut = new WasapiOut() { Latency = 100 };
        private  Song? playingSong;

        public  void StopSong()
        {
            soundOut.Stop();
            soundOut.WaveSource?.Dispose();
            playingSong = null;
        }

        public  void CloseApp()
        {
            StopSong();
            soundOut.Dispose();
        }

        public  void PauseSong()
        {
            soundOut.Pause();
        }

        public  void ResumeSong()
        {
            soundOut.Resume();
        }
        /// <summary>
        /// Seeks the currently playing song to the time provided. Throws error if no song is playing or if time is greater than playing song.
        /// </summary>
        /// <param name="time">The time to seek to</param>
        /// <exception cref="NotPlayingAudio"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public  void SeekToTime(TimeSpan time)
        {
            if (soundOut.PlaybackState == PlaybackState.Stopped)
                throw new Exception("Tried to seek to time when music was stopped!");
            if (soundOut.WaveSource.GetLength().CompareTo(time) < 0)
                throw new ArgumentOutOfRangeException($"Time provided ({time}) is longer than the playing song ({soundOut.WaveSource.GetLength()})!");

            soundOut.WaveSource.SetPosition(time);
        }

        /// <summary>
        /// Seeks the currently playing song to the time provided. Throws error if no song is playing or if time is greater than playing song.
        /// </summary>
        /// <param name="time">The time to seek to</param>
        /// <exception cref="NotPlayingAudio"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public  void SeekToTimeSec(double seconds)
        {
            SeekToTime(TimeSpan.FromSeconds(seconds));
        }

        /// <summary>
        /// Seeks the currently playing song to the time provided. Throws error if no song is playing or if time is greater than playing song.
        /// </summary>
        /// <param name="time">The time to seek to</param>
        /// <exception cref="NotPlayingAudio"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public  void SeekToTimeMS(int milliseconds)
        {
            SeekToTime(TimeSpan.FromMilliseconds(milliseconds));
        }

        /// <summary>
        /// <paramref name="volume"/> must be greater than or equal to zero and less than or equal to 1.
        /// </summary>
        /// <param name="volume"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="volume">The volume to set</param>
        public  void SetVolume(float volume)
        {
            if (volume > 1.0f || volume < 0.0f)
                throw new ArgumentOutOfRangeException("Volume must be greater than or equal to zero and less than or equal to 1! Was => " + volume);

            soundOut.Volume = volume;
        }

        /// <summary>
        /// Plays <paramref name="song"/>
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception> 
        /// <param name="song">The song to play</param>
        public  void PlaySong(Song song)
        {
            if (song == null)
                throw new ArgumentNullException(nameof(song));
            else if (string.IsNullOrEmpty(song.getPath()))
                throw new ArgumentNullException(song.ToString());
            else if (soundOut.PlaybackState == PlaybackState.Playing || soundOut.PlaybackState == PlaybackState.Paused)
                StopSong();
            try
            {
                IWaveSource waveSource = CodecFactory.Instance.GetCodec(song.getPath()).ToSampleSource().ToStereo().ToWaveSource();
                soundOut.Initialize(waveSource);
                soundOut.Play();
                playingSong = song;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing song: \n" +  ex.Message + "\nMost likely solution is to ensure file path of song is valid.\nSong: " + song.getTitle() + " - " + song.getArtist() + "\nCurrent Path: " + song.getPath());
            }
        }

        public  PlaybackState GetPlaybackState()
        {
            return soundOut.PlaybackState;
        }

        public  Song? getPlayingSong()
        {
            return playingSong;
        }
        public  int getLength()
        {
            return (int)Extensions.GetLength(soundOut.WaveSource).TotalMilliseconds;
        }
        public  int getPosition()
        {
            return (int)Extensions.GetPosition(soundOut.WaveSource).TotalMilliseconds;
        }
    }
}