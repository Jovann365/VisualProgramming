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
    public partial class AddBus: Form
    {
        public Bus Bus { get; set; }
        public AddBus()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Validate();

            if (ValidateChildren() == true)
            {
                Bus = new Bus(tbName.Text, tbRegistration.Text, cbLocal.Checked);
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

        private void tbRegistration_Validating(object sender, CancelEventArgs e)
        { 
            int count = 0;
            if (tbRegistration.Text == "")
            {
                errorProvider1.SetError(tbRegistration, "Грешна регистрација!");
                e.Cancel = true;
                return;
            }

            foreach (Char c in tbRegistration.Text)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }

            }
            if (count < 4 || tbRegistration.Text == "")
            {
                errorProvider1.SetError(tbRegistration, "Грешна регистрација!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbRegistration, null);
                e.Cancel = false;
            }
            
        }

        private void AddBus_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
