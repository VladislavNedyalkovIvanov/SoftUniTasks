using System;

namespace P01NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool exit = false;
            int addNumber = 1;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int number = 1; number <= rows; number++)
                {
                    Console.Write($"{addNumber} ");
                    if (addNumber >= n)
                    {
                        exit = true;
                        break;
                    }
                    addNumber++;
                }
                Console.WriteLine();
                if (exit == true)
                {
                    break;
                }
            }
        }
    }
}
