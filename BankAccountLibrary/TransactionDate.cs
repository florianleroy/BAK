using System;

namespace BankAccountLibrary
{
    public class TransactionDate
    {
        private const string TRANSACTION_DATE_FORMAT = "yyyy/MM/dd";

        private readonly DateTime DateTime;
        public string Value => DateTime.ToString(TRANSACTION_DATE_FORMAT);

        public TransactionDate()
        {
            DateTime = DateTime.Now;
        }
    }
}