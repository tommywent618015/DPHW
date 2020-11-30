using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class BatchProcessor
    {
        BigDataLoader TwitterLoader = new TwitterDataLoader();
        BigDataLoader CallLoader = new CallDataLoader();
        BigDataLoader SensorLoader = new SensorDataLoader();
        private List<BigDataLoader> LoaderList = new List<BigDataLoader>();

        public void Add()
        {
            LoaderList.Add(CallLoader);
            LoaderList.Add(TwitterLoader);
            LoaderList.Add(SensorLoader);
        }

        public void Process()
        {
            foreach(BigDataLoader loader in LoaderList)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("[ETL-proces started]");
                Console.ResetColor();
                loader.DataLoader();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("[ETL-proces Finished]");
                Console.WriteLine("");
                Console.ResetColor();
            }
        }

    }
}
