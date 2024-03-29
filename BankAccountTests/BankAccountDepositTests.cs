using BankAccountLibrary;
using NFluent;
using NUnit.Framework;

namespace BankAccountTests
{
    public class BankAccountDepositTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BankAccount_AmountDeposit_Increases_Balance()
        {
            //Given
            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(1000);
            Balance oldBalance = bankAccount.Balance;

            //When
            bankAccount.Deposit(amount);

            //Then
            Balance expectedBalance = oldBalance + amount;

            Check.That(bankAccount.Balance).Equals(expectedBalance);
        }


        [Test]
        public void BankAccount_MultipleAmountDeposit_Increases_Balance()
        {
            //Given
            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(1000);
            Balance oldBalance = bankAccount.Balance;

            //When
            bankAccount.Deposit(amount);
            bankAccount.Deposit(amount);
            bankAccount.Deposit(amount);

            //Then
            Balance expectedBalance = oldBalance
                + amount
                + amount
                + amount;

            Check.That(bankAccount.Balance).Equals(expectedBalance);
        }

        [Test]
        public void BankAccount_NegativeOrNullAmountDeposit_DoesNotTakeEffect_OnBalance()
        {
            //Given
            BankAccount bankAccount = new BankAccount();
            Amount amount = new Amount(-1000);
            Balance oldBalance = bankAccount.Balance;

            //When
            bankAccount.Deposit(amount);

            //Then
            Check.That(bankAccount.Balance).Equals(oldBalance);
        }
    }
}