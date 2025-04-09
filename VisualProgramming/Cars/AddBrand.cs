using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.Cars
{
    public partial class AddBrand: Form
    {
        public Model Model { get; set; }
        public AddBrand()
        {
            InitializeComponent();
        }

        private void AddBrand_Load(object sender, EventArgs e)
        {

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
            if (tbCode.Text == "")
            {
                errorProvider1.SetError(tbCode, "Внесете код!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCode, null);
                e.Cancel = false;
            }
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
            {
                return;
            }
            Model = new Model(tbName.Text, tbCode.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
