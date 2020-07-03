using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class DbDataProcessor:DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("reading data from database...");
        }
        public override void FilterData()
        {
            Console.WriteLine("filtering data from database...");
        }
    }
}
