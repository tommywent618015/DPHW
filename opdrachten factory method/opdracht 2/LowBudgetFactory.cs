using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class LowBudgetFactory : ComputerFactory
    {
        public LowBudgetFactory()
        {
        }

        public override IProcessor CreateProcessor()
        {
            return new CheapProcessor();
        }

        public override IMonitor CreateMonitor()
        {
            return new CheapMonitor();
        }

        public override IHardDisk CreateHardDisk()
        {
            return new CheapHardDisk();
        }
    }
}
