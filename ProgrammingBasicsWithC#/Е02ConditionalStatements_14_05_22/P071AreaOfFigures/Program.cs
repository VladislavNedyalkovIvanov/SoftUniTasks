using System;

namespace P071AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string figureType = Console.ReadLine();

			double area = 0;                                    // ако искаме да използваме променлива в проверките, я пишем извън тях;
			if (figureType == "square")
			{
				double a = double.Parse(Console.ReadLine());
				area = a * a;
			}
			else if (figureType == "rectangle")
			{
				double a = double.Parse(Console.ReadLine());
				double b = double.Parse(Console.ReadLine());
				area = a * b;
			}
			else if (figureType == "circle")
			{
				double r = double.Parse(Console.ReadLine());
				area = Math.PI * r * r;
			}
			else if (figureType == "triangle")
			{
				double a = double.Parse(Console.ReadLine());
				double bh = double.Parse(Console.ReadLine());
				area = (a * bh) / 2;
			}
			Console.WriteLine($"{area:F3}");
		}
    }
}
