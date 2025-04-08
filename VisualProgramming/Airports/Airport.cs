using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.Airports
{
    public class Airport
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Code  { get; set; }
        public List<Destination> Destinations { get; set; } = new List<Destination>();

        public Airport(string name, string city, string code)
        {
            Name = name;
            City = city;
            Code = code;
        }

        public override string ToString()
        {
            return $"{Code} - {Name} - {City}";
        }
    }
}
