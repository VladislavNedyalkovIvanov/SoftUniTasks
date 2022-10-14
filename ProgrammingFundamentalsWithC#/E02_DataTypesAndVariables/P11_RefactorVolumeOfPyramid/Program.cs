using System;

namespace P11_RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double v = ((length * width) / 3) * height;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {v:f2}");

        }
    }
}
