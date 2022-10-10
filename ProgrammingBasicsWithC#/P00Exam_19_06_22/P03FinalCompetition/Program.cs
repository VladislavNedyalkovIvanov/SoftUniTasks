using System;

namespace P03FinalCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberDancers = int.Parse(Console.ReadLine());
            double scores = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double moneyReward = 0;
            double costs = 0;

            if (place == "Bulgaria")
            {
                moneyReward = scores * (double)numberDancers;
                if (season == "summer")
                {
                    costs = moneyReward * 0.05;
                    moneyReward -= costs;
                }
                else if (season == "winter")
                {
                    costs = moneyReward * 0.08;
                    moneyReward -= costs;
                }
            }
            else if (place == "Abroad")
            {
                moneyReward = numberDancers * scores;
                double moneyAdd = moneyReward * 0.5;
                moneyReward += moneyAdd;
                if (season == "summer")
                {
                    costs = moneyReward * 0.1;
                    moneyReward -= costs;
                }
                else if (season == "winter")
                {
                    costs = moneyReward * 0.15;
                    moneyReward -= costs;
                }

            }
            double moneyGift = moneyReward * 0.75;
            moneyReward -= moneyGift;
            double moneyPerDancer = moneyReward / numberDancers;

            Console.WriteLine($"Charity - {moneyGift:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");
        }
    }
}
