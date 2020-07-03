using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Assignment4
{
    public class ClockSystem:IClockSystem
    {
        private DateTime currentDateTime;
        public DateTime CurrentDateTime { get { return currentDateTime; } }
        private List<IClockObserver> observers;
        public ClockSystem()
        {
            observers = new List<IClockObserver>();
            currentDateTime = DateTime.Now;
        }
        public void UpdateDateTime()
        {
            currentDateTime.ToString("hh:mm:ss");
            NotifyObservers();
        }
        public void AddObserver(IClockObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IClockObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (IClockObserver observer in observers)
            {
                observer.Update(CurrentDateTime);
            }
        }
        
    }
}
