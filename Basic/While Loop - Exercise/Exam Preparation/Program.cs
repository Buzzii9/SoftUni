using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());
            double evaluationSum = 0;
            int evaluationCount = 0;
            string lastExercise = "";
            int evaluation = 0;
            int failedCount = 0;

            string input = Console.ReadLine();

            while (input != "Enough")
            {
                lastExercise = input;
                evaluation = int.Parse(Console.ReadLine());
                evaluationSum += evaluation;
                evaluationCount++;

                if (evaluation <= 4)
                {
                    failedCount++;
                    if (failedCount == failedTimes)
                    {
                        Console.WriteLine($"You need a break, {failedCount} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            if (failedCount != failedTimes)
            {
                double evaluationAv = evaluationSum / evaluationCount;

                Console.WriteLine($"Average score: {evaluationAv:F2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }

        }
    }
}
