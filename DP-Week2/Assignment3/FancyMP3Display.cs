using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class FancyMP3Display : IObserver
    {        
        public FancyMP3Display(IObservable player)
        {            
            player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine("Fancy display: '{0}' by {1} ({2:0}:{3:0})", song.title, song.band,song.minutes,song.seconds);
        }
    }
}
