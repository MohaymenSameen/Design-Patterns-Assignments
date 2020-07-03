using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Accountant:Employee
    {
        public Accountant(string name):base(name)
        {
            PaymentMethod = new IdealPayment();            
        }
    }
}
