using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
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
            Pencil p = new Pencil();
            Console.Write("Enter a word/line: ");
            string message = Console.ReadLine();
            while (message != "stop")
            {               
                p.Write(message);
                Console.Write("Enter a word/line: ");
                message = Console.ReadLine();
            }
        }
    }
}
