using System;

namespace E06OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0;
           switch (symbol)
            {
                case '+':
                    result = N1 + N2;
                    break;
                case '-':
                    result = N1 - N2;
                    break;
                case '*':
                    result = N1 * N2;
                    break;

            }
            if (result != 0)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }
            }

            if (symbol == '/')
            {
                if (N2 != 0)
                {
                    result = (double)N1 / (double)N2;
                    Console.WriteLine($"{N1} {symbol} {N2} = {result:F2}");
                }
                else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
            else if (symbol == '%')
            {
                if (N2 != 0)
                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} {symbol} {N2} = {result}");
                }
                else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
        }
    }
}
