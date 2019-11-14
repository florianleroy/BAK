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
            Balance += amount;
        }
    }
}
