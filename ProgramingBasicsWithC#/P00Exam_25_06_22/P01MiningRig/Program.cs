using System;

namespace P01MiningRig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neededVideoCards = 13;
            int neededAdapters = 13;
            int allOthersParts = 1000;

            int pricePerVideoCards = int.Parse(Console.ReadLine());
            int pricePerAdapters = int.Parse(Console.ReadLine());
            double electricityPerDay = double.Parse(Console.ReadLine());
            double proofitPerDay = double.Parse(Console.ReadLine());

            int allForVideoCards = neededVideoCards * pricePerVideoCards;
            int allForAdapters = neededAdapters * pricePerAdapters;
            int allForComputer = allOthersParts + allForVideoCards + allForAdapters;
            double clearProofit = (proofitPerDay - electricityPerDay) * neededVideoCards;
            double daysForFullProofit = allForComputer / clearProofit;
            daysForFullProofit = Math.Ceiling(daysForFullProofit);

            Console.WriteLine(allForComputer);
            Console.WriteLine(daysForFullProofit);
        }
    }
}
