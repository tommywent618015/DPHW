﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class HighBudgetFactory : ComputerFactory
    {
        public HighBudgetFactory()
        {
        }

        public override IHardDisk CreateHardDisk()
        {
            return new ExpensiveHardDisk();
        }

        public override IMonitor CreateMonitor()
        {
            return new ExpensiveMonitor();
        }

        public override IProcessor CreateProcessor()
        {
            return new ExpensiveProcessor();
        }
    }
}
