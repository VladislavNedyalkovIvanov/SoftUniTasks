using System;

namespace _09.Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal thePriceForMeter = 7.61m;
            decimal percentDissCount = 0.18m;

            decimal theTotalPrice = meters * thePriceForMeter;
            decimal theDisscount = percentDissCount * theTotalPrice;
            decimal allCost = theTotalPrice - theDisscount;

            Console.WriteLine($"The final price is: {allCost} lv.");
            Console.WriteLine($"The disscount is: {theDisscount} lv.");
        }
    }
}
