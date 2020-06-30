using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class SingleAdapter :IVinylSingle
    {
        private IVinylAlbum album;
        public SingleAdapter(IVinylAlbum album)
        {
            this.album = album;
        }
        public void Pause()
        {
            album.Pause();
        }
        public void Play()
        {
            album.Play();
        }       
        public void Stop()
        {
            album.Stop();
        }
        public override string ToString()
        {
            return album.ToString();
        }
    }
}
