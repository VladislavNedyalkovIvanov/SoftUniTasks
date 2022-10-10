using System;

namespace P02WeekendOrWorking_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string workingOrWeekendDay = Console.ReadLine();

            switch (workingOrWeekendDay)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
