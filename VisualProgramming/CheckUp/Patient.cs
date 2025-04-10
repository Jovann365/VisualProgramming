using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.CheckUp
{
    public class Patient
    {
        public String Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public List<Mesurement> Mesurements { get; set; }

        public Patient(string name, int weight, int height) 
        {
            Name = name;
            Weight = weight;
            Height = height;
            Mesurements = new List<Mesurement>();
        }

        public override string ToString()
        {
            return $"{Name} {Weight}kg {Height}cm";
        }
    }
}
