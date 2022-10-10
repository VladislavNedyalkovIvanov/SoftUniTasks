using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Temperature = double.Parse(Console.ReadLine());
            if (Temperature >= 35.01)
            {
                Console.WriteLine("unknown");
            }
            else if (Temperature >= 26.00)
            {
                Console.WriteLine("Hot");
            }
            else if (Temperature >= 20.1)
            {
                Console.WriteLine("Warm");
            }
            else if (Temperature >= 15.00)
            {
                Console.WriteLine("Mild");
            }
            else if (Temperature >= 12.00)
            {
                Console.WriteLine("Cool");
            }
            else if (Temperature >= 5.00)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }

    }
}
