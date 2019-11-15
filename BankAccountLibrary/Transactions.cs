using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankAccountLibrary
{
    public class Transactions
    {
        private readonly ICollection<Transaction> _transactions;
        
        public bool IsEmpty => _transactions.Count == 0;
        public int Count => _transactions.Count;

        public Transactions()
        {
            _transactions = new List<Transaction>();
        }

        public void Add(TransactionType transactionType, Amount amount)
        {
            _transactions.Add(new Transaction(transactionType, amount));
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

        public string Statements
        {
            get
            {
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
    }
}