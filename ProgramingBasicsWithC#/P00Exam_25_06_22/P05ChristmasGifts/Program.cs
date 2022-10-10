using System;

namespace P05ChristmasGifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yearsAge = Console.ReadLine();
            int kids = 0;
            int adults = 0;

            int pricePerToy = 5;
            int pricePerPullover = 15;
            while (yearsAge != "Christmas")
            {
                if (yearsAge == "Christmas")
                {
                    break;
                }
                int yearsAgeWhile = int.Parse(yearsAge);
                if (yearsAgeWhile <= 16)
                {
                    kids++;
                }
                else
                {
                    adults++;
                }
                yearsAge = Console.ReadLine();
            }
            int totalForToys = kids * pricePerToy;
            int totalForPullover = adults * pricePerPullover;
            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {totalForToys}");
            Console.WriteLine($"Money for sweaters: {totalForPullover}");
        }
    }
}
