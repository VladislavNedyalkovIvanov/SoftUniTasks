using System;

namespace P08Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            double allEvaluations = 0;
            int classOfMimi = 1;
            int timesPoor = 0;
            int i = 1;
            while (i <= 12 && timesPoor < 2)
            {
                double evaluations = double.Parse(Console.ReadLine());
                if (evaluations >= 4.00)
                {
                    classOfMimi++;
                    allEvaluations += evaluations;
                    i++;
                    continue;
                }
                else
                {
                    timesPoor++;
                }
            }
            if (timesPoor <= 1)
            {
                double average = allEvaluations / 12;
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {average:f2}");
            }
            else if (timesPoor >= 2)
            {
                Console.WriteLine($"{nameOfStudent} has been excluded at {classOfMimi} grade");
            }
        }
    }
}
