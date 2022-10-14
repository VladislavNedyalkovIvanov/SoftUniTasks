using System;

namespace P09_SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOdds = int.Parse(Console.ReadLine()) * 2;
            int sumOfOdds = 0;

            for (int i = 1; i <= numberOfOdds; i += 2)
            {
                Console.WriteLine(i);
                sumOfOdds += i;
            }
            Console.WriteLine($"Sum: {sumOfOdds}");
        }
    }
}
