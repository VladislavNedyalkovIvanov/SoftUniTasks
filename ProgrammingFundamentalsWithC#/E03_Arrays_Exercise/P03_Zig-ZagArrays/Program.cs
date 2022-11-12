using System;
using System.Linq;

namespace P03_Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayZigZag1 = new int[n];
            int[] arrayZigZag2 = new int[n];

            for (int i = 0; i < arrayZigZag1.Length; i++)
            {
                int[] number1 = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    arrayZigZag1[i] = number1[0];
                    arrayZigZag2[i] = number1[1];
                }
                else
                {
                    arrayZigZag2[i] = number1[0];
                    arrayZigZag1[i] = number1[1];
                }
            }
            Console.WriteLine(String.Join(' ', arrayZigZag1));
            Console.WriteLine(String.Join(' ', arrayZigZag2));
        }
    }
}
