using System;

namespace P10MultiplyBy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (number >= 0)
            {
                if (number < 0)
                {
                    break;
                }
                double numberXtwo = number * 2;
                Console.WriteLine($"Result: {numberXtwo:f2}");
                number = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        }
    }
}
