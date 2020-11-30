using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class RobotAdapter : IAtacker
    {
        Robot Robot;

        public RobotAdapter(Robot robot)
        {
            this.Robot = robot;
        }
        
        public void AssignDriver()
        {
            Robot.MoveByPerson();
        }

        public void DriveForward()
        {
            Robot.WalkForeward();
        }

        public void UseWeapon()
        {
            Robot.BashHands();
        }
    }
}
