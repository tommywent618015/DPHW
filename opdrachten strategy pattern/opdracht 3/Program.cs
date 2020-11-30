using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
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
            
            // create a tank (and assign it to a driver)
            Tank tank = new Tank();
            tank.AssignDriver();
            // create a robot (and let it move by a person)
            Robot robot1 = new Robot();
            RobotAdapter robot = new RobotAdapter(robot1);
            robot1.MoveByPerson();
            Console.WriteLine();
            // create attackers list, and add tank and robot
            List<IAtacker> attackers = new List<IAtacker>();
            attackers.Add(tank);
            attackers.Add(robot);            
            // process all attackers
            foreach (IAtacker attacker in attackers)
            {
                attacker.DriveForward();
                attacker.UseWeapon();
                Console.WriteLine("");
            }

            Console.ReadKey();       
        }
    }
}
