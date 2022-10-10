using System;

namespace P05AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 0;

            string any;
            while ((any = Console.ReadLine()) != "NoMoreMoney")
            {
                double increase = double.Parse(any);
                if (increase >= 0)
                {
                    Console.WriteLine($"Increase: {increase:f2}");
                    money += increase;
                }
                else if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {money:f2}");
        }
    }
}
