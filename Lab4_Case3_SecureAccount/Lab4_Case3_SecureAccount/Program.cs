using System;

namespace Lab4_Case3_SecureAccount
{
    class SecureAccount
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public SecureAccount(double initialBalance)
        {
            if (initialBalance >= 0)
                Balance = initialBalance;
            else
                Console.WriteLine("Invalid initial balance!");
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
                Console.WriteLine("Insufficient balance or invalid withdraw!");
        }

        public double GetBalance()
        {
            return Balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SecureAccount acc = new SecureAccount(100);
            acc.Deposit(200);      // Balance = 300
            acc.Withdraw(0);       // أو اسحب قيمة بسيطة للتجربة

            Console.WriteLine("Current Balance: " + acc.GetBalance());
            Console.ReadLine();
        }
    }
}
