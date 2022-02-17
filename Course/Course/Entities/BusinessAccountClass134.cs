namespace Course.Entities
{
    class BusinessAccountClass134 : AccountClass134
    {
        public double LoanLimit { get; set; }

        public BusinessAccountClass134()
        {
        }

        public BusinessAccountClass134(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
