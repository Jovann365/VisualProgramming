using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.Airports
{
    public partial class AddDestination: Form
    {
        public Destination Destination { get; set; }
        public AddDestination()
        {
            InitializeComponent();
        }

        private void AddDestination_Load(object sender, EventArgs e)
        {

        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Венесете име!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Destination = new Destination(tbName.Text, (int)nudDistance.Value, (int)nudPrice.Value);
            DialogResult = DialogResult.OK;
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
