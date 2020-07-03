using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public abstract class Employee:IPaymentMethod
    {
        private string name;
        public IPaymentMethod PaymentMethod { get; set; }

        public Employee(string name)
        {
            this.name = name;
            PaymentMethod = null;
        }
        public void Pay(float amount)
        {
            PaymentMethod.Pay(amount);
        }
    }
}
