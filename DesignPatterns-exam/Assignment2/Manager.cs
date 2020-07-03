using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Manager:Employee
    {
        public Manager(string name):base(name)
        {            
            PaymentMethod = new CreditCardPayment();            
        }
    }
}
