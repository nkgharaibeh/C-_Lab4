using System;

namespace Lab4_BankAccount
{
    class BankAccount
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }  // لا يُعدَّل إلا من داخل الكلاس
        }

        public BankAccount(double initialAmount)
        {
            if (initialAmount >= 0)
                Balance = initialAmount;
            else
                Console.WriteLine("Invalid initial amount!");
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                Console.WriteLine("Invalid deposit amount!");
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient funds or invalid amount!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount(100);
            acc.Deposit(50);
            acc.Withdraw(30);

            Console.WriteLine("Final Balance = " + acc.Balance);
            Console.ReadLine();
        }
    }
}
