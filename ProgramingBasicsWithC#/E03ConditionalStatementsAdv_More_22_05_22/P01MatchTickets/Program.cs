using System;

namespace P01MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForBilet = 0;
            double boudget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfppl = int.Parse(Console.ReadLine());
            double boudgetForTransport = 0;

            switch (category)
            {
                case "VIP":
                    priceForBilet = 499.99;
                    break;
                case "Normal":
                    priceForBilet = 249.99;
                    break;
            }
            if (numberOfppl >= 1 && numberOfppl <= 4)
            {
                boudgetForTransport = boudget * 0.75;
            }
            else if (numberOfppl >= 5 && numberOfppl <= 9)
            {
                boudgetForTransport = boudget * 0.60;
            }
            else if (numberOfppl >= 10 && numberOfppl <= 24)
            {
                boudgetForTransport = boudget * 0.50;
            }
            else if (numberOfppl >= 25 && numberOfppl <= 49)
            {
                boudgetForTransport = boudget * 0.40;
            }
            else
            {
                boudgetForTransport = boudget * 0.25;
            }
            boudget -= boudgetForTransport;
            priceForBilet = priceForBilet * numberOfppl;

            if (priceForBilet <= boudget)
            {
                boudget -= priceForBilet;
                Console.WriteLine($"Yes! You have {boudget:f2} leva left.");
            }
            else
            {
                priceForBilet -= boudget;
                Console.WriteLine($"Not enough money! You need {priceForBilet:f2} leva.");
            }
        }
    }
}
