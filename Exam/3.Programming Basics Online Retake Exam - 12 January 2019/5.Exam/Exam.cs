using System;


class Exam
{
    static void Main()
    {
        int numOfStudents = int.Parse(Console.ReadLine());

        double examEvaluation = 0.0;
        double totalSumExamEvaluation = 0;
        double counterOne = 0;
        double counterTwo = 0;
        double counterThird = 0;
        double counterFourth = 0;

        double percentOne = 0;
        double percentTwo = 0;
        double percentThird = 0;
        double percentFourth = 0;

        double averageEvaluation = 0;

        for (int i = 1; i <= numOfStudents; i++)
        {
            examEvaluation = double.Parse(Console.ReadLine());
            totalSumExamEvaluation += examEvaluation;

            if (examEvaluation >= 2.00 && examEvaluation <= 2.99)
            {
                counterOne++;
            }
            else if (examEvaluation >= 3.00 && examEvaluation <= 3.99)
            {
                counterTwo++;
            }
            else if (examEvaluation >= 4.00 && examEvaluation <= 4.99)
            {
                counterThird++;
            }
            else if (examEvaluation >= 5.00)
            {
                counterFourth++;
            }
        }

        averageEvaluation = totalSumExamEvaluation / numOfStudents;

        percentOne = (counterOne / numOfStudents) * 100;
        percentTwo = (counterTwo / numOfStudents) * 100;
        percentThird = (counterThird / numOfStudents) * 100;
        percentFourth = (counterFourth / numOfStudents) * 100;

        Console.WriteLine($"Top students: {percentFourth:F2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {percentThird:F2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {percentTwo:F2}%");
        Console.WriteLine($"Fail: {percentOne:F2}%");
        Console.WriteLine($"Average: {averageEvaluation:F2}");
    }
}
