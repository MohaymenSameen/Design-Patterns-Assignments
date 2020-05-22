using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class LowBudgetShop : ComputerShop
    {
        public override CheapHardDisk MakeCheapHardDisk()
        {
            return new CheapHardDisk();
        }
        public override CheapMonitor MakeCheapMonitor()
        {
            return new CheapMonitor();
        }
        public override CheapProcessor MakeCheapProcessor()
        {
            return new CheapProcessor();
        }
    }
}
