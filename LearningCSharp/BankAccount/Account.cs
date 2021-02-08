namespace BankAccount
{
    public class Account
    {
        public string Name { get; set; }
        private decimal _balance;

        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }

        public decimal Balance
        {
            get => _balance;

            private set
            {
                if (value > 0.0m)
                {
                    _balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }
    }
}