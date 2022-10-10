using System;

namespace P08PointOnRectangleBorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool border = false;

            if ((x == x1 || x == x2) && (y >= y1 && y <= y2))
            {
                border = true;
            }
            if ((y == y1 || y == y2) && (x >= x1 && x <= x2))
            {
                border = true;
            }

            if (border == true)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
