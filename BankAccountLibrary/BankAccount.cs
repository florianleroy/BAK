using System;

namespace BankAccountLibrary
{
    public class BankAccount
    {
        public Balance Balance
        {
            get;
            private set;
        }

        public BankAccount()
        {
            Balance = new Balance();
        }

        public void Deposit(Amount amount)
        {
            if (Amount.IsValid(amount))
                Balance += amount;
        }

        public void Withdrawal(Amount amount)
        {
            if (Amount.IsValid(amount))
                Balance -= amount;
        }
    }
}
