using System;

namespace _03Time15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int minuteWith15 = minute + 15;

            if (minuteWith15 >= 60)
            {
                minuteWith15 = minuteWith15 - 60;
                hour = hour + 1;
            }
            if (hour >= 24)
            {
                hour = hour - 24;
            }
            if (minuteWith15 <= 9)
            {
                Console.WriteLine($"{hour}:0{minuteWith15}");
            }    
            else
            {
                Console.WriteLine($"{hour}:{minuteWith15}");
            }
        }
    }
}
