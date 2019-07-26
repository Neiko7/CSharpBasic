using System;


class Train_The_Trainers
{
    static void Main()
    {
        int numberOfJudge = int.Parse(Console.ReadLine());
        string presentation = string.Empty;

        double sumEvaluation = 0;
        double totalSumEvaluation = 0;
        int counter = 0;

        while ((presentation = Console.ReadLine()) != "Finish")
        {
            
            for (int i = 1; i <= numberOfJudge; i++)
            {
                double evaluation = double.Parse(Console.ReadLine());
                counter++;
                sumEvaluation += evaluation;
            }

            Console.WriteLine($"{presentation} - {sumEvaluation / numberOfJudge:F2}.");
            totalSumEvaluation += sumEvaluation;
            sumEvaluation = 0;

        }

        Console.WriteLine($"Student's final assessment is {totalSumEvaluation / counter:F2}.");
    }
}

