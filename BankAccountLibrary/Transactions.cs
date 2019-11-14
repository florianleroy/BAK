using System.Collections.Generic;
using System.Transactions;

namespace BankAccountLibrary
{
    public class Transactions
    {
        private ICollection<BankAccountTransaction> transactions;
        
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
    }
}