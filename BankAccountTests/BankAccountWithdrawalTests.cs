using System;
using BankAccountLibrary;
using NFluent;
using NUnit.Framework;

namespace BankAccountTests
{
    public class BankAccountWithdrawalTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BankAccount_AmountWithdrawal_Decreases_Balance()
        {
            //Given
            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(1000);
            Balance oldBalance = bankAccount.Balance;

            //When
            bankAccount.Withdrawal(amount);
            Balance expectedBalance = oldBalance - amount;

            //Then
            Check.That(bankAccount.Balance).Equals(expectedBalance);
        }


        [Test]
        public void BankAccount_MultipleAmountWithdrawal_Decreases_Balance()
        {
            //Given
            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(1000);
            Balance oldBalance = bankAccount.Balance;

            //When
            bankAccount.Withdrawal(amount);
            bankAccount.Withdrawal(amount);
            bankAccount.Withdrawal(amount);

            Balance expectedBalance = oldBalance
                - amount
                - amount
                - amount;

            //Then
            Check.That(bankAccount.Balance).Equals(expectedBalance);
        }


    }
}