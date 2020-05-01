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
    public partial class ControlPanel : Form
    {
        private ITrainController controller;
        private ITrainJourney journey;
        public ControlPanel()
        {
            InitializeComponent();
            journey = new TrainJourney();
            controller = new TrainController(journey);
        }
        private void btnNextStation_Click(object sender, EventArgs e)
        {            
            controller.NextStation();
        }
        private void btnNewDisplay_Click(object sender, EventArgs e)
        {
            TrainDisplay display = new TrainDisplay(journey);
            display.Show();
        }
    }
}
