using System;

namespace BankAccountLibrary
{
    public class BankAccount
    {
        public Transactions Transactions
        {
            get;
            private set;
        }

        public Balance Balance
        {
            get;
            private set;
        }

        public BankAccount()
        {
            Balance = new Balance();
            Transactions = new Transactions();
        }

        public void Deposit(Amount amount)
        {
            if (Amount.IsValid(amount))
            {
                Balance += amount;
                Transactions.Add(TransactionType.DEPOSIT, amount);
            }
        }

        public void Withdrawal(Amount amount)
        {
            if (Amount.IsValid(amount))
            {
                Balance -= amount;
                Transactions.Add(TransactionType.WITHDRAWAL, amount);
            }   
        }
    }
}
