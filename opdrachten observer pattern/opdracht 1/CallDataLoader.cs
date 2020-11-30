using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class CallDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting Call Data...");
        }

        public override void Load()
        {
            Console.WriteLine("Loading Call Data...");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming Call Data...");
        }
    }
}
