using System;

namespace _07.Exercise_Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenPrice = 10.35;
            double fishPrice = 12.40;
            double veganPrice = 8.15;
            double deliveryPrice = 2.50;

            double chickenNeeds = double.Parse(Console.ReadLine());
            double fishNeeds = double.Parse(Console.ReadLine());
            double veganNeeds = double.Parse(Console.ReadLine());

            double allWithoutDesert = (chickenNeeds * chickenPrice) + (fishNeeds * fishPrice) + (veganNeeds * veganPrice);
            double percentForDesert = 0.20;
            double desertAll = allWithoutDesert * percentForDesert;

            double allCosts = allWithoutDesert + desertAll + deliveryPrice;

            Console.WriteLine($"{allCosts}");
        }
    }
}
