using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class ClockController:IClockController
    {
        private IClockSystem system;
        public ClockController(IClockSystem system)
        {
            this.system = system;
        }
        public void UpdateDateTime()
        {
            system.UpdateDateTime();
        }
    }
}
