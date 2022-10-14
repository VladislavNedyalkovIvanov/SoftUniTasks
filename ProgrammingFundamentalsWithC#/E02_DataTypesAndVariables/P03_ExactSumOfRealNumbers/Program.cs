using System;

namespace P03_ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal allSum = 0m;

            for (int i = 1; i <= n; i++)
            {
                decimal currentNumb = decimal.Parse(Console.ReadLine());
                allSum += currentNumb;
            }
            Console.WriteLine(allSum);
        }
    }
}
