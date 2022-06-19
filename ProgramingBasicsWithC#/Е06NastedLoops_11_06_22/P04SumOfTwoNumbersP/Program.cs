using System;

namespace _04SumOfTwoNumbersP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intervalDown = int.Parse(Console.ReadLine());
            int intervalUp = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int numberOfCombinations = 0;

            bool flag = false;

            for (int x1 = intervalDown; x1 <= intervalUp; x1++)
            {
                for (int x2 = intervalDown; x2 <= intervalUp; x2++)
                {
                    numberOfCombinations++;
                    if (x1 + x2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{numberOfCombinations} ({x1} + {x2} = {magicNumber})");
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag == false)

            {
                Console.WriteLine($"{numberOfCombinations} combinations - neither equals {magicNumber}");
            }

        }
    }
}
