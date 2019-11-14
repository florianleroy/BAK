using System;
namespace BankAccountLibrary
{
    public class Balance
    {
        public int Value
        {
            get;
            private set;
        }

        public Balance()
        {
        }

        public Balance(int value)
        {
            Value = value;
        }

        public static Balance operator+(Balance balance, Amount amount)
        {
            if (amount != null)
                return new Balance(balance.Value + amount.Value);
            return balance;
        }

        public static Balance operator-(Balance balance, Amount amount)
        {
            if (amount != null)
                return new Balance(balance.Value - amount.Value);
            return balance;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value == (obj as Balance).Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
