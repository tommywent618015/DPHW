using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class TwitterDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting Twitter Data...");
        }

        public override void Load()
        {
            Console.WriteLine("Loading Twitter Data...");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming Twitter Data...");
        }
    }
}
