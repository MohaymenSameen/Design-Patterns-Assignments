using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class CorrectPinState : IATMState
    {
        private ATMMachine machine;
        public CorrectPinState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void InsertCard()
        {
            Console.WriteLine("Please enter your pincode");
            Console.WriteLine();
        }
        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            Console.WriteLine();
        }
        public void EnterPincode(int pincode)
        {
            Console.WriteLine("You have entered the correct pincode.");
            Console.WriteLine();
        }
        public void WithdrawCash(int amount)
        {
            if (machine.AmountInMachine<=0)
            {
                Console.WriteLine("Not enough cash available in machine.");
                machine.SetMachineState(machine.GetNoCashState());
                Console.WriteLine();
            }
            else
            {
                int remainingAmount = machine.AmountInMachine - amount;
                Console.WriteLine("{0} withdrawn from machine. {1}", amount,remainingAmount);
                Console.WriteLine();
            }
        }
    }
}
