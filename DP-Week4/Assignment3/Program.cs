using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }
        void Start()
        {
            // create a tank (and assign it to a driver)
            IAttacker tank = new Tank("Frank");
            tank.AssignDriver();            

            // create a robot (and let it move by a person)
            Robot robot = new Robot("Mark");
            IAttacker robotAdapter = new RobotAdapter(robot);
            robotAdapter.AssignDriver();
            Console.WriteLine();

            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(robotAdapter);

            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                attacker.DriveForward();
                attacker.UseWeapon();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
