using System;

namespace P05SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int intervalDown = 1111;
            int intervalUp = 9999;
            for (int i = intervalDown; i < intervalUp; i++)
            {

                int iNumb = i;
                bool notSpecial = false;
                for (int j = 1; j <= 4; j++)
                {
                    int lastDigit = iNumb % 10;

                    if (lastDigit == 0)
                    {
                        notSpecial = true;
                        break;
                    }
                    int remainder = number % lastDigit;

                    if(remainder != 0)
                    {
                        notSpecial = true;
                        break;
                    }

                    iNumb /= 10;
                }
                if (notSpecial)
                {
                    continue;
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
