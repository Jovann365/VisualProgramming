using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.TVProgram
{
    public class Program
    {
        public string Name { get; set; }

        public int Minutes { get; set; }

        public Program(string name, int minutes)
        {
            Name = name;
            Minutes = minutes;
        }

        public override string ToString()
        {
            int Hours = Minutes / 60;
            Minutes = Minutes % 60;
            return $"{Name} {Hours}:{Minutes}";
        }
    }
}
