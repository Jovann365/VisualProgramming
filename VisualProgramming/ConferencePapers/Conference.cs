using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.ConferencePapers
{
    public class Conference
    {
        public String Name { get; set; }
        public int Year { get; set; }
        public string Id { get; set; }

        public Conference(string name, int year)
        {
            Name = name;
            Year = year;
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Year}: {Name}";
        }
    }
}
