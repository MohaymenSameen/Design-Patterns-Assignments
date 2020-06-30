using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class SolarPanelSystem : IObservable
    {
        private Random random;
        public int Power { get; set; }
        private List<IObserver> observers;
        public SolarPanelSystem()
        {
            observers = new List<IObserver>();
            random = new Random();
        }
        public void NewMeasurement()
        {
            Power = random.Next(300, 400);            
            NotifyObservers();
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(Power);
            }
        }
    }
}
