using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class ComputerFactory
    {
        public virtual IHardDisk MakeHardDisk() { return new CheapHardDisk(); }
        public virtual IMonitor MakeMonitor() { return new CheapMonitor(); }
        public virtual IProcessor MakeProcessor() { return new CheapProcessor(); }
    }
}
