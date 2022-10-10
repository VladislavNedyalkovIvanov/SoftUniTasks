using System;

namespace E07HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mount = Console.ReadLine();
            int numberOfNight = int.Parse(Console.ReadLine());

            decimal discount = 0m;
            decimal pricePerStudio = 0m;
            decimal pricePerApartament = 0m;
            if (mount == "May")
            {
                pricePerStudio = 50m;
                pricePerApartament = 65m;
                if (numberOfNight > 7 && numberOfNight <= 14)
                {
                    discount = 0.05m;
                    pricePerStudio = pricePerStudio - (pricePerStudio * discount);
                }
                else if (numberOfNight > 14)
                {
                    discount = 0.30m;
                    pricePerStudio = pricePerStudio - (pricePerStudio * discount);
                    pricePerApartament = pricePerApartament - (pricePerApartament * 0.10m);
                }
            }
            else if (mount == "October")
            {
                pricePerStudio = 50m;
                pricePerApartament = 65m;
                if (numberOfNight > 7 && numberOfNight <= 14)
                {
                    discount = 0.05m;
                    pricePerStudio = pricePerStudio - (pricePerStudio * discount);
                }
                else if (numberOfNight > 14)
                {
                    discount = 0.30m;
                    pricePerStudio = pricePerStudio - (pricePerStudio * discount);
                    pricePerApartament = pricePerApartament - (pricePerApartament * 0.10m);
                }
            }
            else if (mount == "June")
            {
                pricePerStudio = 75.20m;
                pricePerApartament = 68.70m;
                if (numberOfNight > 14)
                {
                    discount = 0.20m;
                    pricePerStudio = pricePerStudio - (pricePerStudio * discount);
                    pricePerApartament = pricePerApartament - (pricePerApartament * 0.10m);
                }
            }
            else if (mount == "September")
            {
                pricePerStudio = 75.20m;
                pricePerApartament = 68.70m;
                if (numberOfNight > 14)
                {
                    discount = 0.20m;
                    pricePerStudio = pricePerStudio - (pricePerStudio * discount);
                    pricePerApartament = pricePerApartament - (pricePerApartament * 0.10m);
                }
            }
            else if (mount == "July")
            {
                pricePerStudio = 76m;
                pricePerApartament = 77m;
                if (numberOfNight > 14)
                {
                    pricePerApartament = pricePerApartament - (pricePerApartament * 0.10m);
                }
            }
            else if (mount == "August")
            {
                pricePerStudio = 76m;
                pricePerApartament = 77m;
                if (numberOfNight > 14)
                {
                    pricePerApartament = pricePerApartament - (pricePerApartament * 0.10m);
                }
            }
            decimal totalPriceApartament = pricePerApartament * numberOfNight;
            decimal totalPriceStudio = pricePerStudio * numberOfNight;

            Console.WriteLine($"Apartment: {totalPriceApartament:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
        }
    }
}
