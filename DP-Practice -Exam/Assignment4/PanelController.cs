using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class PanelController:IPanelController
    {
        private IObservable system;

        public PanelController(IObservable system)
        {
            this.system = system;
        }
        public void NewMeasurement()
        {
            system.NewMeasurement();
        }
    }
}
