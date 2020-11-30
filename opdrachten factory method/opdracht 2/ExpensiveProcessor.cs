using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operations very quick...");
        }
    }
}
