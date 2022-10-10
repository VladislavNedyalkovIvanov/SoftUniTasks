using System;

namespace P02SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vacantionDays = int.Parse(Console.ReadLine());
            int maximumPlayHoursPerYear = 30000;
            int daysOfYear = 365;
            int workMinutesPlay = 63;
            int freeMinutesPlay = 127;

            int playTimeFreeDays = vacantionDays * freeMinutesPlay;

            int workingDays = daysOfYear - vacantionDays;
            int playTimeWorkDays = workingDays * workMinutesPlay;

            int allPlayTimeForYear = playTimeFreeDays + playTimeWorkDays;

            if (allPlayTimeForYear > maximumPlayHoursPerYear)
            {
                int timeLessFromNorm = allPlayTimeForYear - maximumPlayHoursPerYear;
                int hoursPlayTime = timeLessFromNorm / 60;
                int minutesPlayTime = timeLessFromNorm % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hoursPlayTime} hours and {minutesPlayTime} minutes more for play");
            }
            else
            {
                int timeOverNorm = maximumPlayHoursPerYear - allPlayTimeForYear;
                int hoursPlayTime = timeOverNorm / 60;
                int minutesPlayTime = timeOverNorm % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hoursPlayTime} hours and {minutesPlayTime} minutes less for play");
            }

        }
    }
}
