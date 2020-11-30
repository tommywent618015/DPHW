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
            BatchProcessor Processor = new BatchProcessor();
            Processor.Add();
            Processor.Process();

            Console.ReadKey();
        }
    }
}
