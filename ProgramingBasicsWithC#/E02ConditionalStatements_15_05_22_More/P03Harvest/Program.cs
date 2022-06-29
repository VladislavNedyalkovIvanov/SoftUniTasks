using System;

namespace P03Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double vineMeters = x * 0.4;
            double grapes = vineMeters * y;
            double literWine = grapes / 2.5;

            if (z <= literWine)
            {
                double wineForWorkers = literWine - z;
                double wineForWorker = wineForWorkers / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(literWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineForWorkers)} liters left -> {Math.Ceiling(wineForWorker)} liters per person.");
            }
            else
            {
                double neededWine = z - literWine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine)} liters wine needed.");
            }    
        }
    }
}
