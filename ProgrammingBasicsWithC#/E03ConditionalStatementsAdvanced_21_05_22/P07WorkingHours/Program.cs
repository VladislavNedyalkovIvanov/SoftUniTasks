using System;

namespace P07WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayFromWeek = Console.ReadLine();

            string openOrClosed = "closed";
            // работното време на офисът е от 10-18 часа
            if (dayFromWeek == "Monday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    openOrClosed = "open";
                }
            }
            else if (dayFromWeek == "Tuesday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    openOrClosed = "open";
                }
            }
            else if (dayFromWeek == "Wednesday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    openOrClosed = "open";
                }
            }
            else if (dayFromWeek == "Thursday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    openOrClosed = "open";
                }
            }
            else if (dayFromWeek == "Friday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    openOrClosed = "open";
                }
            }
            else if (dayFromWeek == "Saturday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    openOrClosed = "open";
                }
            }
            Console.WriteLine(openOrClosed);
        }
    }
}
