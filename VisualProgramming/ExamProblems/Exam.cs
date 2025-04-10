using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.ExamProblems
{
    public class Exam
    {
        public string Month { get; set; }
        public int Year { get; set; }
        public Problem Problem1 { get; set; }
        public Problem Problem2 { get; set; }

        public Exam(string month, int year)
        {
            Month = month;
            Year = year;
            Problem1 = new Problem("Прва задача", 50);
            Problem2 = new Problem("Втора задача", 50);
        }

        public override string ToString()
        {
            return $"{Month} - {Year}";
        }
    }
}
