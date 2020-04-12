using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Pencil : IPencil
    {
        private int maxToWrite;
        private int nrOfCharsWritten;
        private bool canWrite;
        public bool CanWrite { get { return canWrite; } }

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
                if (nrOfCharsWritten > maxToWrite)
                {
                    canWrite = false;
                    word += "#";
                }
                else
                {
                    word += c;
                    canWrite = true;
                }              
                nrOfCharsWritten++;
            }            
            Console.WriteLine(word);
        }
        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
            canWrite = true;
        }
    }
}
