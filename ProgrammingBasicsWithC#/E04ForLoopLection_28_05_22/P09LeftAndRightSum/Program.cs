using System;

namespace P09LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max1 = 0;
            int max2 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number1_1 = int.Parse(Console.ReadLine());
                max1 += number1_1;
            }
            for (int m = 1; m <= n; m++)
            {
                int number2_2 = int.Parse(Console.ReadLine());
                max2 += number2_2;
            }
            if (max1 == max2)
            {
                Console.WriteLine($"Yes, sum = {max1}");
            }
            else
            {
                double sum = 0;
                if (max1 > max2)
                {
                    sum = max1 - max2;
                }
                else if (max2 > max1)
                {
                    sum = max2 - max1;
                }
              
                Console.WriteLine($"No, diff = {sum}");
            }
        }
    }
}
