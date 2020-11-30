using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class ComputerShop
    {
        public void AssembleMachine(ComputerFactory factory)
        {
            factory.CreateProcessor().PerformOperation();
            factory.CreateHardDisk().StoreData();
            factory.CreateMonitor().Display();
        }
    }
}
