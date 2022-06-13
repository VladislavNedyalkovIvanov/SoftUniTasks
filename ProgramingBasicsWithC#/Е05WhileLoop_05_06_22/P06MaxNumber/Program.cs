using System;

namespace P06MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string value;
            while ((value = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(value);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
