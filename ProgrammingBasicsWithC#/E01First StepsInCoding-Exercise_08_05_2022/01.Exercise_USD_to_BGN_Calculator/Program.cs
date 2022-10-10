using System;

namespace _01.Exercise_USD_to_BGN_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double exchangeUsdToBgn = 1.79549;
            double bgn = usd * exchangeUsdToBgn;
            Console.WriteLine(bgn);

        }
    }
}
