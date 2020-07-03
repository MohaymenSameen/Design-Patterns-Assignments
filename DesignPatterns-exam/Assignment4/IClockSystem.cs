using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public interface IClockSystem
    {
        public void AddObserver(IClockObserver observer);
        public void RemoveObserver(IClockObserver observer);
        public void UpdateDateTime();
    }
}
