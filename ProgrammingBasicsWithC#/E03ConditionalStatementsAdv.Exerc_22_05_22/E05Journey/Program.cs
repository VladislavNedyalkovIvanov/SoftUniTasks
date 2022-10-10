using System;

namespace E05Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal boudget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            decimal boudgetForVacantion = 0m;
            string destination = "";
            string placeForSleep = "";

            if (boudget <= 100m)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    placeForSleep = "Camp";
                    boudgetForVacantion = boudget * 0.30m;
                }
                else if (season == "winter")
                {
                    placeForSleep = "Hotel";
                    boudgetForVacantion = boudget * 0.70m;
                }
            }
            else if (boudget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    placeForSleep = "Camp";
                    boudgetForVacantion = boudget * 0.40m;
                }
                else if (season == "winter")
                {
                    placeForSleep = "Hotel";
                    boudgetForVacantion = boudget * 0.80m;
                }
            }
            else if (boudget > 1000)
            {
                destination = "Europe";
                if (season == "summer")
                {
                    placeForSleep = "Hotel";
                    boudgetForVacantion = boudget * 0.90m;
                }
                else if (season == "winter")
                {
                    placeForSleep = "Hotel";
                    boudgetForVacantion = boudget * 0.90m;
                }    

            }

            decimal allCost = boudget - boudgetForVacantion;

            if (boudgetForVacantion != 0)
            {
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{placeForSleep} - {boudgetForVacantion:F2}");
            }
        }
    }
}
