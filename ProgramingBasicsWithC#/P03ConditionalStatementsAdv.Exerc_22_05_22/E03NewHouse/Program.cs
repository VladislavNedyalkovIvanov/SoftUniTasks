using System;

namespace E03NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            decimal price = 0m;
            decimal discount = 0m;
            decimal addPrice = 0m;
            decimal totalPrice = 0m;

            if (typeOfFlowers == "Roses")
            {
                price = 5m;
                totalPrice = numberFlowers * price;
                if (numberFlowers > 80)
                {
                    discount = totalPrice * 0.1m;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                price = 3.80m;
                totalPrice = numberFlowers * price;
                if (numberFlowers > 90)
                {
                    discount = totalPrice * 0.15m;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                price = 2.80m;
                totalPrice = numberFlowers * price;
                if (numberFlowers > 80)
                {
                    discount = totalPrice * 0.15m;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                price = 3m;
                totalPrice = numberFlowers * price;
                if (numberFlowers < 120)
                {
                    addPrice = totalPrice * 0.15m;
                }

            }    
            else if (typeOfFlowers == "Gladiolus")
            {
                price = 2.50m;
                totalPrice = numberFlowers * price;
                if (numberFlowers < 80)
                {
                    addPrice = totalPrice * 0.20m;
                }
            }

            decimal totalPriceAfterDiscAndAdd = totalPrice - discount + addPrice;

            decimal allLeft = (decimal)budget - totalPriceAfterDiscAndAdd;
            decimal allNeeds = totalPriceAfterDiscAndAdd - (decimal)budget;

            if (price > 0)
            {
                if (budget >= totalPriceAfterDiscAndAdd)
                {

                    Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {typeOfFlowers} and {allLeft:F2} leva left.");
                }
                else if (budget < totalPriceAfterDiscAndAdd)
                {
                    Console.WriteLine($"Not enough money, you need {allNeeds:F2} leva more.");
                }
            }

        }
    }
}
