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

        [Test]
        public void MakeSeveralDeposit_RegistersSeveralBankAccountTransaction_InTransactionList()
        {
            //Given
            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(100);

            //When
            bankAccount.Deposit(amount);
            bankAccount.Deposit(amount);
            bankAccount.Deposit(amount);

            //Then
            const int transactionsExpected = 3;
            
            Check.That(bankAccount.Transactions.Count).Equals(transactionsExpected);
        }
        
        [Test]
        public void MakeSeveralWithdrawal_RegistersSeveralBankAccountTransaction_InTransactionList()
        {
            //Given
            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(100);

            //When
            bankAccount.Withdrawal(amount);
            bankAccount.Withdrawal(amount);
            bankAccount.Withdrawal(amount);

            //Then
            const int transactionsExpected = 3;
            
            Check.That(bankAccount.Transactions.Count).Equals(transactionsExpected);
        }
    }
}
