namespace BankAccountLibrary
{
    public class BankAccountTransaction
    {
        private readonly TransactionDate _transactionDate;
        internal readonly TransactionType TransactionType;
        internal readonly Amount Amount;

        private BankAccountTransaction()
        {
            _transactionDate = new TransactionDate();
        }
        
        public BankAccountTransaction(TransactionType transactionType, Amount amount) : this()
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