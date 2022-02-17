using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class UsedProductClass133 : ProductClass133
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProductClass133()
        {
        }

        public UsedProductClass133(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Manufacture date: ");
            sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            sb.Append(")");

            return sb.ToString();
        }
    }
}
