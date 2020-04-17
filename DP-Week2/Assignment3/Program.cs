using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }
        void Start()
        {
            // create an MP3 player
            IObservable player = new MP3Player();
            // create the displays
            IObserver mp3Display1 = new SimpleMP3Display(player);
            IObserver mp3Display2 = new FancyMP3Display(player);
            // change song a few times
            // (since there is no hardware, we do it hardcoded here...)
            player.NextSong();
            player.NextSong();
            player.NextSong();
            Console.ReadKey();
        }
    }
}
