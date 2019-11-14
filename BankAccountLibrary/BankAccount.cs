using System;

namespace BankAccountLibrary
{
    public class BankAccount
    {
        public Transactions Transactions
        {
            get;
        }

        public Balance Balance => Transactions.CalculateBalance();

        public BankAccount()
        {
            Transactions = new Transactions();
        }

        public void Deposit(Amount amount)
        {
            if (Amount.IsValid(amount))
                Transactions.Add(TransactionType.DEPOSIT, amount);
        }

        public void Withdrawal(Amount amount)
        {
            if (Amount.IsValid(amount))
                Transactions.Add(TransactionType.WITHDRAWAL, amount);
        }
    }
}
