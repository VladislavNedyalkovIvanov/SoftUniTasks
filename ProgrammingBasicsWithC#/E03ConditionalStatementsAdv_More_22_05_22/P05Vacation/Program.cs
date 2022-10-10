using System;

namespace P05Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = null;
            string placeForSleep = null;
            double allCost = 0;
            if (boudget <= 1000)
            {
                placeForSleep = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        allCost += boudget * 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        allCost += boudget * 0.45;
                        break;
                }
            }
            else if (boudget > 1000 && boudget <= 3000)
            {
                placeForSleep = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        allCost += boudget * 0.80;
                        break;
                    case "Winter":
                        location = "Morocco";
                        allCost += boudget * 0.60;
                        break;
                }
            }
            else if (boudget > 3000)
            {
                placeForSleep = "Hotel";
                allCost += boudget * 0.90;
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        break;
                    case "Winter":
                        location = "Morocco";
                        break;
                }
            }
            Console.WriteLine($"{location} - {placeForSleep} - {allCost:f2}");
        }
    }
}
