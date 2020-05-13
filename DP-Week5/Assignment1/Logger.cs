using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Logger
    {
        private int numberOfLines;
        private static Logger uniqueInstance;        
        private Logger()
        {            
            numberOfLines = 1;
        }
        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }
            return uniqueInstance;
        }
        public void Log(string system, string message)
        {
            Console.WriteLine("{0} - [{1}] {2}", numberOfLines, system, message);
            numberOfLines++;
        }      
    }
}
