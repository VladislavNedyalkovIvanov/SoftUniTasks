using System;

namespace P02_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int biggerDivision = 0;

            if (number % 2 == 0)
            {
                biggerDivision = 2;
            }
            if (number % 3 == 0)
            {
                biggerDivision = 3;
            }
            if (number % 6 == 0)
            {
                biggerDivision = 6;
            }
            if (number % 7 == 0)
            {
                biggerDivision = 7;
            }
            if (number % 10 == 0)
            {
                biggerDivision = 10;
            }
            if (biggerDivision != 0)
            {
                Console.WriteLine($"The number is divisible by {biggerDivision}");
            }    
            else
            {
                Console.WriteLine($"Not divisible");
            }
        }
    }
}
