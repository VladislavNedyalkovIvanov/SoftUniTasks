using System;

namespace P04CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int toysFromOddYears = 0;
            double moneyFromEvenBirthday = 0;
            double moneyLeft = 0;
            double moneyNeed = 0;
            double moneyEveryYear = 10.00;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    toysFromOddYears += 1;
                }
                else if (i % 2 == 0)
                {
                    moneyFromEvenBirthday += moneyEveryYear;
                    moneyFromEvenBirthday -= 1.00;
                    moneyEveryYear += 10.00;
                }
            }

            double priceForWashMachine = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());
            int moneyFromToys = pricePerToy * toysFromOddYears;
            double allMoney = moneyFromToys + moneyFromEvenBirthday;

            if (allMoney >= priceForWashMachine)
            {
                moneyLeft = allMoney - priceForWashMachine;
                Console.WriteLine($"Yes! {moneyLeft:F2}");
            }
            else if (allMoney < priceForWashMachine)
            {
                moneyNeed = priceForWashMachine - allMoney;
                Console.WriteLine($"No! {moneyNeed:F2}");
            }
        }
    }
}
