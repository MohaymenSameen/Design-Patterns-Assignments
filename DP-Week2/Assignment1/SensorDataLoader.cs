using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class SensorDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("extracting sensor data...");
        }
        public override void Transform()
        {
            Console.WriteLine("transforming sensor data...");
        }
        public override void Load()
        {
            Console.WriteLine("loading sensor data...");
        }
    }
}
