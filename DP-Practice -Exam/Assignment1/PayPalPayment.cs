using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class PayPalPayment:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("processing PayPal payment...");
        }
    }
}
