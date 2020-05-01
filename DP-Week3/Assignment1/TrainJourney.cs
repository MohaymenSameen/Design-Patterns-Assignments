using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class TrainJourney : ITrainJourney
    {
        private List<TrainStation> stations;
        private List<ITrainDisplay> observers;
        private TrainStation currentStation;
        private int index;
        public TrainStation CurrentStation { get { return currentStation; } }
        public TrainJourney()
        {
            stations = new List<TrainStation>();
            observers = new List<ITrainDisplay>();

            stations.Add(new TrainStation("Den Helder",2,DateTime.Parse("22:04:00"),DateTime.Parse("22:08:00")));
            stations.Add(new TrainStation("Anna Paulowna", 1, DateTime.Parse("22:14:00"), DateTime.Parse("22:15:00")));
            stations.Add(new TrainStation("Schagen", 1, DateTime.Parse("22:22:00"), DateTime.Parse("22:31:00")));
            stations.Add(new TrainStation("Heerhugowaard", 1, DateTime.Parse("22:31:00"), DateTime.Parse("22:36:00")));
            
            //so that the form loads with the first station in the list and is not null
            currentStation = stations[0];
            index = 0;
        }
       
        public void AddObserver(ITrainDisplay observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(ITrainDisplay observer)
        {
            observers.Remove(observer);
        }       
        public void NextStation()
        {
            //if index reaches last station, reverse list and start index from 0
            if (index >= stations.Count)
            {
                stations.Reverse();
                index = 0;
            }
            index += 1;
            currentStation = stations[index];                  
            
            NotifyObservers();
        }        
        private void NotifyObservers()
        {
            foreach (ITrainDisplay observer in observers)
            {
                observer.Update(CurrentStation);
            }
        }
    }
}
