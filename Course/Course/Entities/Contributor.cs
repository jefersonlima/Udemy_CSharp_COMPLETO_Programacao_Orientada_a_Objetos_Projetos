using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    abstract class Contributor
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected Contributor()
        {
        }
        protected Contributor(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double IncomeTax();
    }
}
