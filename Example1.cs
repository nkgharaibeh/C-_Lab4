using System;

namespace Lab4_Example1
{
    class Person
    {
        // without Encapsulation (fields are public)
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
//هذا المثال يبيّن المشكلة: نستطيع وضع Age = -5 بسهولة → انتهاك لسلامة البيانات.
            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            Console.ReadLine();
        }
    }
}
