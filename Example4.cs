using System;
// Auto-Implemented Properties and show an object initializer
namespace Lab4_Example4
{
    class Car
    {
        public string Brand { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car
            {
                Brand = "Toyota",
                Price = 15000
            };
// The { Brand = "Toyota", Price = 15000 } syntax is called an object initializer. It is a concise way to set the properties of the object immediately after creating it.
            
            Console.WriteLine($"Brand: {c.Brand}, Price: {c.Price}");
            Console.ReadLine();
        }
    }
}
