using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class HighBudgetShop : ComputerShop
    {
        public override ExpensiveHardDisk MakeExpensiveHardDisk()
        {
            return new ExpensiveHardDisk();
        }
        public override ExpensiveMonitor MakeExpensiveMonitor()
        {
            return new ExpensiveMonitor();
        }
        public override ExpensiveProcessor MakeExpensiveProcessor()
        {
            return new ExpensiveProcessor();
        }
    }
}
