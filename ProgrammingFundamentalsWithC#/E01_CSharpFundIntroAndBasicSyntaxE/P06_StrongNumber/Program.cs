using System;

namespace P06_StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberN = number;
            int thisNumber = 0;
            int sumFactorials = 1;
            int sumOfAll = 0;

            while (numberN != 0)
            {
                thisNumber = (numberN % 10);
                sumFactorials = 1;
                for (int i = 1; i <= thisNumber; i++)
                {
                    sumFactorials *= i;
                }
                sumOfAll += sumFactorials;
                numberN /= 10;
            }
            if (sumOfAll == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
