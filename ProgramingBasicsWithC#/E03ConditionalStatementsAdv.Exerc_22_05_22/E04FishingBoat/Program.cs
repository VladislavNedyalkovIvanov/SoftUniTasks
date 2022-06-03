using System;

namespace E04FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishers = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;
            double totalPrice = 0;


            switch(season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                    price = 4200;
                    break;
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;

            }


            if (numberOfFishers <= 6)
            {
                discount = price * 0.10;
            }
            else if (numberOfFishers >= 7 && numberOfFishers <= 11)
            {
                discount = price * 0.15;
            }
            else if (numberOfFishers >= 12)
            {
                discount = price * 0.25;
            }


            totalPrice = price - discount;
            double bonusDiscount = 0;

            if (season != "Autumn")
            {
                if (numberOfFishers % 2 == 0)
                {
                    bonusDiscount = totalPrice * 0.05;
                }
            }

            totalPrice = totalPrice - bonusDiscount;

            if (price > 0)
            {
                if (totalPrice <= boudget)
                {
                    double allLeft = boudget - totalPrice;
                    Console.WriteLine($"Yes! You have {allLeft:f2} leva left.");
                }
                else if (totalPrice > boudget)
                {
                    double allNeeds = totalPrice - boudget;
                    Console.WriteLine($"Not enough money! You need {allNeeds:f2} leva.");
                }    
            }
        }
    }
}
