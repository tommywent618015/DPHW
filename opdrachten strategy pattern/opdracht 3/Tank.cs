﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class Tank : IAtacker
    {
        public void AssignDriver()
        {
            Console.WriteLine("Frank is steering the tank...");
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves 3 positions foreward...");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes big damage...");
        }
    }
}
