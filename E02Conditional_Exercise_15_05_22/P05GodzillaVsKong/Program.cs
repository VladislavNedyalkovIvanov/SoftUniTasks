using System;

namespace P05GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetOfMovie = double.Parse(Console.ReadLine());
            double numberStatists = double.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());
            double decorOfMovie = budgetOfMovie * 0.1;

            if (numberStatists > 150)
            {
                pricePerStatist = pricePerStatist - (pricePerStatist * 0.1);
            }
            double allCosts = (numberStatists * pricePerStatist) + decorOfMovie;
            if (allCosts > budgetOfMovie)
            {
                double moneyNeeds = allCosts - budgetOfMovie;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeds:F2} leva more.");
            }    
            if (budgetOfMovie >= allCosts)
            {
                double moneyLefts = budgetOfMovie - allCosts;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLefts:F2} leva left.");
            }
        }
    }
}
