using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.Weather
{
    public partial class MainWeather: Form
    {
        List<Prognosis> days = new List<Prognosis>();
        public MainWeather()
        {
            InitializeComponent();
            changeinfo();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            AddDay addDay = new AddDay();
            if (addDay.ShowDialog() == DialogResult.OK)
            {
                days.Add(addDay.Prognosis as Prognosis);
                showdays();
                changeinfo();
            }
        }

        private void showdays()
        {
            lbDays.Items.Clear();
            foreach (Prognosis prog in days)
            {
                lbDays.Items.Add(prog);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (lbDays.SelectedItems.Count == 0)
            {
                return;
            }
            Prognosis prog = lbDays.SelectedItem as Prognosis;
            prog.Maximum = (int)numericUpDown1.Value;
            changeinfo();
        }
        
        public void changeinfo()
        {
            if (days.Count == 0)
            {
                max.Text = "";
                min.Text = "";
            }
            else
            {
                Prognosis maxDay = days[0];
                Prognosis minDay = days[0];
                foreach (Prognosis d in days)
                {
                    if ((int)d.Maximum > (int)maxDay.Maximum)
                    {
                        maxDay = d;
                    }
                    if ((int)d.Minimum < (int)minDay.Minimum)
                    {
                        minDay = d;
                    }
                }
                min.Text = minDay.ToString();
                max.Text = maxDay.ToString();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (lbDays.SelectedItems.Count == 0)
            {
                return;
            }
            Prognosis prog = lbDays.SelectedItem as Prognosis;
            prog.Minimum = (int)numericUpDown2.Value;
            changeinfo();
        }

        private void lbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prognosis selected = lbDays.SelectedItem as Prognosis;
            if (selected == null) 
            {
                return;
            }
            numericUpDown1.Value = (int)selected.Maximum;
            numericUpDown2.Value = (int)selected.Minimum;
            lbSelected.Text = selected.ToString();

        }

        private void btnDeleteDay_Click(object sender, EventArgs e)
        {
            if (lbDays.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Дали сте сигурни дека сакате да избришете?", "Избриши ден", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                lbDays.Items.Remove(lbDays.SelectedItem);
                changeinfo();
            }
        }
    }
}
