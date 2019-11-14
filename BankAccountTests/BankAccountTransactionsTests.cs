using System;
using BankAccountLibrary;
using NFluent;
using NUnit.Framework;

namespace BankAccountTests
{
    public class BankAccountTransactionsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TransactionList_IsEmpty_OnNewAccount()
        {
            //Given / When
            BankAccount bankAccount = new BankAccount();

            //Then
            Check.That(bankAccount.Transactions.IsEmpty).Equals(true);
        }
    }
}
