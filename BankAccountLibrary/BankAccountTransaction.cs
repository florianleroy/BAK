namespace BankAccountLibrary
{
    public class BankAccountTransaction
    {
        private readonly TransactionType TransactionType;
        private readonly Amount Amount;
        
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