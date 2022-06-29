using System;

namespace P02ANDProcessors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursPerProcessor = 3;
            int hoursWorkPerPerson = 8;
            double pricePerProcessor = 110.10;

            int neededProcessors = int.Parse(Console.ReadLine());
            int numberOfPersons = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int allWorkingHours = numberOfPersons * workingDays * hoursWorkPerPerson;
            int allProcessors = allWorkingHours / hoursPerProcessor;

            if (neededProcessors <= allProcessors)
            {
                int plusProcessors = allProcessors - neededProcessors;
                double allProofit = plusProcessors * pricePerProcessor;
                Console.WriteLine($"Profit: -> {allProofit:f2} BGN");
            }
            else
            {
                int minusProcessors = neededProcessors - allProcessors;
                double allLooses = minusProcessors * pricePerProcessor;
                Console.WriteLine($"Losses: -> {allLooses:f2} BGN");
            }
        }
    }
}
