using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.F1Race
{
    public class Circle
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Circle(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Minutes}:{Seconds}";
        }
    }
}
