using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Tank : IAttacker
    {
        //not sure what generator's function was so i assigned it as the name of the driver using a constructor
        private string generator;
        public Tank(string name)
        {
            generator = name;
        }
        public void AssignDriver()
        {
            Console.WriteLine("{0} is steering the tank", generator);
        }
        public void DriveForward()
        {
            Console.WriteLine("Tank moves 3 positions forward");
        }
        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage");
        }
    }
}
