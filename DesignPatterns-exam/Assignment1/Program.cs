using System;

namespace Assignment1
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
            Console.WriteLine("[csv data]");
            DataProcessor csvProcessor = new CsvDataProcessor();
            csvProcessor.ProcessData();

            Console.WriteLine();

            Console.WriteLine("[database data]");
            DataProcessor dbProcessor = new DbDataProcessor();
            dbProcessor.ProcessData();

            Console.ReadKey();
        }
    }
}
