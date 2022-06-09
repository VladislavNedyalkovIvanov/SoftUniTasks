using System;

namespace P07SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                sum += currNumber;
            }

            Console.WriteLine(sum); 
        }
    }
}
