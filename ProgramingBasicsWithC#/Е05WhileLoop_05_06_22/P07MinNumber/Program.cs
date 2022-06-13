using System;

namespace P07MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string value;
            while ((value = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(value);
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
