using System;

namespace P08CircleAreaPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberR = double.Parse(Console.ReadLine());
            double circleS = Math.PI * (numberR * numberR);

            double circleD = Math.PI * (numberR * 2);

            Console.WriteLine($"{circleS:f2}");
            Console.WriteLine($"{circleD:f2}");
        }
    }
}
