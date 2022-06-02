using System;

namespace P04ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.60;
            double speakingToyPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double excurseyPrise = double.Parse(Console.ReadLine());
            double puzzlesNumber = double.Parse(Console.ReadLine());
            double speakingToyNumb = double.Parse(Console.ReadLine());
            double bearsToyNumber = double.Parse(Console.ReadLine());
            double minionsNumber = double.Parse(Console.ReadLine());
            double trucksNumber = double.Parse(Console.ReadLine());

            double allPrice = (puzzlePrice * puzzlesNumber) + (speakingToyPrice * speakingToyNumb) + (bearPrice * bearsToyNumber) + (minionPrice * minionsNumber) + (truckPrice * trucksNumber);
            double allNumber = puzzlesNumber + speakingToyNumb + bearsToyNumber + minionsNumber + trucksNumber;
            double allCosts = 0;
            if (allNumber >= 50)
            {
                allCosts = allPrice - (allPrice * 0.25);
            }
            else
            {
                allCosts = allPrice;
            }
            double allTaken = allCosts - (allCosts * 0.1);
            if (allTaken >= excurseyPrise)
            {
                double allLeft = allTaken - excurseyPrise;
                Console.WriteLine($"Yes! {allLeft:F2} lv left.");
            }
            else if (excurseyPrise > allTaken)
            {
                double allNeeds = excurseyPrise - allTaken;
                Console.WriteLine($"Not enough money! {allNeeds:F2} lv needed.");
            }
        }
    }
}
