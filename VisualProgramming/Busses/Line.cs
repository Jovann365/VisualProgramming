using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.Busses
{
    public class Line
    {
        public string Desstination { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }
        public int Price { get; set; }

        public Line(string desstination, int hour, int minutes, int price)
        {
            Desstination = desstination;
            Hour = hour;
            Minutes = minutes;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Hour}:{Minutes} - {Desstination} - {Price}Ден.";
        }
    }
}
