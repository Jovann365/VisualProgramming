using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualProgramming.Airports;

namespace VisualProgramming
{
    public partial class MainForm: Form
    {
        List<Airport> airports = new List<Airport>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            AddAirport addAirport = new AddAirport();
            if (addAirport.ShowDialog() == DialogResult.OK)
            {
                airports.Add((Airport)addAirport.Airport);
                lbAirports.Items.Add((Airport)addAirport.Airport);
            }
        }

        private void btnRemoveAirport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да избришете?", "Бришење", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                airports.Remove((Airport)lbAirports.SelectedItem);
                lbAirports.Items.Remove(lbAirports.SelectedItem);
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            AddDestination addDestination = new AddDestination();
            if (addDestination.ShowDialog() == DialogResult.OK)
            {
                Airport adding = (Airport)lbAirports.SelectedItem;
                int index = airports.IndexOf(adding);
                airports[index].Destinations.Add(addDestination.Destination);
            }
        }
    }
}
