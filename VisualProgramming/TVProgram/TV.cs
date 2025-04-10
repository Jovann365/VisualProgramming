using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.TVProgram
{
    public class TV
    {
        public List<Program> Programs { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public TV(string name, int number)
        {
            Programs = new List<Program>();
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number}. {Name}";
        }
    }
}
