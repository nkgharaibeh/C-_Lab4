using System;

namespace StudentRecord
{
    class Student
    {
        private string id;
        private string name;
        private double gpa;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4.0)
                    gpa = value;
                else
                    Console.WriteLine("Invalid GPA value! (0–4)");
            }
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, GPA: {GPA}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { Id = "2025001", Name = "Ali", GPA = 3.2 };
            Student s2 = new Student { Id = "2025002", Name = "Sara", GPA = 4.1 }; // غير صحيحة

            s1.Display();
            s2.Display();

            Console.ReadLine();
        }
    }
}
