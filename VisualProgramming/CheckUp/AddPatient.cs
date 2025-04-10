using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.CheckUp
{
    public partial class AddPatient: Form
    {
        public Patient Patient { get; set; }

        public AddPatient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                Patient = new Patient(tbName.Text, (int)nudWeight.Value, (int)nudHeight.Value);
                DialogResult = DialogResult.OK;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Enter a name!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }
    }
}
