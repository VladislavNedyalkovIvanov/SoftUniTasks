using System;

namespace P02BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax = 0;
            int numberOfJuniors = int.Parse(Console.ReadLine());
            int numberOfSeniors = int.Parse(Console.ReadLine());
            string typeOfTrace = Console.ReadLine();

            if (numberOfJuniors > 0)
            {
                switch (typeOfTrace)
                {
                    case "trail":
                        tax += 5.50 * numberOfJuniors;
                        break;
                    case "cross-country":
                        tax += 8 * numberOfJuniors;
                        break;
                    case "downhill":
                        tax += 12.25 * numberOfJuniors;
                        break;
                    case "road":
                        tax += 20 * numberOfJuniors;
                        break;
                }
            }
            if (numberOfSeniors > 0)
            {
                switch (typeOfTrace)
                {
                    case "trail":
                        tax += 7 * numberOfSeniors;
                        break;
                    case "cross-country":
                        tax += 9.50 * numberOfSeniors;
                        break;
                    case "downhill":
                        tax += 13.75 * numberOfSeniors;
                        break;
                    case "road":
                        tax += 21.50 * numberOfSeniors;
                        break;
                }
            }
            int allPeople = numberOfJuniors + numberOfSeniors;
            if (typeOfTrace == "cross-country" && allPeople >= 50)
            {
                tax -= tax * 0.25;
            }
            tax -= tax * 0.05;
            Console.WriteLine($"{tax:f2}");
        }
    }
}
