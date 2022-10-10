using System;

namespace P08_DivisibleBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberBy3 = 100;

            for (int i = 3; i <= numberBy3; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
