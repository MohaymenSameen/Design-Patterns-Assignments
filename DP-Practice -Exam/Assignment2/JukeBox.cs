using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class JukeBox
    {
        public List<IVinylSingle> Singles { get; set; }
        public IVinylSingle CurrentSingle { get; set; }

        public JukeBox(List<IVinylSingle> singles)
        {
            Singles = singles;            
        }
        public void Play()
        {
            CurrentSingle.Play();
        }
        public void SelectSingle(int index)
        {
            CurrentSingle = Singles[index-1];            
        }
        public void Stop()
        {
            CurrentSingle.Stop();
        }
    }
}
