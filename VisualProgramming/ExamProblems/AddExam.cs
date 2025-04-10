using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.ExamProblems
{
    public partial class AddExam: Form
    {
        public Exam Exam { get; set; }
        public AddExam()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                Exam = new Exam(cbMonth.Text, (int)nudYear.Value);
                DialogResult = DialogResult.OK;
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMonth_Validating(object sender, CancelEventArgs e)
        {
            if (cbMonth.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbMonth, "Одбери месец!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbMonth, null);
                e.Cancel = false;
            }
        }
    }
}
