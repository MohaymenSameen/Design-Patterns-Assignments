using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            // create clock system
            IClockSystem clockSystem = new ClockSystem();

            // create controller
            IClockController controller = new ClockController(clockSystem);

            // create some displays
            IClockObserver display1 = new ClockDisplay(clockSystem);
            IClockObserver display2 = new ClockDisplay(clockSystem);
            IClockObserver display3 = new ClockDisplay(clockSystem);

            // update clock system a few times (for testing)
            controller.UpdateDateTime();
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            controller.UpdateDateTime();
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            controller.UpdateDateTime();

            Console.ReadKey();
        }
    }
}
