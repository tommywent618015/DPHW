﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class CheapMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying frames with low FPS...");
        }
    }
}
