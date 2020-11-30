using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    class Logger
    {
        private int NumberOfLines = 0;
        private static Logger UniqueInstance;

        private Logger()
        {            
        }

        public void Log(string system, string text)
        {
            NumberOfLines++;
            Console.WriteLine($"{NumberOfLines} - [{system}] {text}");
        }

        public static Logger GetInstance()
        {
            if (UniqueInstance == null)
            {
                UniqueInstance = new Logger();
            }
            return UniqueInstance;
        }
    }
}
