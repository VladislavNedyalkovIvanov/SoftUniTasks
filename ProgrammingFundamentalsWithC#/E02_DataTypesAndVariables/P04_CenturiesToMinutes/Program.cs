using System;

namespace P04_CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = Math.Floor(years * 365.2422);
            long days1 = (long)days;
            long hours = days1 * 24;
            ulong minutes = (ulong)(hours * 60);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
