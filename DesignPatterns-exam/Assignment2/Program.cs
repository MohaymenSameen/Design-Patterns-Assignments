using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Employee manager = new Manager("Steven Spielberg");
            manager.Pay(850.0f);

            Employee accountant = new Accountant("George Lucas");
            accountant.Pay(430.00f);

            // change payment method of accountant
            accountant.PaymentMethod = new PayPalPayment();
            accountant.Pay(179.50f);

            Console.ReadKey();
        }
    }
}
