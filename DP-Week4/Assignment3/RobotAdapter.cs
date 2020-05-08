using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class RobotAdapter : IAttacker
    {
        private Robot robot;
        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }
        public void AssignDriver()
        {
            robot.MoveByPerson();
        }  
        public void DriveForward()
        {
            robot.WalkForward();
        }
        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
