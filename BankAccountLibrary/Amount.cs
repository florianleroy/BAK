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
    }
}
