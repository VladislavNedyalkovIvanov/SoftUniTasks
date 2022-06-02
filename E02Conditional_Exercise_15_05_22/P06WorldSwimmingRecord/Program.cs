using System;

namespace P06WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecordInSec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecForMeter = double.Parse(Console.ReadLine());
            double allTimeThatNeeds = distanceInMeters * timeInSecForMeter;
            double allTimeThatBe = (distanceInMeters / 15);
            double allTimeThatBeAd = Math.Floor(allTimeThatBe);
            double allTimeThatBeAdd = allTimeThatBeAd * 12.5;
            double allTimeForSwim = allTimeThatBeAdd + allTimeThatNeeds;

            if (allTimeForSwim < worldRecordInSec)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {allTimeForSwim:F2} seconds.");
            }
            else if(allTimeForSwim >= worldRecordInSec)
            {
                double theTimeLess = allTimeForSwim - worldRecordInSec;
                Console.WriteLine($"No, he failed! He was {theTimeLess:F2} seconds slower.");
            }
        }
    }
}
