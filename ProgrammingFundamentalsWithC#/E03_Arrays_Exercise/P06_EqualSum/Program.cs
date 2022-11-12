using System;
using System.Linq;

namespace P06_EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isNumbersEqual = false;
            int numberEual = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += numbers[j];
                }
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    sumRight += numbers[k];
                }
                if (sumLeft == sumRight)
                {
                    isNumbersEqual = true;
                    numberEual = i;
                }
            }
            if (isNumbersEqual)
            {
                Console.WriteLine(numberEual);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
