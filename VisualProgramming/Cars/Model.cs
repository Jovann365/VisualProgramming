using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.Cars
{
    public class Model
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Model(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return $"{Name} ({Code})";
        }

        public string print()
        {
            return $"{Name}";
        }
    }
}
