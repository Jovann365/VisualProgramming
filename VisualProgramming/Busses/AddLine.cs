using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.Busses
{
    public partial class AddLine: Form
    {
        public Line Line { get; set; }
        public AddLine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Line = new Line(tbDestination.Text, (int)nudHour.Value, (int)nudMinutes.Value, (int)nudPrice.Value);
                DialogResult = DialogResult.OK;

            }
        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if (tbDestination.Text == "")
            {
                errorProvider1.SetError(tbDestination, "Внесете дестинација!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestination, null);
                e.Cancel = false;
            }
        }

        private void tbDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddLine_Load(object sender, EventArgs e)
        {

        }
    }
}
