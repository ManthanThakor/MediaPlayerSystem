using System;

namespace mediaPlayersystem
{
    public interface IMediaPlayer 
    {
        void Play();
        void Pause();
        void Stop();
    }

    public class 

    public class AudioPlayer : IMediaPlayer
    {
        public string AudioFormat { get; set; }

        public AudioPlayer(string audioFormat)
        {
            this.AudioFormat = audioFormat;
        }

        public void Play()
        {
            Console.WriteLine($"Playing  audio in {AudioFormat} Format");
        }

        public void Pause()
        {
            Console.WriteLine("Audio paused.")
        }

        public void Stop()
        {
            Console.WriteLine("Video stopped.");
        }
    }

    public class VideoPlayer : IMediaPlayer
    {
        public string VideoFormat { get; set; }

    }

    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("\n\"Media PLayer System\"\n");

            Console.ReadLine();

        }
    }
}