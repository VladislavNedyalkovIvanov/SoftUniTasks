using System;

namespace _08.Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodNeeds = int.Parse(Console.ReadLine());
            int catFoodNeeds = int.Parse(Console.ReadLine());
            double dogFoodPrice = double.Parse("2.5");
            int catFoodPrice = int.Parse("4");
            
            double AllCosts = (dogFoodNeeds * dogFoodPrice) + (catFoodNeeds * catFoodPrice);
            Console.WriteLine($"{AllCosts} lv.");
        }
    }
}
