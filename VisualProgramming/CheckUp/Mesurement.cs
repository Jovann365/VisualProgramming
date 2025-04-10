using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.CheckUp
{
    public class Mesurement
    {
        public String Name { get; set; }
        public int Value { get; set; }

        public Mesurement(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Name}: {Value}";
        }
    }
}
