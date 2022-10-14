using System;

namespace P10_LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            int asciNumb = (int)ch;

            if (asciNumb >= 65 && asciNumb <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (asciNumb >= 97 && asciNumb <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
