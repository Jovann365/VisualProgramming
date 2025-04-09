using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace VisualProgramming.CashAccount
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string code, string name, int price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Code} : {Name} {Price}";
        }
    }
}
