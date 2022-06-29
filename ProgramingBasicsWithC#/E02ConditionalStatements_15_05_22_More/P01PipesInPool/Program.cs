using System;

namespace P01PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int litresBasein = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hoursLeft = double.Parse(Console.ReadLine());

            double p1Water = p1 * hoursLeft;
            double p2Water = p2 * hoursLeft;
            double p1andp2 = p1Water + p2Water;

            double percentFromP1 = (p1Water / p1andp2) * 100;
            double percentFromP2 = (p2Water / p1andp2) * 100;

            if (p1andp2 <= litresBasein)
            {

                double percentFull = (p1andp2 / litresBasein) * 100;
                Console.WriteLine($"The pool is {percentFull:f2}% full. Pipe 1: {percentFromP1:f2}%. Pipe 2: {percentFromP2:f2}%.");
            }
            else if (p1andp2 > litresBasein)
            {
                double litresMore = p1andp2 - litresBasein;
                Console.WriteLine($"For {hoursLeft:f2} hours the pool overflows with {litresMore:f2} liters.");
            }
        }
    }
}
