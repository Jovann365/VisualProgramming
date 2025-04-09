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
            showInfo();
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
                adding.Destinations.Add(addDestination.Destination);
                showDestinations();
                showInfo();
            }
        }

        public void showDestinations()
        {
            lbDestinations.Items.Clear();
            Airport airport = lbAirports.SelectedItem as Airport;
            foreach (Destination destination in airport.Destinations)
            {
                lbDestinations.Items.Add(destination);
            }
        }


        public void showInfo()
        { 
            Airport airport = lbAirports.SelectedItem as Airport;
            if (airport == null)
            {
                tbExpensive.Text = "";
                tbAverage.Text = "0";
                return;
            }

            if (airport.Destinations.Count == 0)
            {
                tbExpensive.Text = "";
                tbAverage.Text = "0";
            }
            else 
            {
               
                decimal average = 0;
                int count = 0;
                Destination mostExpensive = airport.Destinations[0];
                foreach (Destination destination in airport.Destinations)
                {
                    count++;
                    average += (int)destination.Distance;
                    if (destination.Price > mostExpensive.Price)
                    {
                        mostExpensive = destination;
                    }
                }
                tbAverage.Text = (average / count).ToString();
                tbExpensive.Text = mostExpensive.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        
      
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDestinations();
            showInfo();
        }
    }
}
