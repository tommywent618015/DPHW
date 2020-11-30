using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class ExpensiveMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying frames with very high FPS...");
        }
    }
}
