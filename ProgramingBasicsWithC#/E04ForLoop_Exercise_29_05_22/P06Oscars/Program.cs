using System;

namespace P06Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n && points < 1250.5; i++)
            {
                string nameOfEvaluating = Console.ReadLine();
                int length = nameOfEvaluating.Length;
                double pointsOfEvaluating = double.Parse(Console.ReadLine());
                points += ((length * pointsOfEvaluating) / 2);
            }    
            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {points:F1}!");
            }
            else
            {
                points = 1250.50 - points;
                Console.WriteLine($"Sorry, {nameOfActor} you need {points:F1} more!");
            }
        }
    }
}
