using System;

namespace Lab4_Example5
{
    class BaseClass
    {
        protected int protectedValue = 100;
        internal string InternalMessage = "Hello from internal member!";
    }

    class Derived : BaseClass
    {
        public void Show()
        {
            // نستطيع الوصول إلى protected من داخل الـ subclass
            Console.WriteLine("Accessing protected value: " + protectedValue);
            Console.WriteLine("Accessing internal message: " + InternalMessage);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.Show();

            Console.ReadLine();
        }
    }
}
