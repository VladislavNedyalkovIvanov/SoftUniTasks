using System;

namespace P12_RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fakeNumber = 0;
            int allNumbers = 0;
            bool isThisSpecial = false;
            for (int ch = 1; ch <= n; ch++)
            {
                fakeNumber = ch;
                while (fakeNumber > 0)
                {
                    allNumbers += fakeNumber % 10;
                    fakeNumber /= 10;
                }
                isThisSpecial = (allNumbers == 5) || (allNumbers == 7) || (allNumbers == 11);
                Console.WriteLine("{0} -> {1}", ch, isThisSpecial);
                allNumbers = 0;
            }

        }
    }
}
