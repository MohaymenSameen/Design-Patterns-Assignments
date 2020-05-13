using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class SubSystem
    {
        private Logger logger;
        public SubSystem(Logger logger)
        {
            this.logger = logger;
        }
        public void DoSomeWork()
        {
            logger.Log("SubSystem", "doing some work");            
        }
        public void DoSomeMoreWork()
        {
            logger.Log("SubSystem", "doing some more work");
        }

    }
}
