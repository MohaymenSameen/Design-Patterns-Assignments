using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Album:IVinylAlbum
    {
        public string Band { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public Album(string band, string title, int year)
        {
            Band = band;
            Title = title;
            Year = year;
        }
        public void Pause()
        {
            Console.WriteLine("pausing an album {0}",ToString());
        }
        public void Play()
        {
            Console.WriteLine("playing an album {0}",ToString());
        }
        public void Stop()
        {
            Console.WriteLine("stopping an album {0}",ToString());
        }
        public override string ToString()
        {
            return String.Format("playing album '{0}, {1} {2}'",Title,Band,Year);
        }
    }
}
