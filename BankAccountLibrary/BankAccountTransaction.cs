namespace BankAccountLibrary
{
    public class BankAccountTransaction
    {
        internal readonly TransactionDate TransactionDate;
        internal readonly TransactionType TransactionType;
        internal readonly Amount Amount;
        
        public BankAccountTransaction()
        {
            TransactionDate = new TransactionDate();
        }
        
        public BankAccountTransaction(TransactionType transactionType, Amount amount) : this()
        {
            TransactionType = transactionType;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Date = {TransactionDate.Value}\t{TransactionType}\tAmount = {Amount.Value}";
        }
    }
}