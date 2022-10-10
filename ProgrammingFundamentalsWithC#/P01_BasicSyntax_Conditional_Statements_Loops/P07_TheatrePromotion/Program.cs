using System;

namespace P07_TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int ageOfPerson = int.Parse(Console.ReadLine());

            if (ageOfPerson >= 0 && ageOfPerson <= 18)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("5$");
                        break;
                }
            }
            else if (ageOfPerson > 18 && ageOfPerson <= 64)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        Console.WriteLine("18$");
                        break;
                    case "Weekend":
                        Console.WriteLine("20$");
                        break;
                    case "Holiday":
                        Console.WriteLine("12$");
                        break;
                }
            }
            else if (ageOfPerson > 64 && ageOfPerson <= 122)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("10$");
                        break;
                }
            }   
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
