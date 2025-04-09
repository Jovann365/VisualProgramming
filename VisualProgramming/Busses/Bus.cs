using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.Busses
{
    public class Bus
    {
        public string Name { get; set; }
        public string Registration { get; set; }
        public bool Local { get; set; }
        public List<Line> Lines { get; set; }

        public Bus(string name, string registration, bool local)
        {
            Name = name;
            Registration = registration;
            Local = local;
            Lines = new List<Line>();
        }

        public override string ToString()
        {
            char local;
            if (Local == true)
            {
                local = 'L';
            }
            else
                local = 'M';
            return $"{Name} - {Registration} - {local}";
        }
    }
}
