using System;

namespace Lab4_Example1
{
    class Person
    {
        public string Name;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Ahmad";
            p.Age = -5;   // قيمة غير منطقية – هنا المشكلة

            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            Console.ReadLine();
        }
    }
}
