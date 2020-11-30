using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    class MainSystem
    {
        private Logger logger;
        private SubSystem subSystem;
        public void DoMainWork()
        {
            logger.Log("Main", "Starting the system...");
            logger.Log("MainSystem", "Doing some main work...");
            subSystem.DoSomeWork();
            subSystem.DoSomeMorework();
            logger.Log("Main", "Finishing...");
        }

        public MainSystem()
        {
            logger = Logger.GetInstance();
            subSystem = new SubSystem();
        }
    }
}
