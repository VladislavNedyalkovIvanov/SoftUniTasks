using System;

namespace P07SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string genderOfChildrens = Console.ReadLine();
            int numberOfChildrens = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            double pricePerNight = 0;
            string sport = null;

            if (genderOfChildrens == "girls")
            {
                switch (season)
                {
                    case "Winter":
                        pricePerNight = 9.60;
                        sport = "Gymnastics";
                        break;
                    case "Spring":
                        pricePerNight = 7.20;
                        sport = "Athletics";
                        break;
                    case "Summer":
                        pricePerNight = 15;
                        sport = "Volleyball";
                        break;
                }
            }
            else if (genderOfChildrens == "boys")
            {
                switch (season)
                {
                    case "Winter":
                        pricePerNight = 9.60;
                        sport = "Judo";
                        break;
                    case "Spring":
                        pricePerNight = 7.20;
                        sport = "Tennis";
                        break;
                    case "Summer":
                        pricePerNight = 15;
                        sport = "Football";
                        break;
                }    

            }
            else if (genderOfChildrens == "mixed")
            {
                switch (season)
                {
                    case "Winter":
                        pricePerNight = 10;
                        sport = "Ski";
                        break;
                    case "Spring":
                        pricePerNight = 9.50;
                        sport = "Cycling";
                        break;
                    case "Summer":
                        pricePerNight = 20;
                        sport = "Swimming";
                        break;
                }
            }
            double allCosts = pricePerNight * (numberOfChildrens * numberOfNights);
            if (numberOfChildrens >= 50)
            {
                allCosts -= allCosts * 0.50;
            }
            else if (numberOfChildrens >= 20 && numberOfChildrens < 50)
            {
                allCosts -= allCosts * 0.15;
            }
            else if (numberOfChildrens >= 10 && numberOfChildrens < 20)
            {
                allCosts -= allCosts * 0.05;
            }
            Console.WriteLine($"{sport} {allCosts:f2} lv.");
        }
    }
}
