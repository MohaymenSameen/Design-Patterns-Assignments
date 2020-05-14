using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class CardPresentState : IATMState
    {
        private ATMMachine machine;
        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void InsertCard()
        {
            Console.WriteLine("Please enter your pincode");
        }
        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
        }
        public void EnterPincode(int pincode)
        {
            Console.WriteLine("You have entered the correct pincode.");
        }
        public void WithdrawCash(int amount)
        {
            //amount - machine amount
            Console.WriteLine("{0} withdrawn from machine.", amount);
            //if money in machine or not
        }
    }
}
