using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.F1Race
{
    public partial class MainF1 : Form
    {
        List<Driver> Drivers = new List<Driver>();
        public MainF1()
        {
            InitializeComponent();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            AddDriver addDriver = new AddDriver();
            if (addDriver.ShowDialog() == DialogResult.OK)
            {
                Drivers.Add(addDriver.Driver as Driver);
                lbDrivers.Items.Add(addDriver.Driver);
            }
        }

        private void btnRemoveDriver_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Дали сте сигурни дека сакате да продолжите?", "Бришење возач", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Driver del = lbDrivers.SelectedItem as Driver;
                lbDrivers.Items.Remove(del);
                Drivers.Remove(del);
                lbCircles.Items.Clear();
                resetCircles();
            }
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedItems.Count == 0)
            {
                return;
            }

            Driver dr = lbDrivers.SelectedItem as Driver;
            dr.Circles.Add(new Circle((int)nudMinutes.Value, (int)nudSeconds.Value));
            nudSeconds.Value = 0;
            nudMinutes.Value = 0;
            resetCircles();
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (nudSeconds.Value == 60)
            {
                nudSeconds.Value = 0;
                nudMinutes.Value = nudMinutes.Value + 1;
            }
            if (nudSeconds.Value == -1)
            {
                if (nudMinutes.Value == 0)
                {
                    nudSeconds.Value = 0;
                }
                else
                {
                    nudSeconds.Value = 59;
                    nudMinutes.Value = nudMinutes.Value - 1;
                }
            }
        }

        private void resetCircles()
        {
            lbCircles.Items.Clear();
            if (lbDrivers.SelectedItems.Count == 0)
            {
                return;
            }
            Driver dr = lbDrivers.SelectedItem as Driver;
            if (dr.Circles.Count == 0)
            {
                return;
            }
            Circle fastest = dr.Circles[0];
            foreach (Circle c in dr.Circles)
            {
                if (c.Seconds + c.Minutes * 60 >= (int)nudTIme.Value)
                {
                    if (c.Seconds + c.Minutes * 60 < fastest.Seconds + fastest.Minutes * 60)
                    {
                        fastest = c;
                    }
                    lbCircles.Items.Add(c);
                }
            }
            tbBestCircle.Text = fastest.ToString();
        }

        private void lbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetCircles();
        }

        private void nudTIme_ValueChanged(object sender, EventArgs e)
        {
            resetCircles();
        }
    }
}
