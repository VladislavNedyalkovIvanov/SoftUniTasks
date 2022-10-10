using System;

namespace P03Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrisantemas = int.Parse(Console.ReadLine());
            int rouses = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holyday = Console.ReadLine(); 

            double allCosts = 0;
            if (season == "Spring" || season == "Summer")
            {
                allCosts += hrisantemas * 2.00;
                allCosts += rouses * 4.10;
                allCosts += laleta * 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                allCosts += hrisantemas * 3.75;
                allCosts += rouses * 4.50;
                allCosts += laleta * 4.15;
            }
            switch (holyday)
            {
                case "Y":
                    allCosts += allCosts * 0.15;
                    break;
            }
            if (laleta > 7 && season == "Spring")
            {
                allCosts -= allCosts * 0.05;
            }
            if (rouses >= 10 && season == "Winter")
            {
                allCosts -= allCosts * 0.10;
            }
            int allFlowers = hrisantemas + rouses + laleta;
            if (allFlowers > 20)
            {
                allCosts -= allCosts * 0.20;
            }
            allCosts += 2;
            Console.WriteLine($"{allCosts:f2}");
        }
    }
}
