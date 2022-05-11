using System;

namespace _03.Exercise_Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposite = double.Parse(Console.ReadLine());
            double termOfDeposite = double.Parse(Console.ReadLine());
            double yearInterestRate = double.Parse(Console.ReadLine());
            double yearInterestCalc = yearInterestRate * 0.01;
            double finalPrice = deposite + termOfDeposite * ((deposite * yearInterestCalc) / 12);

            Console.WriteLine(finalPrice);
        }
    }
}
