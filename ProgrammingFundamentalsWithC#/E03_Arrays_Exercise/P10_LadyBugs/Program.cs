using System;
using System.Linq;

namespace P10_LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fieldPlaces = new int[int.Parse(Console.ReadLine())];

            int[] fieldIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < fieldIndexes.Length; i++)
            {
                if (fieldIndexes[i] >= 0 && fieldIndexes[i] < fieldPlaces.Length)
                {
                    fieldPlaces[fieldIndexes[i]] = 1;
                }
            }
            while (true)
            {
                string[] stringPosition = Console.ReadLine()
                    .Split()
                    .ToArray();
                if (stringPosition[0] == "end")
                {
                    break;
                }
                int ladyBugPosition = int.Parse(stringPosition[0]);
                int ladyMovement = int.Parse(stringPosition[2]);
                if (ladyBugPosition < 0 || ladyBugPosition >= fieldPlaces.Length)
                {
                    continue;
                }
                if (fieldPlaces[ladyBugPosition] != 0)
                {
                    fieldPlaces[ladyBugPosition] = 0;
                }
                else
                {
                    continue;
                }
                if (stringPosition[1] == "left")
                {
                    ladyMovement *= -1;
                }
                int placeForLadyBug = ladyBugPosition + ladyMovement;
                while (placeForLadyBug >= 0 && placeForLadyBug < fieldPlaces.Length && fieldPlaces[placeForLadyBug] != 0)
                {
                    placeForLadyBug += ladyMovement;
                }
                if (placeForLadyBug < 0 || placeForLadyBug >= fieldPlaces.Length)
                {
                    continue;
                }
                fieldPlaces[placeForLadyBug] = 1;
            }
            Console.WriteLine(string.Join(" ", fieldPlaces));
        }
    }
}
