using System;
using NUnit.Framework;

class Account
{
    public double Balance { get; private set; }
    public double OverdraftLimit { get; private set; }

    public Account(double overdraftLimit)
    {
        this.OverdraftLimit = overdraftLimit > 0 ? overdraftLimit : 0;
        this.Balance = 0;
    }

    public bool Deposit(double amount)
    {
        if (amount >= 0)
        {
            this.Balance += amount;
            return true;
        }
        return false;
    }

    public bool Withdraw(double amount)
    {
        if (this.Balance - amount >= -this.OverdraftLimit && amount >= 0)
        {
            this.Balance -= amount;
            return true;
        }
        return false;
    }

    [TestFixture]
    public class Tester
    {
        private double epsilon = 1e-6;

        [Test]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            Account account = new Account(-20);

            Assert.AreEqual(0, account.OverdraftLimit, epsilon);
        }

        [Test]
        public void AccountCannotHaveNegativeDeposit(double amount)
        {
            Account account = new Account(-20);

            Assert.AreEqual(true, account.Deposit(amount), "Deposit should be a positive amount");
        }

        [Test]
        public void AccountCannotHaveNegativeWith(double amount)
        {
            Account account = new Account(-20);

            Assert.AreEqual(true, account.Withdraw(amount), "Withdraw should be a positive amount");
        }
    }

    /*
    public static void Main(string[] args)
    {
        Tester test = new Tester();
        test.AccountCannotHaveNegativeOverdraftLimit();
        Console.ReadLine();
    }
    */
}

