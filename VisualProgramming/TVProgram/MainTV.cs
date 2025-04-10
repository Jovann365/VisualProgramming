using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.TVProgram
{
    public partial class MainTV: Form
    {
        List<TV> tvs = new List<TV>();
        public List<int> usedNumbers { get; set; }
        public MainTV()
        {
            usedNumbers = new List<int>();
            InitializeComponent();
            btnAdd.Enabled = false;
        }

        private void MainTV_Load(object sender, EventArgs e)
        {

        }

        private void cbTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbName.Text.Length <= 0)
            {
                btnAdd.Enabled = false;
                refreshPrograms();
            }
            else
            {
                btnAdd.Enabled = true;
                refreshPrograms();
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (cbTV.SelectedIndex == -1 || tbName.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || cbTV.SelectedIndex == -1)
            {
                return;
            }
            TV selected = cbTV.SelectedItem as TV;
            selected.Programs.Add(new Program(tbName.Text, (int)nudTime.Value));
            refreshPrograms();
            tbName.Text = "";
            nudTime.Value = 0;
        }

        private void refreshPrograms()
        {
            lbPrograms.Items.Clear();
            tbAverage.Text = "0";
            if (cbTV.SelectedIndex == -1)
            {
                return;
            }
            TV tv = cbTV.SelectedItem as TV;
            programName.Text = tv.Name;
            if (tv.Programs.Count == 0)
                return;

            decimal sum = 0;
            foreach (Program p in tv.Programs)
            {
                sum += p.Minutes;
                lbPrograms.Items.Add(p);
            }
            tbAverage.Text = (sum / tv.Programs.Count).ToString();
        }

        private void btnAddTV_Click(object sender, EventArgs e)
        {
            AddTV addTV = new AddTV(this.usedNumbers);
            if (addTV.ShowDialog() == DialogResult.OK)
            {
                cbTV.Items.Add(addTV.TV);
                tvs.Add(addTV.TV);
                usedNumbers.Add(addTV.TV.Number);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbPrograms.Items.Count != 0)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да избришете?", "Бришење канал", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Program prog = lbPrograms.SelectedItem as Program;
                    lbPrograms.Items.Remove(prog);
                    TV tv = cbTV.SelectedItem as TV;
                    tv.Programs.Remove(prog);
                    refreshPrograms();
                }
            }
           
        }

      
    }
}
