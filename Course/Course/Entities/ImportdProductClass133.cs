using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class ImportdProductClass133 : ProductClass133
    {
        public double CustomsFee { get; set; }

        public ImportdProductClass133()
        {
        }

        public ImportdProductClass133(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Customs fee: $ ");
            sb.Append(CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(")");

            return sb.ToString();
        }
    }
}
