using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public abstract class Payment
    {
        public void Execute()
        {
            EnterInformation();
            ProcessPayment();
            ConfirmPayment();
        }
        public void EnterInformation()
        {
            Console.WriteLine("entering information...");
        }
        public abstract void ProcessPayment();
        public void ConfirmPayment()
        {
            Console.WriteLine("sending confirmation mail...");
        }
        
    }
}
