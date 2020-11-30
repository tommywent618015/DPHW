using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1
{
    class SubSystem
    {
        private Logger logger;
        
        public void DoSomeMorework()
        {
            logger.Log("SubSystem", "Doing some more work...");
        }

        public void DoSomeWork()
        {
            logger.Log("SubSystem", "Doing some work...");
        }

        public SubSystem()
        {
            logger = Logger.GetInstance();            
        }
    }
}
