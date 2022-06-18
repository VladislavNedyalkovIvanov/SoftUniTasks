using System;

namespace P04Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int purpose = 10000;
            int stepsAll = 0;

            string stop;
            while ((stop = Console.ReadLine()) != "Going home")
            {
                int steps = int.Parse(stop);
                stepsAll += steps;
                if (stepsAll > purpose)
                {
                    break;
                }
            }

            if (stepsAll < purpose)
            {
                int steps = int.Parse(Console.ReadLine());
                stepsAll += steps;
                if (stepsAll < purpose)
                {
                    stepsAll = purpose - stepsAll;
                    Console.WriteLine($"{stepsAll} more steps to reach goal.");
                }
            }
            if (stepsAll >= purpose)
            {
                int stepsOver = stepsAll - purpose;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
        }
    }
}
