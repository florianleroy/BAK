using System.Collections.Generic;
using System.Text;
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

        public Balance Balance
        {
            get
            {
                Balance balance = new Balance();

                foreach (var transaction in transactions)
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

            foreach (var transaction in transactions)
            {
                balance += transaction;

                stringBuilder.Append(transaction);
                stringBuilder.AppendLine($"\tBalance = {balance.Value}");
            }
            return stringBuilder.ToString();
        }
    }
}