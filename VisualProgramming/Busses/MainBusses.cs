using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.Busses
{
    public partial class MainBusses : Form
    {
        List<Bus> Busses = new List<Bus>();
        public MainBusses()
        {
            InitializeComponent();
            showLines();
        }

        private void MainBusses_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            AddBus addBus = new AddBus();
            if (addBus.ShowDialog() == DialogResult.OK)
            {
                Busses.Add(addBus.Bus as Bus);
                lbBuses.Items.Add(addBus.Bus);
                showLines();
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if (lbBuses.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете автобусот?", "Бришење", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Bus Bus = lbBuses.SelectedItem as Bus;
                Busses.Remove(Bus);
                lbBuses.Items.Remove(Bus);
                showLines();
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (lbBuses.SelectedItem == null)
            {
                return;
            }
            AddLine addLine = new AddLine();
            if (addLine.ShowDialog() == DialogResult.OK)
            {
                Bus Bus = lbBuses.SelectedItem as Bus;
                Bus.Lines.Add(addLine.Line as Line);
                showLines();
            }
        }

        public void showLines()
        {
            lbLines.Items.Clear();
            if (lbBuses.SelectedItem == null)
            {
                tbExpensive.Text = "";
                tbAveragePrice.Text = "0";
                return;
            }
            Bus Bus = lbBuses.SelectedItem as Bus;
            foreach (Line l in Bus.Lines)
            {
                lbLines.Items.Add(l);
            }
            calc();

        }


        private void lbBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            showLines();
        }


        private void calc()
        {
            if (lbLines.Items.Count == 0)
            {
                tbExpensive.Text = "";
                tbAveragePrice.Text = "0";
                return;
            }

            Bus Bus = lbBuses.SelectedItem as Bus;
            Line expensive = Bus.Lines[0];
            decimal sum = 0;
            foreach (Line l in Bus.Lines)
            {
                if (l.Price > expensive.Price)
                {
                    expensive = l;
                }
                sum += l.Price;
            }

            tbExpensive.Text = expensive.ToString();
            tbAveragePrice.Text = (sum / Bus.Lines.Count).ToString();
        }

        private void tbAveragePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
