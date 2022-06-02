using System;

namespace P01ExcellentResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
