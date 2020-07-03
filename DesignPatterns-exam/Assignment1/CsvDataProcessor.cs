using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class CsvDataProcessor:DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("reading data from CSV-file...");
        }
        public override void FilterData()
        {
            Console.WriteLine("filtering data from CSV-file...");
        }
    }
}
