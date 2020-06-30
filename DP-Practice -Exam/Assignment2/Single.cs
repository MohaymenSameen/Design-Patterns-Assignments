using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Single:IVinylSingle
    {
        public string Artist { get; set; }
        public int Ranking { get; set; }
        public string Title { get; set; }

        public Single(int ranking, string title, string artist)
        {
            Artist = artist;
            Ranking = ranking;
            Title = title;
        }
        public void Pause()
        {
            Console.WriteLine("pausing a single {0}",ToString());
        }
        public void Play()
        {
            Console.WriteLine("playing a single {0}",ToString());
        }
        public void Stop()
        {
            Console.WriteLine("stopping a single {0}",ToString());
        }
        public override string ToString()
        {
            return String.Format("playing single '{0}, {1} {2}'", Title, Artist, Ranking);
        }
    }
}

