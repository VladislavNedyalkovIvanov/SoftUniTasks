using System;

namespace P03SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());

            int numberAdd = 0;
            while (number1 > numberAdd)
            {
                numberAdd += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(numberAdd);
        }
    }
}
