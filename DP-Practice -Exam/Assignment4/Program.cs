using System;

namespace Assignment4
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
            // create solarpanel system
            IObservable systeem = new SolarPanelSystem();

            // create a controller
            IPanelController controller = new PanelController(systeem);

            // create a solarpanel display
            IObserver display = new SolarPanelDisplay(systeem);

            // perform a few measurements
            for (int i = 0; i < 10; i++)
                controller.NewMeasurement();

            
            Console.ReadKey();
        }
    }
}
