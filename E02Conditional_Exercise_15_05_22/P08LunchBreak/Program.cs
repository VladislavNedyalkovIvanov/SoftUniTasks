using System;

namespace P08LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOFMovie = Console.ReadLine();
            int longMovie = int.Parse(Console.ReadLine());
            int longBreak = int.Parse(Console.ReadLine());
            double allFreeBreak = longBreak - ((longBreak * 0.125) + (longBreak * 0.25));

            if (allFreeBreak >= longMovie)
            {
                double minutesLeft = allFreeBreak - longMovie;
                minutesLeft = Math.Ceiling(minutesLeft);
                Console.WriteLine($"You have enough time to watch {nameOFMovie} and left with {minutesLeft} minutes free time.");
            }    
            else if (allFreeBreak < longMovie)
            {
                double minutesNeed = longMovie - allFreeBreak;
                minutesNeed = Math.Ceiling(minutesNeed);
                Console.WriteLine($"You don't have enough time to watch {nameOFMovie}, you need {minutesNeed} more minutes.");
            }    
        }
    }
}
