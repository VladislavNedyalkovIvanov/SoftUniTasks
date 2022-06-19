using System;

namespace P03SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enters;
            int sumSimpleNumbers = 0;
            int sumComplicatedNumb = 0;

            while ((enters = Console.ReadLine()) != "stop")
            {
                bool nonPrime = false;
                if (enters == "stop")
                {
                    break;
                }
                int numbers = int.Parse(enters);
                if (numbers < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                else if (numbers == 1)
                {
                    sumComplicatedNumb += numbers;
                    continue;
                }
                for (int i = 2; i < numbers; i++)
                {
                    if (numbers % i == 0)
                    {
                        nonPrime = true;
                        break;
                    }

                }
                if (nonPrime == true)
                {
                    sumComplicatedNumb += numbers;
                }
                else if (nonPrime == false)
                {
                    sumSimpleNumbers += numbers;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumSimpleNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumComplicatedNumb}");
        }

    }
}
