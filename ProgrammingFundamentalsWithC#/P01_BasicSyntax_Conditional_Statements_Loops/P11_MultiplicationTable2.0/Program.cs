using System;

namespace P11_MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int product = 0;

            if (times <= 10)
            {
                for (int i = times; i <= 10; i++)
                {
                    product = theInteger * i;
                    Console.WriteLine($"{theInteger} X {i} = {product}");
                }
            }
            else
            {
                product = theInteger * times;
                Console.WriteLine($"{theInteger} X {times} = {product}");
            }
        }
    }
}
