using System;

namespace P09SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();


            int nights = days - 1;

            double totalPrice = 0;
            double priceAdd = 0;
            double priceRed = 0;
            double pricePerNight = 0;

            if (typeOfRoom == "room for one person")
            {
                pricePerNight = 18.00;
                if (evaluation == "positive")
                {
                    totalPrice = nights * pricePerNight;
                    priceAdd = totalPrice * 0.25;
                    totalPrice = priceAdd + totalPrice;
                }
                else if (evaluation == "negative")
                {
                    totalPrice = nights * pricePerNight;
                    priceRed = totalPrice * 0.10;
                    totalPrice = totalPrice - priceRed;
                }
            }
            else if (typeOfRoom == "apartment")
            {
                pricePerNight = 25.00;
                if (days < 10)
                {
                    totalPrice = nights * pricePerNight;
                    priceRed = totalPrice * 0.30;
                    totalPrice = totalPrice - priceRed;
                    if (evaluation == "positive")
                    {
                        priceAdd = totalPrice * 0.25;
                        totalPrice = priceAdd + totalPrice;
                    }
                    else if (evaluation == "negative")
                    {
                        priceRed = totalPrice * 0.10;
                        totalPrice = totalPrice - priceRed;
                    }
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice = nights * pricePerNight;
                    priceRed = totalPrice * 0.35;
                    totalPrice = totalPrice - priceRed;
                    if (evaluation == "positive")
                    {
                        priceAdd = totalPrice * 0.25;
                        totalPrice = priceAdd + totalPrice;
                    }
                    else if (evaluation == "negative")
                    {
                        priceRed = totalPrice * 0.10;
                        totalPrice = totalPrice - priceRed;
                    }
                }
                else if (days > 15)
                {
                    totalPrice = nights * pricePerNight;
                    priceRed = totalPrice * 0.50;
                    totalPrice = totalPrice - priceRed;
                    if (evaluation == "positive")
                    {
                        priceAdd = totalPrice * 0.25;
                        totalPrice = priceAdd + totalPrice;
                    }
                    else if (evaluation == "negative")
                    {
                        priceRed = totalPrice * 0.10;
                        totalPrice = totalPrice - priceRed;
                    }
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                pricePerNight = 35.00;
                if (days < 10)
                {
                    totalPrice = nights * pricePerNight;
                    priceRed = totalPrice * 0.10;
                    totalPrice = totalPrice - priceRed;
                    if (evaluation == "positive")
                    {
                        priceAdd = totalPrice * 0.25;
                        totalPrice = priceAdd + totalPrice;
                    }
                    else if (evaluation == "negative")
                    {
                        priceRed = totalPrice * 0.10;
                        totalPrice = totalPrice - priceRed;
                    }
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice = nights * pricePerNight;
                    priceRed = totalPrice * 0.15;
                    totalPrice = totalPrice - priceRed;
                    if (evaluation == "positive")
                    {
                        priceAdd = totalPrice * 0.25;
                        totalPrice = priceAdd + totalPrice;
                    }
                    else if (evaluation == "negative")
                    {
                        priceRed = totalPrice * 0.10;
                        totalPrice = totalPrice - priceRed;
                    }
                }
                else if (days > 15)
                {
                    totalPrice = nights * pricePerNight;
                    priceRed = totalPrice * 0.20;
                    totalPrice = totalPrice - priceRed;
                    if (evaluation == "positive")
                    {
                        priceAdd = totalPrice * 0.25;
                        totalPrice = priceAdd + totalPrice;
                    }
                    else if (evaluation == "negative")
                    {
                        priceRed = totalPrice * 0.10;
                        totalPrice = totalPrice - priceRed;
                    }
                }
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
