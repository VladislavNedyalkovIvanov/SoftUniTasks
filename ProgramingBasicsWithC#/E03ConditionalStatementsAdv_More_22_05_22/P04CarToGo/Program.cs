using System;

namespace P04CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double priceForCar = 0;
            string daCar = null;
            string typeOfClass;
            if (boudget <= 100)
            {
                typeOfClass = "Economy class";
                switch (season)
                {
                    case "Summer":
                        daCar = "Cabrio";
                        priceForCar = boudget * 0.35;
                        break;
                    case "Winter":
                        daCar = "Jeep";
                        priceForCar = boudget * 0.65;
                        break;
                }
            }
            else if (boudget > 100 && boudget <= 500)
            {
                typeOfClass = "Compact class";
                switch (season)
                {
                    case "Summer":
                        daCar = "Cabrio";
                        priceForCar = boudget * 0.45;
                        break;
                    case "Winter":
                        daCar = "Jeep";
                        priceForCar = boudget * 0.80;
                        break;
                }
            }
            else
            {
                typeOfClass = "Luxury class";
                priceForCar = boudget * 0.90;
                daCar = "Jeep";
            }

            Console.WriteLine($"{typeOfClass}");
            Console.WriteLine($"{daCar} - {priceForCar:f2}");
        }
    }
}
