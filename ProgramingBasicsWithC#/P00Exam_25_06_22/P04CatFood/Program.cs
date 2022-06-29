using System;

namespace P04CatFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int groupSmall = 0;
            int groupBig = 0;
            int groupHuge = 0;

            double allFood = 0;
            double pricePerKilogram = 12.45;

            for (int i = 1; i <= n; i++)
            {
                double gramsFood = double.Parse(Console.ReadLine());
                allFood += gramsFood;
                if (gramsFood >= 100 && gramsFood < 200)
                {
                    groupSmall++;
                }    
                else if (gramsFood >= 200 && gramsFood < 300)
                {
                    groupBig++;
                }
                else if (gramsFood >= 300 && gramsFood < 400)
                {
                    groupHuge++;
                }
            }
            double kilogramsFood = allFood / 1000;
            double totalPriceForFood = kilogramsFood * pricePerKilogram;

            Console.WriteLine($"Group 1: {groupSmall} cats.");
            Console.WriteLine($"Group 2: {groupBig} cats.");
            Console.WriteLine($"Group 3: {groupHuge} cats.");
            Console.WriteLine($"Price for food per day: {totalPriceForFood:f2} lv.");
        }
    }
}
