using System;

namespace P04TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());

            bool exit = false;
            double assessmentSum = 0;
            string presentationName;
            int students = 0;
            while ((presentationName = Console.ReadLine()) != "Finish")
            {
                if (presentationName == "Finish")
                {
                    exit = true;
                    break;
                }
                double assessment = 0;
                for (int student = 1; student <= peoples; student++)
                {
                    if (exit == true)
                    {
                        break;
                    }
                    double assessmentJury = double.Parse(Console.ReadLine());
                    assessment += assessmentJury;
                }
                assessment = assessment / peoples;
                students++;
                assessmentSum += assessment;
                Console.WriteLine($"{presentationName} - {assessment:F2}.");
            }
            assessmentSum = assessmentSum / students;
            Console.WriteLine($"Student's final assessment is {assessmentSum:F2}.");
        }
    }
}
