using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming.CashAccount
{
    public class Item
    {
        public Product Product { get; set; }
        public int Count { get; set; }

        public Item(Product product, int count)
        {
            Product = product;
            Count = count;
        }

        public override string ToString()
        {
            return $"{Product.Name} {Product.Price} X {Count} = {Product.Price * Count}";
        }
    }
}
