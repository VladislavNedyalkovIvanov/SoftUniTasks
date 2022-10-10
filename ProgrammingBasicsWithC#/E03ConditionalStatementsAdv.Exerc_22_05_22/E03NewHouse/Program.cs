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

            double price = 0;
            double discount = 0;
            double addPrice = 0;
            double totalPrice = 0;

            switch(typeOfFlowers)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3;
                    break;
                case "Gladiolus":
                    price = 2.50;
                    break;
            }
            totalPrice = numberFlowers * price;

            if (typeOfFlowers == "Roses")
            {
                if (numberFlowers > 80)
                {
                    discount = totalPrice * 0.1;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (numberFlowers > 90)
                {
                    discount = totalPrice * 0.15;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (numberFlowers > 80)
                {
                    discount = totalPrice * 0.15;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (numberFlowers < 120)
                {
                    addPrice = totalPrice * 0.15;
                }
            }    
            else if (typeOfFlowers == "Gladiolus")
            {
                if (numberFlowers < 80)
                {
                    addPrice = totalPrice * 0.20;
                }
            }


            double totalPriceAfterDiscAndAdd = totalPrice - discount + addPrice;

            double allLeft = budget - totalPriceAfterDiscAndAdd;
            double allNeeds = totalPriceAfterDiscAndAdd - budget;

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
