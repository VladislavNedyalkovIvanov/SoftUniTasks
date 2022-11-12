using System;
using System.Linq;

namespace P07_MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int firstNumberEqual = 0;
            int firstIndexOfBest = 0;
            int numberOfEqual = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numberOfEqual++;
                    if (numberOfEqual > firstNumberEqual)
                    {
                        firstNumberEqual = numberOfEqual;
                        firstIndexOfBest = i;
                    }
                }
                else
                {
                    numberOfEqual = 1;
                }
            }
            for (int i = 0; i < firstNumberEqual; i++)
            {
                Console.Write($"{numbers[firstIndexOfBest]} ");
            }
        }
    }
}
