namespace BankAccountLibrary
{
    public class BankAccountTransaction
    {
        internal readonly TransactionType TransactionType;
        internal readonly Amount Amount;
        
        public BankAccountTransaction(TransactionType transactionType, Amount amount)
        {
            TransactionType = transactionType;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{TransactionType}\t{Amount.Value}";
        }
    }
}