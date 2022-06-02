using System;

namespace P02.Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countryTr = double.Parse(Console.ReadLine());
            double heightTr = double.Parse(Console.ReadLine());
            double face = countryTr * heightTr / 2;

            Console.WriteLine($"{face:f2}");
        }
    }
}
