using System;
namespace BankAccountLibrary
{
    public class Amount
    {
        public int Value
        {
            get;
            private set;
        }

        public Amount(int amount)
        {
            Value = amount;
        }

        internal static bool IsValid(Amount amount)
        {
            return amount != null && amount.Value >= 0;
        }
    }
}
