using CSCore;
using CSCore.Codecs;
using CSCore.XAudio2;

namespace Music_Player
{
    internal static class SongPlayer
    {
        /// <summary>
        /// If is null, no song is playing
        /// </summary>
        private static string? pathOfPlayingSong = null;

        /// <summary>
        /// isPaused is true if the SongPlayer would be able to resume from the last track played.
        /// </summary>
        public static bool IsPaused { get; private set; } = true;
        public static bool IsStopped { get; private set; } = true;
        static readonly XAudio2 xaudio2 = XAudio2.CreateXAudio2();
        static readonly XAudio2MasteringVoice masteringVoice = xaudio2.CreateMasteringVoice();
        static StreamingSourceVoice? streamingSourceVoice;

        public static void SetVolume(float volume)
        {
            masteringVoice.Volume = volume;
        }

        private static void PlayThreadedSong(Song song)
        {
            //this code was copied then heavily modified from https://github.com/filoe/cscore/blob/master/Samples/XAudio2Playback/Program.cs 

            //TODO: Add checks to see if song is already playing

            using IWaveSource source = CodecFactory.Instance.GetCodec(song.getPath());
            streamingSourceVoice = new StreamingSourceVoice(xaudio2, source);
            StreamingSourceVoiceListener.Default.Add(streamingSourceVoice);
            streamingSourceVoice.Start();

            //TODO: Rewrite so that song can be affected outside of this (different than main) thread
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
            Thread.Sleep(10000);
            StreamingSourceVoiceListener.Default.Remove(streamingSourceVoice);
            streamingSourceVoice.Stop();
            /* Thread.Sleep(1000);
            StreamingSourceVoiceListener.Default.Add(streamingSourceVoice);
            streamingSourceVoice.Start(); */
        }

        public static void PlaySong(Song song)
        {
            if (song is null)
                throw new ArgumentNullException(nameof(song));
            else if (string.IsNullOrEmpty(song.getPath()))
                throw new ArgumentNullException();
            
            pathOfPlayingSong = song.getPath();
            //TODO: Add check to see if task already exists and handle it.
            Task.Factory.StartNew(() => PlayThreadedSong(song));
        }
    }
}