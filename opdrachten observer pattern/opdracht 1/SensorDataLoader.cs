using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class SensorDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting Sensor Data...");
        }

        public override void Load()
        {
            Console.WriteLine("Loading Sensor Data...");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming Sensor Data...");
        }
    }
}
