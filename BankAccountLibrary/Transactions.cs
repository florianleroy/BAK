using System.Collections.Generic;

namespace BankAccountLibrary
{
    public class Transactions
    {
        private ICollection<BankAccountTransaction> transactions;
        
        public bool IsEmpty => transactions.Count == 0;

        public Transactions()
        {
            transactions = new List<BankAccountTransaction>();
        }
    }
}