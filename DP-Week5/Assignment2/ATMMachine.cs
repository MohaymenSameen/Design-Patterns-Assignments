using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class ATMMachine
    {
        private int amountInMachine;
        private IATMState cardPresent;
        private IATMState correctPinCode;
        private IATMState noCard;
        private IATMState noCash;
        private IATMState machineState;
        public int AmountInMachine { get { return amountInMachine; }}
        public ATMMachine(int amountInMachine)
        {
            this.amountInMachine = amountInMachine;
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCard = new NoCardState(this);
            noCash = new NoCashState(this);

            if(amountInMachine<=0)
            {
                machineState = noCash;
            }
            else
            {
                machineState = cardPresent;
            }
        }
    }
}
