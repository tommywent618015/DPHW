﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class ExpensiveHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Processing data very quickly...");
        }
    }
}
