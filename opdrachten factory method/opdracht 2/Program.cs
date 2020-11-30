using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
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
            ComputerFactory expensivefactory = new HighBudgetFactory();
            ComputerShop expensiveshop = new ComputerShop();
            expensiveshop.AssembleMachine(expensivefactory);
            Console.WriteLine();
            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory cheapfactory = new LowBudgetFactory();
            ComputerShop cheapshop = new ComputerShop();
            cheapshop.AssembleMachine(cheapfactory);
            Console.ReadKey();

        }
    }
}
