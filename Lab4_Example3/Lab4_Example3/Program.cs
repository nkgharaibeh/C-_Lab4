using System;

namespace Lab4_Example3
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age must be positive!");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Rania";
            p.Age = 30;
            p.DisplayInfo();

            p.Age = -3; // سيطبع رسالة خطأ
            Console.ReadLine();
        }
    }
}
