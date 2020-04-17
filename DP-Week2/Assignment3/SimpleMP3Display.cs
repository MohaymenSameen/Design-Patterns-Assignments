using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class SimpleMP3Display : IObserver
    {        
        public SimpleMP3Display(IObservable player)
        {            
            player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine("Simple display: {0} - '{1}'",song.band,song.title);
        }
    }
}
