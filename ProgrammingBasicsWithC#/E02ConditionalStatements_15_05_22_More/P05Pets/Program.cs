using System;

namespace P05Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leavedFood = int.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtle = double.Parse(Console.ReadLine());

            foodForDog = foodForDog * days;
            foodForCat = foodForCat * days;
            foodForTurtle = (foodForTurtle * days) / 1000;
            double allNeededFood = foodForDog + foodForCat + foodForTurtle;

            if (leavedFood >= allNeededFood)
            {
                double allLeft = leavedFood - allNeededFood;
                Console.WriteLine($"{Math.Floor(allLeft)} kilos of food left.");
            }
            else
            {
                double allNeed = allNeededFood - leavedFood;
                Console.WriteLine($"{Math.Ceiling(allNeed)} more kilos of food are needed.");
            }
        }
    }
}
