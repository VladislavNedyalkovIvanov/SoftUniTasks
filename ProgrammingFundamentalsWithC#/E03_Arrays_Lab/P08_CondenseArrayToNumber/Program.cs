using System;
using System.Globalization;
using System.Linq;

namespace P08_CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] condensed = new int[numbers.Length];
            int rounds = numbers.Length;

            while (rounds > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                    numbers[i] = condensed[i];
                }
                rounds--;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
