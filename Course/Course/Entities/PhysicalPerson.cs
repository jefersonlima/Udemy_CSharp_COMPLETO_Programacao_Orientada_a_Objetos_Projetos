using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class PhysicalPerson : Contributor
    {
        public double HealthSpending { get; set; }
        static double AnnualIncomeForTax = 20000;
        static double PercentTaxMin = 15;
        static double PercentTaxMax = 25;
        static double DiscountWithHealth = 50;

        public PhysicalPerson()
        {
        }

        public PhysicalPerson(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double IncomeTax()
        {
            if (AnnualIncome < AnnualIncomeForTax)
            {
                return AnnualIncome / 100 * PercentTaxMin;
            }
            else
            {
                if (HealthSpending > 0)
                {
                    return (AnnualIncome / 100 * PercentTaxMax) - (HealthSpending / 100 * DiscountWithHealth);
                }
                else
                {
                    return AnnualIncome / 100 * PercentTaxMax;
                }
                
            }
        }
    }
}
