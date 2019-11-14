using System.Collections.Generic;
using System.Transactions;

namespace BankAccountLibrary
{
    public class Transactions
    {
        private readonly ICollection<BankAccountTransaction> transactions;
        
        public bool IsEmpty => transactions.Count == 0;
        public int Count => transactions.Count;

        public Transactions()
        {
            transactions = new List<BankAccountTransaction>();
        }

        public void Add(TransactionType transactionType, Amount amount)
        {
            transactions.Add(new BankAccountTransaction(transactionType, amount));
        }

        public Balance CalculateBalance()
        {
            Balance balance = new Balance();

            foreach (var transaction in transactions)
            {
                if (transaction.TransactionType == TransactionType.DEPOSIT)
                    balance += transaction.Amount;
                else
                    balance -= transaction.Amount;
            }
            return balance;
        }
    }
}