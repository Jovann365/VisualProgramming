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
    public partial class MainExam: Form
    {
        List<Exam> Exams = new List<Exam>();
        public MainExam()
        {
            InitializeComponent();
            btnDeleteExam.Enabled = false;
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            AddExam addExam = new AddExam();
            if (addExam.ShowDialog() == DialogResult.OK)
            {
                Exams.Add(addExam.Exam);
                lbExamss.Items.Add(addExam.Exam);
            }
        }

        private void lbExamss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbExamss.SelectedIndex == -1 || lbExamss.SelectedItems.Count == 0)
            {
                btnDeleteExam.Enabled = false;
                return;
            }
            Exam exam = lbExamss.SelectedItem as Exam;
            tbDesc1.Text = exam.Problem1.Desctiption;
            nudPoints1.Value = exam.Problem1.Points;
            tbDesc2.Text = exam.Problem2.Desctiption;
            nudPoints2.Value = exam.Problem2.Points;
            btnDeleteExam.Enabled = true;
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (lbExamss.TabIndex == -1)
            {
                return;
            }
            Exam exam = lbExamss.SelectedItem as Exam;
            exam.Problem1.Desctiption = tbDesc1.Text;
            exam.Problem1.Points = (int)nudPoints1.Value;
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (lbExamss.TabIndex == -1)
            {
                return;
            }
            Exam exam = lbExamss.SelectedItem as Exam;
            exam.Problem2.Desctiption = tbDesc2.Text;
            exam.Problem2.Points = (int)nudPoints2.Value;
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            if (lbExamss.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Дали сте сигурни дека сакате да избришете?", "Бришење испит", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Exam ex = lbExamss.SelectedItem as Exam;
                lbExamss.Items.Remove(ex);
                Exams.Remove(ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
