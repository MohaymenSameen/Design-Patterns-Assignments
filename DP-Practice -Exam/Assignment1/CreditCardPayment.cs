﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class CreditCardPayment:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("processing CreditCard payment...");
        }
    }
}
