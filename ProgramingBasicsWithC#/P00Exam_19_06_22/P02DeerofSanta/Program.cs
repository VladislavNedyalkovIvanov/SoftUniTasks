using System;

namespace P02DeerofSanta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysSantaMiss = int.Parse(Console.ReadLine());
            int foodInKilograms = int.Parse(Console.ReadLine());
            double foodPerDayInKg1 = double.Parse(Console.ReadLine());
            double foodPerDayInKg2 = double.Parse(Console.ReadLine());
            double foodPerDayInKg3 = double.Parse(Console.ReadLine());

            double firstDeer = foodPerDayInKg1 * daysSantaMiss;
            double secondDeer = foodPerDayInKg2 * daysSantaMiss;
            double thirdDeer = foodPerDayInKg3 * daysSantaMiss;
            double allFoodNeeds = firstDeer + secondDeer + thirdDeer;

            if (allFoodNeeds <= foodInKilograms)
            {
                double allLeft = foodInKilograms - allFoodNeeds;
                double downLeft = Math.Floor(allLeft);
                Console.WriteLine($"{downLeft} kilos of food left.");
            }
            else
            {
                double allNeeds = allFoodNeeds - foodInKilograms;
                double needFood = Math.Ceiling(allNeeds);
                Console.WriteLine($"{needFood} more kilos of food are needed.");
            }
        }
    }
}
