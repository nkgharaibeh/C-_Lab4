using System;

namespace Lab4_Case1_Employee
{
    class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    Console.WriteLine("Invalid salary!");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Name = "Ahmad", Salary = 1200 };
            Employee e2 = new Employee { Name = "Rania", Salary = 2000 };

            e1.Display();
            e2.Display();

            Console.ReadLine();
        }
    }
}
