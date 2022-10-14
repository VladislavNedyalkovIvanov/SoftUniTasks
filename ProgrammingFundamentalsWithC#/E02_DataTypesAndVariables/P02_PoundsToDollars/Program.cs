using System;

namespace P02_PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());
            decimal unitetStatesDollars = britishPounds * 1.31m;
            Console.WriteLine($"{unitetStatesDollars:f3}");
        }
    }
}
