using System;

namespace P08CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayFromWeek = Console.ReadLine();
            int price = 0;

            if (dayFromWeek == "Monday")
            {
                price = 12;
            }
            else if (dayFromWeek == "Tuesday")
            {
                price = 12;
            }
            else if (dayFromWeek == "Wednesday")
            {
                price = 14;
            }
            else if (dayFromWeek == "Thursday")
            {
                price = 14;
            }
            else if (dayFromWeek == "Friday")
            {
                price = 12;
            }
            else if (dayFromWeek == "Saturday")
            {
                price = 16;
            }
            else if (dayFromWeek == "Sunday")
            {
                price = 16;
            }
            Console.WriteLine(price);
        }
    }
}
