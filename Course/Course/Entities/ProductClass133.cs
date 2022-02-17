using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class ProductClass133
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductClass133()
        {
        }

        public ProductClass133(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
