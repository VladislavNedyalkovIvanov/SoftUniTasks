using System;

namespace P05HairSalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int purpose = int.Parse(Console.ReadLine());
            int moneyMake = 0;
            while (purpose > moneyMake)
            {
                int moneyAdd = 0;
                string service = Console.ReadLine();
                if (service == "haircut")
                {
                    service = Console.ReadLine();
                    if (service == "mens")
                    {
                        moneyAdd = 15;
                        moneyMake += moneyAdd;
                    }
                    else if (service == "ladies")
                    {
                        moneyAdd = 20;
                        moneyMake += moneyAdd;
                    }
                    else if (service == "kids")
                    {
                        moneyAdd = 10;
                        moneyMake += moneyAdd;
                    }
                }
                else if (service == "color")
                {
                    service = Console.ReadLine();
                    if (service == "touch up")
                    {
                        moneyAdd = 20;
                        moneyMake += moneyAdd;
                    }
                    else if (service == "full color")
                    {
                        moneyAdd = 30;
                        moneyMake += moneyAdd;
                    }
                }
                else if (service == "closed")
                {
                    break;
                }

            }
            if (moneyMake >= purpose)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {moneyMake}lv.");
            }
            else if (moneyMake < purpose)
            {
                double moneyNeeds = purpose - moneyMake;
                Console.WriteLine($"Target not reached! You need {moneyNeeds}lv. more.");
                Console.WriteLine($"Earned money: {moneyMake}lv.");
            }
        }
    }
}
