namespace Course.Entities
{
    abstract class AccountClass134
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public AccountClass134()
        {
        }

        public AccountClass134(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw (double amount)
        {
            Balance -= amount +5;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
