using System;
using System.Dynamic;

namespace P05_SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool trueOrFalse = false;

            for (int i = 1; i <= n; i++)
            {
                trueOrFalse = false;
                int currentNumber = i;
                int sumCurrentNumb = 0;
                while (currentNumber != 0)
                {
                    int whileNumb = currentNumber % 10;
                    sumCurrentNumb += whileNumb;
                    currentNumber /= 10;
                }
                if (sumCurrentNumb == 5 || sumCurrentNumb == 7 || sumCurrentNumb == 11)
                {
                    trueOrFalse = true;
                    
                }
                Console.WriteLine($"{i} -> {trueOrFalse}");
            }
        }
    }
}
