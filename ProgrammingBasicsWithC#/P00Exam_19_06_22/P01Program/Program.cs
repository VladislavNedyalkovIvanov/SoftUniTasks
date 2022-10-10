using System;

namespace _1Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gramFats = 9;
            double gramProteins = 4;
            double gramSugars = 4;

            int percentFats = int.Parse(Console.ReadLine());
            int percentProteins = int.Parse(Console.ReadLine());
            int percentSugars = int.Parse(Console.ReadLine());

            double percentFatsDouble = (double)percentFats * 0.01;
            double percentProteinsDouble = (double)percentProteins * 0.01;
            double percentSugarsDouble = (double)percentSugars * 0.01;

            int allCalories = int.Parse(Console.ReadLine());
            int percentOfWater = int.Parse(Console.ReadLine());
            double allCaloriesDouble = allCalories * 1.00;

           
            double allFats = (allCalories * percentFatsDouble) / gramFats;
            double allProteins = (allCalories * percentProteinsDouble) / gramProteins;
            double allSugars = (allCalories * percentSugarsDouble) / gramSugars;
            double percentOfWaterD = percentOfWater * 0.01;



            double kgFoods = allFats + allProteins + allSugars;
            double kgFoodsWithWat = allCaloriesDouble / kgFoods;
            kgFoodsWithWat -= (kgFoodsWithWat * percentOfWaterD);

            Console.WriteLine($"{kgFoodsWithWat:f4}");


        }
    }
}
