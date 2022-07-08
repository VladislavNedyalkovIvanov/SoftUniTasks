using System;

namespace P06TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine(); //"Spring", "Summer", "Autumn" или "Winter"
            double kilometersPerMount = double.Parse(Console.ReadLine());
            double pricePerKilometer = 0;

            if (kilometersPerMount <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                        pricePerKilometer = 0.75;
                        break;
                    case "Autumn":
                        pricePerKilometer = 0.75;
                        break;
                    case "Summer":
                        pricePerKilometer = 0.90;
                        break;
                    case "Winter":
                        pricePerKilometer = 1.05;
                        break;
                }    
            }
            else if (kilometersPerMount > 5000 && kilometersPerMount <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                        pricePerKilometer = 0.95;
                        break;
                    case "Autumn":
                        pricePerKilometer = 0.95;
                        break;
                    case "Summer":
                        pricePerKilometer = 1.10;
                        break;
                    case "Winter":
                        pricePerKilometer = 1.25;
                        break;
                }
            }
            else if (kilometersPerMount > 10000 && kilometersPerMount <= 20000)
            {
                pricePerKilometer = 1.45;
            }
            double allForDriver = pricePerKilometer * (kilometersPerMount * 4);
            allForDriver -= allForDriver * 0.1;

            Console.WriteLine($"{allForDriver:f2}");
        }
    }
}
