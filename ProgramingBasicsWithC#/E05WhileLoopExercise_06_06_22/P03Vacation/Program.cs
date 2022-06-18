using System;

namespace P03Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double avaiableMoney = double.Parse(Console.ReadLine());

            int fiveDaysSpend = 0;
            double actionMoney = 0;
            int daysAll = 0;
            string action;
            while (avaiableMoney < neededMoney && fiveDaysSpend < 5)
            {
                action = Console.ReadLine();
                if (action == "save")
                {
                    actionMoney = double.Parse(Console.ReadLine());
                    avaiableMoney += actionMoney;
                    fiveDaysSpend = 0;

                }
                else if (action == "spend")
                {
                    actionMoney = double.Parse(Console.ReadLine());
                    avaiableMoney -= actionMoney;
                    if (avaiableMoney < 0)
                    {
                        avaiableMoney = 0;
                    }
                    fiveDaysSpend += 1;
                }
                daysAll++;
                
            }
            if (avaiableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysAll} days.");
            }
            if (fiveDaysSpend >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysAll}");
            }

        }
    }
}
