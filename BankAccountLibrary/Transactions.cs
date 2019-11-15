using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankAccountLibrary
{
    public class Transactions
    {
        private readonly ICollection<BankAccountTransaction> _transactions;
        
        public bool IsEmpty => _transactions.Count == 0;
        public int Count => _transactions.Count;

        public Transactions()
        {
            _transactions = new List<BankAccountTransaction>();
        }

        public void Add(TransactionType transactionType, Amount amount)
        {
            _transactions.Add(new BankAccountTransaction(transactionType, amount));
        }

        public Balance Balance
        {
            get
            {
                Balance balance = new Balance();

                foreach (var transaction in _transactions)
                {
                    balance += transaction;
                }
                return balance;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder().AppendLine();
            Balance balance = new Balance();

            foreach (var transaction in _transactions)
            {
                balance += transaction;

                stringBuilder.Append(transaction);
                stringBuilder.AppendLine($"\tBalance = {balance.Value}");
            }
            return stringBuilder.ToString();
        }
    }
}