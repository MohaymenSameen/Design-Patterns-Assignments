using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        private ITrainJourney journey;       
        public TrainDisplay(ITrainJourney journey)
        {
            InitializeComponent();
            this.journey = journey;            
            this.journey.AddObserver(this);
        }       
        private void TrainDisplay_Load(object sender, EventArgs e)
        {           
            lblCurrentStationTxt.Text = journey.CurrentStation.Name;
            lblRailwayTrackTxt.Text = journey.CurrentStation.ArrivalTrack.ToString();
            lblArrivalTimeTxt.Text = journey.CurrentStation.ArrivalTime.ToString();
           
        }
        public void Update(TrainStation station)
        {
            lblCurrentStationTxt.Text = station.Name;
            lblRailwayTrackTxt.Text = station.ArrivalTrack.ToString();
            lblArrivalTimeTxt.Text = station.ArrivalTime.ToString();
        }
    }
}
