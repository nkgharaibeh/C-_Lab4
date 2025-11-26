using System;

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

            Console.WriteLine($"Brand: {c.Brand}, Price: {c.Price}");
            Console.ReadLine();
        }
    }
}
