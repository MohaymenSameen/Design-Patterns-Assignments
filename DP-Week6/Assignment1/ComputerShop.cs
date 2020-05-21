using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class ComputerShop
    {
        public ComputerShop AssembleMachine()
        {
            IProcessor processor;
            processor = pro
        }
        public virtual CheapHardDisk MakeCheapHardDisk() { return new CheapHardDisk(); }
        public virtual CheapMonitor MakeCheapMonitor() { return new CheapMonitor(); }
        public virtual CheapProcessor MakeCheapProcessor() { return new CheapProcessor(); }
        public virtual ExpensiveHardDisk MakeExpensiveHardDisk() { return new ExpensiveHardDisk(); }
        public virtual ExpensiveMonitor MakeExpensiveMonitor() { return new ExpensiveMonitor(); }
        public virtual ExpensiveProcessor MakeExpensiveProcessor() { return new ExpensiveProcessor(); }
    }
}
