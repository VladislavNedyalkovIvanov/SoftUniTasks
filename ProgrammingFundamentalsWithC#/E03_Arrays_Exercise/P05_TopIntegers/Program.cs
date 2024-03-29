﻿using System;
using System.Linq;

namespace P05_TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool betterFromAll = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        betterFromAll = false;
                    }
                }
                if (betterFromAll == true)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
