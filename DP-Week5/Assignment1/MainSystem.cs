using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class MainSystem
    {
        private Logger logger;
        private SubSystem subSystem;
        public MainSystem(Logger logger)
        {
            this.logger = logger;
            subSystem = new SubSystem(logger);
        }
        public void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }
    }
}
