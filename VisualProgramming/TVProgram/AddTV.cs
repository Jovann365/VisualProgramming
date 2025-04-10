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
    public partial class AddTV: Form
    {
        public List<int> Used { get; set; }
        public TV TV { get; set; }
        public AddTV(List<int> used)
        {
            Used = used;
            InitializeComponent();
            
        }


        private void AddTV_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                TV = new TV(tbName.Text, (int)nudNumber.Value);
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

        private void nudNumber_Validating(object sender, CancelEventArgs e)
        {
            if (Used.Contains((int)nudNumber.Value))
            {
                errorProvider1.SetError(nudNumber, "Веќе постои телевизија со тој број!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudNumber, null);
                e.Cancel = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
