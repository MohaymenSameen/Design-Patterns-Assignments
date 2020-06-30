using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class CopyingMachine
    {
        private int totalNumberOfCopies;
        public int TotalNumberOfCopies { get { return totalNumberOfCopies; } set { } }
        private static CopyingMachine uniqueInstance;

        public CopyingMachine()
        {
            totalNumberOfCopies = 0;
        }
        public void Copy(int copies)
        {
            Console.WriteLine("copying,{0}x", copies);
            totalNumberOfCopies += copies;
            Console.WriteLine("total number of copies: {0}", totalNumberOfCopies);            
        }
        public static CopyingMachine GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new CopyingMachine();
            }
            return uniqueInstance;
        }
    }
}
