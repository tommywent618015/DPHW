﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class CheapProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operations very slowly...");
        }
    }
}
