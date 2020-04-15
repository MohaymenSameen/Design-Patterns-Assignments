using System;
using System.Collections.Generic;

namespace Assignment1
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
            BatchProcessor processor = new BatchProcessor();
            
            CallDataLoader callData = new CallDataLoader();
            TwitterDataLoader twitterData = new TwitterDataLoader();
            SensorDataLoader sensorData = new SensorDataLoader();

            processor.addData(callData);
            processor.addData(twitterData);
            processor.addData(sensorData);

            processor.displayData();
            
            Console.ReadKey();
        }
    }
}
