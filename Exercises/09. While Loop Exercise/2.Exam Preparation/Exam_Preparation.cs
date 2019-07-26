using System;


class Exam_Preparation
{
    static void Main()
    {
        int numberOfBadGreads = int.Parse(Console.ReadLine());

        string taskName = string.Empty;
        string lastProblem = string.Empty;
        double evaluation = 0.0;
        double averigeScore = 0.0;
        int numberOfGoodScore = 0;
        int counter = 0;


        while (numberOfGoodScore < numberOfBadGreads)
        {
            taskName = Console.ReadLine();

            if (taskName == "Enough")
            {
                break;
            }

            evaluation = int.Parse(Console.ReadLine());
            counter++;
            averigeScore += evaluation;
            lastProblem = taskName;
            

            if (evaluation <= 4)
            {
                numberOfGoodScore++;
            }
        }

        averigeScore /= counter;

        if (numberOfGoodScore == numberOfBadGreads)
        {
            Console.WriteLine("You need a break, {0} poor grades.", numberOfBadGreads);
        }

        else
        {
            Console.WriteLine("Average score: {0:F2}", averigeScore);
            Console.WriteLine("Number of problems: {0}", counter);
            Console.WriteLine("Last problem: {0}", lastProblem);

        }

    }
}
