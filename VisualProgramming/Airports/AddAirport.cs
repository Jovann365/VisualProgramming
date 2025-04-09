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
    public partial class AddAirport: Form
    {
        public Airport Airport { get; set; }
        public AddAirport()
        {
            InitializeComponent();
        }

        private void AddAirport_Load(object sender, EventArgs e)
        {

        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text == "")
            {
                errorProvider1.SetError(tbCity, "Внесете град!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCity, null);
                e.Cancel = false;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Внесете име!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            if (tbCode.Text.Length != 3)
            {
                errorProvider1.SetError(tbCode, "Герешен код!");
                e.Cancel = true;
            }
            else
            {
                bool isValid = true;
                foreach (char c in tbCode.Text)
                {
                    if (char.IsLower(c))
                    {
                        errorProvider1.SetError(tbCode, "Герешен формат!");
                        e.Cancel = true;
                        isValid = false;
                        return;
                    }
                }

                if (isValid)
                {
                    errorProvider1.SetError(tbCode, null);
                    e.Cancel = false;
     
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

             Airport = new Airport(tbName.Text, tbCity.Text, tbCode.Text);
             DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
