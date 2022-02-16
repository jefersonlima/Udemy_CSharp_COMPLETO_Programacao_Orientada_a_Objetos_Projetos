using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class EmployeeClass131
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public EmployeeClass131()
        {
        }

        public EmployeeClass131(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ");
            sb.AppendLine(Name);

            sb.Append("Hours worked: ");
            sb.AppendLine(Hours.ToString());

            sb.Append("Value Per Hour: ");
            sb.AppendLine(ValuePerHour.ToString("F2", CultureInfo.InvariantCulture));

            sb.Append("Payment: ");
            sb.AppendLine(Payment().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
