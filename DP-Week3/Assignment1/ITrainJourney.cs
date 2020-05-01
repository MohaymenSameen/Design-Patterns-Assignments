using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public interface ITrainJourney
    {
        TrainStation CurrentStation { get; }
        void AddObserver(ITrainDisplay observer);
        void RemoveObserver(ITrainDisplay observer);
        void NextStation();
    }
}
