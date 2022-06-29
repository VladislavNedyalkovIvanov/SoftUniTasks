using System;

namespace P03ComputerRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mount = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int numberOfPpl = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            double prices = 0;

            if (mount == "march" || mount == "april" || mount == "may")
            {
                switch (timeOfDay)
                {
                    case "day":
                        prices = 10.50;
                        break;
                    case "night":
                        prices = 8.40;
                        break;
                }
            }
            else if (mount == "june" || mount == "july" || mount == "august")
            {
                switch (timeOfDay)
                {
                    case "day":
                        prices = 12.60;
                        break;
                    case "night":
                        prices = 10.20;
                        break;
                }
            }
            if (numberOfPpl >= 4)
            {
                prices = prices - (prices * 0.1);
            }
            if (hours >= 5)
            {
                prices = prices - (prices * 0.5);
            }
            Console.WriteLine($"Price per person for one hour: {prices:f2}");
            double totalCost = (numberOfPpl * prices) * hours;
            Console.WriteLine($"Total cost of the visit: {totalCost:f2}");
        }
    }
}
