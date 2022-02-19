using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class LegalPerson : Contributor
    {
        public int NumberOfEmployees { get; set; }
        static double PercentTaxAboveTenEmployees = 14;
        static double PercentTaxBelowTenEmployees = 16;

        public LegalPerson()
        {
        }

        public LegalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double IncomeTax()
        {
            if (NumberOfEmployees >= 10)
            {
                return AnnualIncome / 100 * PercentTaxAboveTenEmployees;
            }
            else
            {
                return AnnualIncome / 100 * PercentTaxBelowTenEmployees;
            }
        }
    }
}
