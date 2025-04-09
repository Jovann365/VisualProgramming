using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.ConferencePapers
{
    public partial class MainPapers: Form
    {
        List<Conference> conferences = new List<Conference>();
        public MainPapers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddConference addConference = new AddConference();
            if (addConference.ShowDialog() == DialogResult.OK)
            {
                conferences.Add(addConference.Conference as Conference);
                lbConferences.Items.Add(addConference.Conference);
                if (!cbYear.Items.Contains(addConference.Conference.Year))
                {
                    cbYear.Items.Add(addConference.Conference.Year);
                }
            }

;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbConferences.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Дали сте сигурни дека сакате да избришете?", "Бришење конференција", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conference conf = lbConferences.SelectedItem as Conference;
                conferences.Remove(conf);
                lbConferences.Items.Remove(conf);
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYear.SelectedItem.ToString() == "-1")
            {
                lbConferences.Items.Clear();
                foreach (Conference c in conferences)
                {
                    lbConferences.Items.Add(c);
                }
            }
            else
            {
                lbConferences.Items.Clear();
                int year =(int)cbYear.SelectedItem;
                foreach (Conference c in conferences)
                {
                    if (c.Year == year)
                    {
                        lbConferences.Items.Add(c);
                    }
                }
            }
        }
    }
}
