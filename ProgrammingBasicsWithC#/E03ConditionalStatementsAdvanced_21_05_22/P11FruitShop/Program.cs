using System;

namespace P11FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayFromWeek = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
     
            decimal price = 0m;
            if (dayFromWeek == "Monday")
            {
                if (fruit == "banana")
                {
                    price = 2.50m;
                }  
                if (fruit == "apple")
                {
                    price = 1.20m;
                }
                if (fruit == "orange")
                {
                    price = 0.85m;
                }
                if (fruit == "grapefruit")
                {
                    price = 1.45m;
                }
                if (fruit == "kiwi")
                {
                    price = 2.70m;
                }
                if (fruit == "pineapple")
                {
                    price = 5.50m;
                }
                if (fruit == "grapes")
                {
                    price = 3.85m;
                }
            }
            else if (dayFromWeek == "Tuesday")
            {
                if (fruit == "banana")
                {
                    price = 2.50m;
                }
                if (fruit == "apple")
                {
                    price = 1.20m;
                }
                if (fruit == "orange")
                {
                    price = 0.85m;
                }
                if (fruit == "grapefruit")
                {
                    price = 1.45m;
                }
                if (fruit == "kiwi")
                {
                    price = 2.70m;
                }
                if (fruit == "pineapple")
                {
                    price = 5.50m;
                }
                if (fruit == "grapes")
                {
                    price = 3.85m;
                }
            }
            else if (dayFromWeek == "Wednesday")
            {
                if (fruit == "banana")
                {
                    price = 2.50m;
                }
                if (fruit == "apple")
                {
                    price = 1.20m;
                }
                if (fruit == "orange")
                {
                    price = 0.85m;
                }
                if (fruit == "grapefruit")
                {
                    price = 1.45m;
                }
                if (fruit == "kiwi")
                {
                    price = 2.70m;
                }
                if (fruit == "pineapple")
                {
                    price = 5.50m;
                }
                if (fruit == "grapes")
                {
                    price = 3.85m;
                }
            }
            else if (dayFromWeek == "Thursday")
            {
                if (fruit == "banana")
                {
                    price = 2.50m;
                }
                if (fruit == "apple")
                {
                    price = 1.20m;
                }
                if (fruit == "orange")
                {
                    price = 0.85m;
                }
                if (fruit == "grapefruit")
                {
                    price = 1.45m;
                }
                if (fruit == "kiwi")
                {
                    price = 2.70m;
                }
                if (fruit == "pineapple")
                {
                    price = 5.50m;
                }
                if (fruit == "grapes")
                {
                    price = 3.85m;
                }
            }
            else if (dayFromWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50m;
                }
                if (fruit == "apple")
                {
                    price = 1.20m;
                }
                if (fruit == "orange")
                {
                    price = 0.85m;
                }
                if (fruit == "grapefruit")
                {
                    price = 1.45m;
                }
                if (fruit == "kiwi")
                {
                    price = 2.70m;
                }
                if (fruit == "pineapple")
                {
                    price = 5.50m;
                }
                if (fruit == "grapes")
                {
                    price = 3.85m;
                }
            }
            else if (dayFromWeek == "Saturday")
            {
                if (fruit == "banana")
                {
                    price = 2.70m;
                }
                if (fruit == "apple")
                {
                    price = 1.25m;
                }
                if (fruit == "orange")
                {
                    price = 0.90m;
                }
                if (fruit == "grapefruit")
                {
                    price = 1.60m;
                }
                if (fruit == "kiwi")
                {
                    price = 3.00m;
                }
                if (fruit == "pineapple")
                {
                    price = 5.60m;
                }
                if (fruit == "grapes")
                {
                    price = 4.20m;
                }
            }
            else if (dayFromWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70m;
                }
                if (fruit == "apple")
                {
                    price = 1.25m;
                }
                if (fruit == "orange")
                {
                    price = 0.90m;
                }
                if (fruit == "grapefruit")
                {
                    price = 1.60m;
                }
                if (fruit == "kiwi")
                {
                    price = 3.00m;
                }
                if (fruit == "pineapple")
                {
                    price = 5.60m;
                }
                if (fruit == "grapes")
                {
                    price = 4.20m;
                }
            }
            decimal totalCost = (decimal)number * price;
            if (totalCost == 0)
            {
                Console.WriteLine("error");

            }
            else
            { 
            Console.WriteLine($"{totalCost:f2}");
            }
        }
    }
}
