using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Robot
    {
        //not sure what generator's function was so i assigned it as the name of the driver using a constructor
        private string generator;
        public Robot(string name)
        {
            generator = name;
        }
        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }
        public void MoveByPerson()
        {
            Console.WriteLine("Robot is moved by {0}",generator);
        }
        public void WalkForward()
        {
            Console.WriteLine("Robot walks 3 steps forward");
        }
    }
}
