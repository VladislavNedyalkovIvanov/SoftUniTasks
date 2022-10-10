using System;

namespace _04.Exercice_Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysForReading = int.Parse(Console.ReadLine());
            int howMuchHoursPerDay = (pagesInBook / pagesPerHour) / daysForReading;
            Console.WriteLine(howMuchHoursPerDay);
        }
    }
}
