using System;


class Graduation
{
    static void Main()
    {
        string name = Console.ReadLine();

        int counter = 0;
        double sum = 0.0;
        double grade = 0.0;

        while (counter < 12)
        {
            grade = double.Parse(Console.ReadLine());

            if (grade >= 4)
            {
                sum += grade;
                counter++;
            }
        }
        sum /= 12;

        Console.WriteLine($"{name} graduated. Average grade: {sum:F2}");
    }
}
