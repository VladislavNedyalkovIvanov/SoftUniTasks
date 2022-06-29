using System;

namespace P04Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double kilometers = double.Parse(Console.ReadLine());
            double allKilometers = 0;
            allKilometers += kilometers;
            double kilometersAdd = 0;
            for (int i = 1; i <= n; i++)
            {
                kilometersAdd = double.Parse(Console.ReadLine());
                kilometersAdd = kilometersAdd * 0.01;
                kilometersAdd = kilometers * kilometersAdd;
                kilometers += kilometersAdd;
                allKilometers += kilometers;


            }
            if (allKilometers >= 1000)
            {
                allKilometers -= 1000;
                allKilometers = Math.Ceiling(allKilometers);
                Console.WriteLine($"You've done a great job running {allKilometers} more kilometers!");
            }
            else if (allKilometers < 1000)
            {
                allKilometers = 1000 - allKilometers;
                allKilometers = Math.Ceiling(allKilometers);
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {allKilometers} more kilometers");
            }
        }
    }
}
