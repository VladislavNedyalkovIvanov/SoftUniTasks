using System;

namespace P08_TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            ulong area = ulong.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
