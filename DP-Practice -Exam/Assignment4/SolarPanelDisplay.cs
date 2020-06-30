using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class SolarPanelDisplay:IObserver
    {
        private IObservable system;

        public SolarPanelDisplay(IObservable system)
        {
            this.system = system;
            system.AddObserver(this);
        }
        public void Update(int power)
        {
            Console.WriteLine("new measurement: {0} watt", power);
        }
    }
}
