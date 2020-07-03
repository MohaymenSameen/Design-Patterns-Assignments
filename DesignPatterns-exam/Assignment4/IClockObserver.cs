using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public interface IClockObserver
    {
        public void Update(DateTime currentTime);
    }
}
