using System;
using System.Text;
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

        [Test]
        public void BankAccount_Balance_IsDeductedFrom_Transactions()
        {
            //Given
            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(100);
            
            //When
            bankAccount.Deposit(amount);
            bankAccount.Deposit(amount);
            bankAccount.Withdrawal(amount);
            bankAccount.Deposit(amount);
            bankAccount.Withdrawal(amount);

            //Then
            Check.That(bankAccount.Balance.Value).Equals(100);
        }
        
        [Test]
        public void BankAccount_TransactionsHistorical_Output()
        {

            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(1000);

            //When
            bankAccount.Deposit(amount);
            bankAccount.Deposit(amount);
            bankAccount.Deposit(amount);
            bankAccount.Withdrawal(amount);
            bankAccount.Deposit(amount);
            bankAccount.Withdrawal(amount);

            //Then
            var transactionHistorical = bankAccount.Transactions.ToString();
            var expectedDate = new TransactionDate().Value;

            var expectedOutput = new StringBuilder()
                .AppendLine()
                .AppendLine($"Date = {expectedDate}	DEPOSIT	Amount = 1000	Balance = 1000")
                .AppendLine($"Date = {expectedDate}	DEPOSIT	Amount = 1000	Balance = 2000")
                .AppendLine($"Date = {expectedDate}	DEPOSIT	Amount = 1000	Balance = 3000")
                .AppendLine($"Date = {expectedDate}	WITHDRAWAL	Amount = 1000	Balance = 2000")
                .AppendLine($"Date = {expectedDate}	DEPOSIT	Amount = 1000	Balance = 3000")
                .AppendLine($"Date = {expectedDate}	WITHDRAWAL	Amount = 1000	Balance = 2000")
                .ToString();
            Check.That(transactionHistorical).IsEqualTo(expectedOutput);
        }
    }
}
