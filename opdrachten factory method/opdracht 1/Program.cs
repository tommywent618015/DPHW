using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            ComputerShop expensiveshop = new HighBudgetShop();
            expensiveshop.AssambleMachine();
            Console.WriteLine();
            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop cheapshop = new LowBudgetShop();
            cheapshop.AssambleMachine();
            Console.ReadKey();
        }
 
    }
}
