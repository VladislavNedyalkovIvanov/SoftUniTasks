using System;

namespace P03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPplOnVacantion = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            if (typeOfGroup == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 8.45; break;
                    case "Saturday": price = 9.80; break;
                    case "Sunday": price = 10.46; break;
                }

            }
            else if (typeOfGroup == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 10.90; break;
                    case "Saturday": price = 15.60; break;
                    case "Sunday": price = 16; break;
                }
                if (countOfPplOnVacantion >= 100)
                {
                    countOfPplOnVacantion = countOfPplOnVacantion - 10;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday": price = 15; break;
                    case "Saturday": price = 20; break;
                    case "Sunday": price = 22.50; break;
                }
            }

            double totalForPay = price * countOfPplOnVacantion;

            if (typeOfGroup == "Students" && countOfPplOnVacantion >= 30)
            {
                totalForPay = totalForPay - (totalForPay * 0.15);
            }
            if (typeOfGroup == "Regular" && countOfPplOnVacantion >= 10 && countOfPplOnVacantion <= 20)
            {
                totalForPay = totalForPay - (totalForPay * 0.05);
            }


            Console.WriteLine($"Total price: {totalForPay:f2}");
        }
    }
}
