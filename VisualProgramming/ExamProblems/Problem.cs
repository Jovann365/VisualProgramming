using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.ExamProblems
{
    public class Problem
    {
        public string Desctiption { get; set; }
        public int Points { get; set; }

        public Problem(string desctiption, int points)
        {
            Desctiption = desctiption;
            Points = points;
        }
    }
}
