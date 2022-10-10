using System;

namespace P08NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

			int maxNumber = int.MinValue;
			int minNumber = int.MaxValue;
			for (int i = 1; i <= n; i++)
			{
				int currentNumb = int.Parse(Console.ReadLine());

				if (currentNumb > maxNumber)
				{
					maxNumber = currentNumb;
				}
				if (currentNumb < minNumber)
				{
					minNumber = currentNumb;
				}
			}
			Console.WriteLine($"Max number: {maxNumber}");
			Console.WriteLine($"Min number: {minNumber}");
		}
	}
}
