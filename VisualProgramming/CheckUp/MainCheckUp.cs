using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.CheckUp
{
    public partial class MainCheckUp : Form
    {
        List<Patient> Patients = new List<Patient>();
        public MainCheckUp()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            if (addPatient.ShowDialog() == DialogResult.OK)
            {
                Patients.Add(addPatient.Patient);
                lbPatients.Items.Add(addPatient.Patient);
            }
        }

        private void btnRemovePatient_Click(object sender, EventArgs e)
        {
            if (lbPatients.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Дали сте сигурни дека сакате да продолжиет?", "Бришење", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Patient p = lbPatients.SelectedItem as Patient;
                lbPatients.Items.Remove(p);
                Patients.Remove(p);
                updateMesurements();
            }

        }

        private void updateMesurements()
        {
            lbMesurements.Items.Clear();
            if (lbPatients.SelectedItems.Count != 0)
            {
                Patient p = lbPatients.SelectedItem as Patient;
                foreach (Mesurement m in p.Mesurements)
                {
                    lbMesurements.Items.Add(m);
                }
            }
        }

        private void lbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPatients.SelectedIndex != -1)
            {
                updateMesurements();
            }
        }

        private void btnAddMesurement_Click(object sender, EventArgs e)
        {
            if (lbPatients.SelectedIndex != -1)
            {
                Patient p = lbPatients.SelectedItem as Patient;
                Mesurement m = new Mesurement(cbMesName.Text, (int)nudValue.Value);
                p.Mesurements.Add(m);
                updateMesurements();
            }
        }
    }
}
