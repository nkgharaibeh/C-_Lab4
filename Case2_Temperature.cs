using System;

namespace Lab4_Case2_Temperature
{
    class Temperature
    {
        private double celsius;

        public double Celsius
        {
            get { return celsius; }
            set
            {
                if (value >= -273.15 && value <= 1000)
                    celsius = value;
                else
                    Console.WriteLine("Invalid temperature value!");
            }
        }

        // Read-only property
        public double Fahrenheit
        {
            get { return (celsius * 9 / 5) + 32; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();
            t.Celsius = 25;

            Console.WriteLine("Temperature in Celsius: " + t.Celsius);
            Console.WriteLine("Temperature in Fahrenheit: " + t.Fahrenheit);

            Console.ReadLine();
        }
    }
}
