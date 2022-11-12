using System;

namespace P02_PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
