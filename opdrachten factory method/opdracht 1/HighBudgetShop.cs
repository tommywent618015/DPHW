using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class HighBudgetShop : ComputerShop
    {
        public HighBudgetShop()
        {

        }

        public override IProcessor CreateProcessor()
        {
            return new ExpensiveProcessor();
        }

        public override IHardDisk CreateHardDisk()
        {
            return new ExpensiveHardDisk();
        }

        public override IMonitor CreateMonitor()
        {
            return new ExpensiveMonitor();
        }
    }
}
