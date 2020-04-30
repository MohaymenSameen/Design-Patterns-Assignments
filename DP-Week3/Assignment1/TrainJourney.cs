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
        public TrainJourney()
        {
            stations = new List<TrainStation>();
            observers = new List<ITrainDisplay>();

            stations.Add(new TrainStation("Den Helder","Arnhem Central",DateTime.Parse("23:04:00"),DateTime.Parse("01:30:00")));
            stations.Add(new TrainStation("Arnhem Central", "Nijmegen", DateTime.Parse("01:35:00"), DateTime.Parse("02:20:00")));
        }
        public void AddObserver(ITrainDisplay observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(ITrainDisplay observer)
        {
            observers.Remove(observer);
        }
        public void Next()
        {

        }
    }
}
