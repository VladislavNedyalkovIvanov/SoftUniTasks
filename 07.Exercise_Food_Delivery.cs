using System;

namespace _07.Exercise_Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenPrice = double.Parse("10.35");
            double fishPrice = double.Parse("12.40");
            double veganPrice = double.Parse("8.15");
            double deliveryPrice = double.Parse("2.50");

            double chickenNeeds = double.Parse(Console.ReadLine());
            double fishNeeds = double.Parse(Console.ReadLine());
            double veganNeeds = double.Parse(Console.ReadLine());

            double allWithoutDesert = (chickenNeeds * chickenPrice) + (fishNeeds * fishPrice) + (veganNeeds * veganPrice);
            double percentForDesert = double.Parse("0.20");
            double desertAll = allWithoutDesert * percentForDesert;

            double allCosts = allWithoutDesert + desertAll + deliveryPrice;

            Console.WriteLine($"{allCosts}");
        }
    }
}
