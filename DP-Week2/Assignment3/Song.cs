using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Song
    {
        public string title;
        public string band;
        public int minutes;
        public int seconds;

        public Song(string title, string band, int minutes,int seconds)
        {
            this.title = title;
            this.band = band;
            this.minutes = minutes;
            this.seconds = seconds;
        }
    }
}
