using System;

namespace mediaPlayersystem
{
    public interface IMediaPlayer 
    {
        void Play();
        void Pause();
        void Stop();
    }

    public class MediaPlayer : IMediaPlayer
    {
        public string MediaType { get; set; }

        public MediaPlayer(string mediaType)
        {
            MediaType = mediaType;
        }

        public virtual void Play()
        {
            Console.WriteLine("Playing media.");
        }

        public virtual void Pause()
        {
            Console.WriteLine("Media paused.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Media stopped.");
        }
    }

    public class AudioPlayer : MediaPlayer
    {
        public string AudioFormat { get; set; }

        public AudioPlayer(string audioFormat) : base("Audio")
        {
            this.AudioFormat = audioFormat;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing Audio in {AudioFormat} Format");
        }

        public override void Pause()
        {
            Console.WriteLine("Audio paused.");
        }

        public override void Stop()
        {
            Console.WriteLine("Audio stopped.");
        }
    }

    public class VideoPlayer : MediaPlayer
    {
        public string Resolution { get; set; }

        public VideoPlayer(string resolution) : base("Video")
        {
            this.Resolution = resolution;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing video in {Resolution} resolution.");
        }

        public override void Pause()
        {
            Console.WriteLine("Video paused.");
        }

        public override void Stop()
        {
            Console.WriteLine("Video stopped.");
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("\n\"Media PLayer System\"\n");

            IMediaPlayer audioPlayer = new AudioPlayer("Mp3");
            audioPlayer.Play();
            audioPlayer.Pause();
            audioPlayer.Stop();

            Console.WriteLine(" ");

            IMediaPlayer videoPlayer = new VideoPlayer("1080");
            videoPlayer.Play();
            videoPlayer.Pause();
            videoPlayer.Stop();

            Console.ReadLine();

        }
    }
}