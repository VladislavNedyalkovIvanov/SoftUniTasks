using System;
using System.Dynamic;

namespace P07_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double sumOfAllCoins = 0;

            while (coins != "Start")
            {
                double coinsType = double.Parse(coins);
                if (coinsType == 0.1 || coinsType == 0.2 || coinsType == 0.5 || coinsType == 1 || coinsType == 2)
                {
                    sumOfAllCoins += coinsType;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                coins = Console.ReadLine();
            }
            string productForBuy = Console.ReadLine();
            double priceForProduct = 0;

            while (productForBuy != "End")
            {
                switch (productForBuy)
                {
                    case "Nuts": priceForProduct = 2.0; break;
                    case "Water": priceForProduct = 0.7; break;
                    case "Crisps": priceForProduct = 1.5; break;
                    case "Soda": priceForProduct = 0.8; break;
                    case "Coke": priceForProduct = 1.0; break;
                    default: Console.WriteLine("Invalid product"); break;
                }
                if (sumOfAllCoins >= priceForProduct)
                {
                    if (productForBuy == "Nuts" || productForBuy == "Water" || productForBuy == "Crisps" || productForBuy == "Soda" || productForBuy == "Coke")
                    {
                        sumOfAllCoins -= priceForProduct;
                        Console.WriteLine($"Purchased {productForBuy.ToLower()}");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                productForBuy = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumOfAllCoins:f2}");
        }
    }
}
