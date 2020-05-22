using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }
        void Start()
        {
            Console.WriteLine("[shop creating expensive computers]");
            ComputerFactory highBudgetFactory = new HighBudgetFactory();
            ComputerShop highBudgetShop = new ComputerShop();
            highBudgetShop.AssembleMachine(highBudgetFactory);

            Console.WriteLine();            
            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory lowBudgetFactory = new LowBudgetFactory();
            ComputerShop lowBudgetShop = new ComputerShop();
            lowBudgetShop.AssembleMachine(lowBudgetFactory);

            Console.ReadKey();
        }
    }
}
