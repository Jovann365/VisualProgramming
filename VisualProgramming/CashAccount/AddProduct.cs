using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.CashAccount
{
    public partial class AddProduct: Form
    {
        public Product Product { get; set; }
        public AddProduct()
        {
            InitializeComponent();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                Product = new Product(nudCode.Value.ToString(), tbName.Text,(int)nudPrice.Value);
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

        private void nudCode_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
