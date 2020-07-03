using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class ClockDisplay:IClockObserver
    {
        private IClockSystem system;
        private int count;
        public ClockDisplay(IClockSystem system)
        {
            this.system = system;
            count = 0;
            system.AddObserver(this);
        }
        public void Update(DateTime currentTime)
        {
            count++;
            Console.WriteLine("Display {0} current time: {1}", count,currentTime);
        }
    }
}
