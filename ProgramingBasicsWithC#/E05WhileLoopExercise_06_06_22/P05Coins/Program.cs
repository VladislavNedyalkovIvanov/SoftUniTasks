using System;

namespace P05Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resto = decimal.Parse(Console.ReadLine());
            int monets = 0;

            while (resto >= 2m)
            {
                resto = resto - 2m;
                monets++;
            }
            while (resto >= 1m)
            {
                resto = resto - 1m;
                monets++;
            }
            while (resto >= 0.50m)
            {
                resto = resto - 0.50m;
                monets++;
            }
            while (resto >= 0.20m)
            {
                resto = resto - 0.20m;
                monets++;
            }
            if (resto >= 0.10m)
            {
                resto = resto - 0.10m;
                monets++;
            }
            if (resto >= 0.05m)
            {
                resto = resto - 0.05m;
                monets++;
            }
            if (resto >= 0.02m)
            {
                resto = resto - 0.02m;
                monets++;
            }
            if (resto >= 0.01m)
            {
                resto = resto - 0.01m;
                monets++;
            }
            Console.WriteLine(monets);
        }
    }
}
