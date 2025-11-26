using System;

namespace Lab4_Example2
{
    class Person
    {
        private string name;
        private int age;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            if (age >= 0)
                this.age = age;
            else
                Console.WriteLine("Invalid age!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetName("Ahmad");
            p.SetAge(25);
            p.DisplayInfo();

            p.SetAge(-10); // سيطبع Invalid age!
            Console.ReadLine();
        }
    }
}
