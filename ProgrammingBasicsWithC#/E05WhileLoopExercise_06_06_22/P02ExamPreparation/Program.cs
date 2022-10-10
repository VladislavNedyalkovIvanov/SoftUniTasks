using System;

namespace P02ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumberLowEstimates = int.Parse(Console.ReadLine());
            string exercises;
            string nameOfExercise = "";

            int numberOfLowEstimates = 0;
            double taskEstimates = 0;
            double averageAll = 0;
            while ((exercises = Console.ReadLine()) != "Enough")
            {
                int assessment = int.Parse(Console.ReadLine());
                taskEstimates++;
                averageAll += assessment;
                if (assessment <= 4)
                {
                    numberOfLowEstimates++;
                    if (numberOfLowEstimates >= minNumberLowEstimates)
                    {
                        Console.WriteLine($"You need a break, {numberOfLowEstimates} poor grades.");
                        break;
                    }

                }
                nameOfExercise = exercises;

            }
            if (numberOfLowEstimates < minNumberLowEstimates)
            {
                averageAll = averageAll / taskEstimates;

                Console.WriteLine($"Average score: {averageAll:f2}");
                Console.WriteLine($"Number of problems: {taskEstimates}");
                Console.WriteLine($"Last problem: {nameOfExercise}");
            }


        }
    }
}
