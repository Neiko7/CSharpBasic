using System;


class Graduation_Part_Two
{
    static void Main()
    {
        string name = Console.ReadLine();

        int counter = 1;
        int counterTwo = 0;
        double sum = 0.0;
        double grade = 0.0;
        double average = 0.0;
        bool logical = false;

        while (counter <= 12)
        {
            grade = double.Parse(Console.ReadLine());

            if (grade >= 4)
            {
                counter++;
                sum += grade;
            }
            else if (grade < 4)
            {
                counterTwo++;
            }

            if (counterTwo >= 2)
            {
                logical = true;
                break;
            }

          
        }

        if (logical == false)
        {
            average = sum / 12;

            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
        }
        else
        {
            Console.WriteLine($"{name} has been excluded at {counter} grade");
        }
    }
}

