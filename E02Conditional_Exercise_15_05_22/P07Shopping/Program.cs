using System;

namespace P07Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            double videoCardPrice = 250;
            int numberVideos = int.Parse(Console.ReadLine());
            double videoAllCost = videoCardPrice * numberVideos;

            double processorPrice = videoAllCost * 0.35;
            double ramMemoryPrice = videoAllCost * 0.10;

            int numberProcessors = int.Parse(Console.ReadLine());
            int numberRams = int.Parse(Console.ReadLine());

            double allCost = (videoCardPrice * numberVideos) + (processorPrice * numberProcessors) + (ramMemoryPrice * numberRams);
            if (numberVideos > numberProcessors)
            {
                allCost = allCost - (allCost * 0.15);
            }    
            if (boudget >= allCost)
            {
                double allLeft = boudget - allCost;
                Console.WriteLine($"You have {allLeft:F2} leva left!");
            }    
            else if (boudget < allCost)
            {
                double allNeeds = allCost - boudget;
                Console.WriteLine($"Not enough money! You need {allNeeds:F2} leva more!");
            }
        }
    }
}
