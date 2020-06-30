using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public interface IObservable
    {
        public void NewMeasurement();
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
    }
}
