using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class BatchProcessor
    {
        private List<BigDataLoader> dataLoaders; 
        public BatchProcessor()
        {
            dataLoaders = new List<BigDataLoader>();
        }
        public List<BigDataLoader> addData(BigDataLoader data)
        {
            dataLoaders.Add(data);
            return dataLoaders;
        }
        public void displayData()
        {
            foreach (BigDataLoader item in dataLoaders)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ETL-process Started]");
                Console.ResetColor();
                item.ETL();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ETL-process Finished]");
                Console.ResetColor();
                Console.WriteLine();                
            }
        }
    }
}
