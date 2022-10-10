using System;

namespace P08_TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberN; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
