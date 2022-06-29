using System;

namespace P06GoldMine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int locationN = int.Parse(Console.ReadLine());
            for (int i = 1; i <= locationN; i++)
            {
                double expectedGoldForLocation = double.Parse(Console.ReadLine());
                int daysForLocation = int.Parse(Console.ReadLine());
                double goldFromLocation = 0;
                for (int d = 1; d <= daysForLocation; d++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    goldFromLocation += goldPerDay;
                }
                double averageGoldPerDay = goldFromLocation / daysForLocation;
                if (expectedGoldForLocation <= averageGoldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDay:f2}.");
                }
                else
                {
                    double needMoreGold = expectedGoldForLocation - averageGoldPerDay;
                    Console.WriteLine($"You need {needMoreGold:f2} gold.");
                }
                  
            }

        }
    }
}
