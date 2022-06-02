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

            decimal price = 0m;
            decimal discount = 0m;
            decimal totalPrice = 0m;

            if (season == "Spring")
            {
                price = 3000m;
                if (numberOfFishers <= 6)
                {
                    discount = price * 0.10m;
                }
                else if (numberOfFishers >= 7 && numberOfFishers <= 11)
                {
                    discount = price * 0.15m;
                }
                else if (numberOfFishers >= 12)
                {
                    discount = price * 0.25m;
                }
            }
            else if (season == "Summer")
            {
                price = 4200m;
                if (numberOfFishers <= 6)
                {
                    discount = price * 0.10m;
                }
                else if (numberOfFishers >= 7 && numberOfFishers <= 11)
                {
                    discount = price * 0.15m;
                }
                else if (numberOfFishers >= 12)
                {
                    discount = price * 0.25m;
                }
            }
            else if (season == "Autumn")
            {
                price = 4200m;
                if (numberOfFishers <= 6)
                {
                    discount = price * 0.10m;
                }
                else if (numberOfFishers >= 7 && numberOfFishers <= 11)
                {
                    discount = price * 0.15m;
                }
                else if (numberOfFishers >= 12)
                {
                    discount = price * 0.25m;
                }
            }
            else if (season == "Winter")
            {
                price = 2600m;
                if (numberOfFishers <= 6)
                {
                    discount = price * 0.10m;
                }
                else if (numberOfFishers >= 7 && numberOfFishers <= 11)
                {
                    discount = price * 0.15m;
                }
                else if (numberOfFishers >= 12)
                {
                    discount = price * 0.25m;
                }
            }

            totalPrice = price - discount;
            decimal bonusDiscount = 0m;

            if (season != "Autumn")
            {
                if (numberOfFishers % 2 == 0)
                {
                    bonusDiscount = totalPrice * 0.05m;
                }
            }

            totalPrice = totalPrice - bonusDiscount;

            if (price > 0)
            {
                if (totalPrice <= boudget)
                {
                    decimal allLeft = boudget - totalPrice;
                    Console.WriteLine($"Yes! You have {allLeft:f2} leva left.");
                }
                else if (totalPrice > boudget)
                {
                    decimal allNeeds = totalPrice - boudget;
                    Console.WriteLine($"Not enough money! You need {allNeeds:f2} leva.");
                }    
            }
        }
    }
}
