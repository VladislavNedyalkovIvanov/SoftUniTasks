using System;

namespace E08OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());

            int hourOfStudent = int.Parse(Console.ReadLine());
            int minuteOfStudent = int.Parse(Console.ReadLine());

            int hoursInMinutesExam = (hourOfExam * 60) + minuteOfExam;
            int hoursInMinutesStud = (hourOfStudent * 60) + minuteOfStudent;

            int minutesEarly = 0;
            int hoursEarly = 0;
            int minutesLate = 0;
            int hoursLate = 0;

            if (hoursInMinutesExam >= hoursInMinutesStud)
            {
                minutesEarly = hoursInMinutesExam - hoursInMinutesStud;
                if (minutesEarly == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (minutesEarly <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
                else if (minutesEarly > 30 && minutesEarly < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
                else if (minutesEarly >= 60)
                {
                    hoursEarly = minutesEarly / 60;
                    minutesEarly = minutesEarly % 60;
                    Console.WriteLine("Early");
                    if (minutesEarly < 10)
                    {
                        Console.WriteLine($"{hoursEarly}:0{minutesEarly} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hoursEarly}:{minutesEarly} hours before the start");
                    }
                }

            }
            else if (hoursInMinutesExam < hoursInMinutesStud)
            {
                minutesLate = hoursInMinutesStud - hoursInMinutesExam;
                if (minutesLate > 0 && minutesLate < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutesLate} minutes after the start");
                }
                else if (minutesLate >= 60)
                {
                    hoursLate = minutesLate / 60;
                    minutesLate = minutesLate % 60;
                    Console.WriteLine("Late");
                    if (minutesLate < 10)
                    {
                        Console.WriteLine($"{hoursLate}:0{minutesLate} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hoursLate}:{minutesLate} hours after the start");
                    }
                }

            }
        }
    }
}
