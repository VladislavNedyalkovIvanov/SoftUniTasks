using System;

namespace P03Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numbersTo200 = 0;
            int numbers200to399 = 0;
            int numbers400to599 = 0;
            int numbers600to799 = 0;
            int numbersUpFrom800 = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumb = int.Parse(Console.ReadLine());
                if (currentNumb < 200)
                {
                    numbersTo200 += 1;
                }
                else if (currentNumb >= 200 && currentNumb < 400)
                {
                    numbers200to399 += 1;
                }
                else if (currentNumb >= 400 && currentNumb < 600)
                {
                    numbers400to599 += 1;
                }
                else if (currentNumb >= 600 && currentNumb < 800)
                {
                    numbers600to799 += 1;
                }
                else
                {
                    numbersUpFrom800 += 1;
                }
            }
            double percent1 = ((double)numbersTo200 / n) * 100;
            double percent2 = ((double)numbers200to399 / n) * 100;
            double percent3 = ((double)numbers400to599 / n) * 100;
            double percent4 = ((double)numbers600to799 / n) * 100;
            double percent5 = ((double)numbersUpFrom800 / n) * 100;

            Console.WriteLine($"{percent1:F2}%");
            Console.WriteLine($"{percent2:F2}%");
            Console.WriteLine($"{percent3:F2}%");
            Console.WriteLine($"{percent4:F2}%");
            Console.WriteLine($"{percent5:F2}%");
        }
    }
}
