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
    public partial class AddDriver: Form
    {
        public  Driver Driver { get; set; }
        public AddDriver()
        {
            InitializeComponent();
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Driver = new Driver(tbName.Text, (int)nudAge.Value, cbFirst.Checked);
                DialogResult = DialogResult.OK;
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
    }
}
