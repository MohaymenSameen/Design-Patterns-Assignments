using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Pencil : IPencil
    {
        private int maxToWrite;
        private int nrOfCharsWritten;        
        public bool CanWrite { get { return nrOfCharsWritten < maxToWrite; } }

        public Pencil()
        {
            maxToWrite = 20;
            nrOfCharsWritten = 0;
        }
        public void Write(string message)
        {
            string word = "";
            foreach (Char c in message)
            {
                if (!CanWrite)
                {                    
                    word += "#";
                }
                else
                {
                    word += c;                    
                }              
                nrOfCharsWritten++;
            }            
            Console.WriteLine(word);
        }
        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;            
        }
    }
}
