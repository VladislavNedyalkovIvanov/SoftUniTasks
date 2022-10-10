using System;

namespace P02HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumAll = 0;
            int allLeft = 0;
            int maxCount = int.MinValue;
            int diff = 0;
            for (int i = 1; i <= n; i++)
            {
                int countAll = int.Parse(Console.ReadLine());
                sumAll += countAll;
                if (maxCount < countAll)
                {
                    maxCount = countAll;
                }
            }
            allLeft = sumAll - maxCount;
            if (maxCount == allLeft)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "  + maxCount);
            }
            else if (maxCount < allLeft)
            {
                diff = allLeft - maxCount;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + diff);
            }
            else
            {
                diff = maxCount - allLeft;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + diff);
            }
        }
    }
}
