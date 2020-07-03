using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class IdealPayment:IPaymentMethod
    {
        public void Pay(float amount)
        {
            Console.WriteLine("Amount {0:0.00} is payed using iDEAL.",amount);
        }
    }
}
