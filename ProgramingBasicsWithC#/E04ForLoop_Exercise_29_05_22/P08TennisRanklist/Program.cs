using System;

namespace P08TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournirsN = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int allPoints = 0;
            int pointsFromWins = 0;
            allPoints += startPoints;
            double numberOfWins = 0;
            for (int i = 1; i <= tournirsN; i++)
            {
                string stageOfTour = Console.ReadLine();
                if (stageOfTour == "W")
                {
                    allPoints += 2000;
                    numberOfWins += 1;
                }
                else if (stageOfTour == "F")
                {
                    allPoints += 1200;
                }
                else if (stageOfTour == "SF")
                {
                    allPoints += 720;
                }
            }
            pointsFromWins = allPoints - startPoints;
            double averagePoints = pointsFromWins / (double)tournirsN;
            averagePoints = Math.Floor(averagePoints);
            numberOfWins = (numberOfWins / tournirsN) * 100;

            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{numberOfWins:F2}%");
        }
    }
}
