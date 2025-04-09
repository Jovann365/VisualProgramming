using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.Weather
{
    public class Prognosis
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public int Maximum { get; set; }
        public int Minimum { get; set; }

        public Prognosis(string day, string month)
        {
            Day = day;
            Month = month;
        }

        public override string ToString()
        {
            return $"{Day} {Month}";
        }
    }
}
