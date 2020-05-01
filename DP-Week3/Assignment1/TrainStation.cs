﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class TrainStation
    {
        public string Name { get; set; }
        public int ArrivalTrack { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public TrainStation(string name, int arrivalTrack, DateTime arrivalTime, DateTime departureTime)            
        {
            Name = name;
            ArrivalTrack = arrivalTrack;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
        }
    }
}
