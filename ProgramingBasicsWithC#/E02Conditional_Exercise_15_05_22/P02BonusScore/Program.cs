using System;

namespace P02BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double Bonus = 0;

            if (number <= 100)
                {
                Bonus = 5;
                }    
            else if (number <= 999)
            {
                Bonus = number * 0.2;
            }
            else
            {
                Bonus = number * 0.1;
            }    

            if (number % 2 == 0)
            {
                Bonus = Bonus + 1;
            }    
            else if (number % 10 == 5)
            {
                Bonus = Bonus + 2;
            }
            Console.WriteLine(Bonus);
            Console.WriteLine(Bonus + number);
        }
    }
}
