using System;
using System.Linq;
using System.Reflection;

namespace P07_EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] numbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool numbersSame = true;

            if (numbers1.Length != numbers2.Length)
            {
                numbersSame = false;
            }
            int i = 0;
            for (i = 0; i < numbers1.Length && i < numbers2.Length; i++)
            {
                if (numbers1[i] != numbers2[i])
                {
                    numbersSame = false;
                    break;
                }
                sum += numbers1[i];
            }
            if (numbersSame == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            }
        }
    }
}
