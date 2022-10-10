using System;

namespace _001.Trapeziod_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            int h2 = 2;

            double trapezoidalFace = (b1 + b2) * (h / h2);
            Console.WriteLine($"{trapezoidalFace:f2}");
        }
    }
}
