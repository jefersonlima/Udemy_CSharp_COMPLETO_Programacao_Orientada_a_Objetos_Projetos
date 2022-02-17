using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    sealed class SavingsAccountClass134 : AccountClass134
    {
        public double InterestRate { get; set; }

        public SavingsAccountClass134()
        {
        }

        public SavingsAccountClass134(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpDateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            //Balance -= amount;
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
