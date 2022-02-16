using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class OutsourceEmployee : EmployeeClass131
    {
        public double AdditionalCharge { get; set; }

        double percent  = 110;

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double payment = base.Payment();
            return payment += (AdditionalCharge / 100) * percent;
        }
    }
}
