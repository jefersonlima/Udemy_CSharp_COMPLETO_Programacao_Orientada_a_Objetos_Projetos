using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class ProductAula123
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductAula123()
        {
        }
        public ProductAula123(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
