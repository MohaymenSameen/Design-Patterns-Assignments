using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class MP3Player : IObservable
    {
        public Song CurrentSong { get; private set; }
        private List<IObserver> observers = new List<IObserver>();
        
        public void NextSong()
        {
            List<Song> songs = new List<Song>();
            songs.Add(new Song("Wish You Were Here", "Pink Floyd", 3, 12));
            songs.Add(new Song("Dazed and Confused", "Led Zeppelin", 4, 0));
            songs.Add(new Song("Billionaire", "Bruno Mars", 3, 33));

            Random rnd = new Random();
            int randomSong = rnd.Next(songs.Count);
            CurrentSong = songs[randomSong];
            
            foreach (IObserver observer in observers)
            {
                observer.Update(CurrentSong);
            }
           
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
