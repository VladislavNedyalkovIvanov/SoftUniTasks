using System;

namespace P12TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());

            double totalCommision = 0;
            double totalPercent = 0;
            if (town == "Sofia")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    totalPercent = 0.05;
                    totalCommision = salesVolume * totalPercent;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    totalPercent = 0.07;
                    totalCommision = salesVolume * totalPercent;
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    totalPercent = 0.08;
                    totalCommision = salesVolume * totalPercent;
                }
                else if (salesVolume > 10000)
                {
                    totalPercent = 0.12;
                    totalCommision = salesVolume * totalPercent;
                }
            }
            else if (town == "Varna")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    totalPercent = 0.045;
                    totalCommision = salesVolume * totalPercent;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    totalPercent = 0.075;
                    totalCommision = salesVolume * totalPercent;
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    totalPercent = 0.10;
                    totalCommision = salesVolume * totalPercent;
                }
                else if (salesVolume > 10000)
                {
                    totalPercent = 0.13;
                    totalCommision = salesVolume * totalPercent;
                }
            }
            else if (town == "Plovdiv")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    totalPercent = 0.055;
                    totalCommision = salesVolume * totalPercent;
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    totalPercent = 0.08;
                    totalCommision = salesVolume * totalPercent;
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    totalPercent = 0.12;
                    totalCommision = salesVolume * totalPercent;
                }
                else if (salesVolume > 10000)
                {
                    totalPercent = 0.145;
                    totalCommision = salesVolume * totalPercent;
                }
            }

            if (totalCommision == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{totalCommision:f2}");
            }
        }
    }
}
