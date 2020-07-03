using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public abstract class DataProcessor
    {
        public void ProcessData()
        {
            ReadData();
            FilterData();
            WriteData();
        }
        public abstract void ReadData();
        public abstract void FilterData();
        public void WriteData()
        {
            Console.WriteLine("writing data to CSV...");
        }
        
    }
}
