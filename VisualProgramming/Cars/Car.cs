using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.Cars
{
    public class Car
    {
        public Model Model { get; set; }
        public string Name { get; set; }
        public decimal Spending { get; set; }
        public int Price { get; set; }

        public Car(Model model, string name, decimal spending, int price)
        {
            Model = model;
            Name = name;
            Spending = spending;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Model.print()} {Name} {Spending} {Price}";
        }
    }
}
