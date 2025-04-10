using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.F1Race
{
    public class Driver
    {
        public List<Circle> Circles { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool First { get; set; }

        public Driver(string name, int age, bool first)
        {
            Name = name;
            Age = age;
            First = first;
            Circles = new List<Circle>();
        }

        public override string ToString()
        {
            char first = 'S';
            if (First)
                first = 'F';
            return $"{Name} ({Age}) - {first}";
        }
    }
}
