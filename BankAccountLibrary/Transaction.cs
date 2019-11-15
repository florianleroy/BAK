namespace BankAccountLibrary
{
    public class Transaction
    {
        private readonly TransactionDate _transactionDate;
        internal readonly TransactionType TransactionType;
        internal readonly Amount Amount;

        private Transaction()
        {
            _transactionDate = new TransactionDate();
        }
        
        public Transaction(TransactionType transactionType, Amount amount) : this()
        {
            TransactionType = transactionType;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Date = {_transactionDate.Value}\t{TransactionType}\tAmount = {Amount.Value}";
        }
    }
}