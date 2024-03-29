﻿using System;
using System.Linq;

namespace P04_ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                int firstIndexTemp = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i - 1] = numbers[i];
                }
                numbers[numbers.Length - 1] = firstIndexTemp;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
