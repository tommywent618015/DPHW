using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    abstract class ComputerFactory
    {
        public virtual IMonitor CreateMonitor()
        {
            return null;
        }
        public virtual IProcessor CreateProcessor()
        {
            return null;
        }
        public virtual IHardDisk CreateHardDisk()
        {
            return null;
        }
    }
}
